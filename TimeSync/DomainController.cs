using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;

namespace TimeSync {
    public class DomainController {
        private struct SYSTEMTIME {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetSystemTime(ref SYSTEMTIME st);

        private void SetSystemDate(short _pYear, short _pMonth, short _pDay, short _pHour = 0, short _pMinute = 0, short _pSecond = 0) {
            if (IsUserAdministrator()) {
                var st = new SYSTEMTIME {
                    wYear = _pYear,
                    wMonth = _pMonth,
                    wDay = _pDay,
                    wHour = _pHour,
                    wMinute = _pMinute,
                    wSecond = _pSecond
                };
                // must be short
                SetSystemTime(ref st); // invoke this method.
                Console.WriteLine("Systemtime set");
            } else {
                MessageBox.Show("You have not Windows Administrator Access.\nPlease Login Windows with Administrator Rights.");
            }
        }

        public bool IsUserAdministrator() {
            using (var identity = WindowsIdentity.GetCurrent()) {
                var principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private DateTime GetNetworkTime() {
            try {
                //default Windows time server
                const string ntpServer = "time.windows.com";

                // NTP message size - 16 bytes of the digest (RFC 2030)
                var ntpData = new byte[48];

                //Setting the Leap Indicator, Version Number and Mode values
                ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

                var addresses = Dns.GetHostEntry(ntpServer).AddressList;

                //The UDP port number assigned to NTP is 123
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                //NTP uses UDP
                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                socket.Connect(ipEndPoint);

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();

                //Offset to get to the "Transmit Timestamp" field (time at which the reply 
                //departed the server for the client, in 64-bit timestamp format."
                const byte serverReplyTime = 40;

                //Get the seconds part
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

                //Get the seconds fraction
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

                //Convert From big-endian to little-endian
                intPart = SwapEndianness(intPart);
                fractPart = SwapEndianness(fractPart);

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

                //**UTC** time
                var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);
                
                return networkDateTime;
            } catch (Exception e) {
                MessageBox.Show(e.Message);
                return Convert.ToDateTime ("12-31-1900");
            }
        }

        private DateTime GetNetworkTimeToLocal() {
            return GetNetworkTime().ToLocalTime();
        }

        private static uint SwapEndianness(ulong x) {
            return (uint)(((x & 0x000000ff) << 24) + 
                          ((x & 0x0000ff00) << 8) + 
                          ((x & 0x00ff0000) >> 8) + 
                          ((x & 0xff000000) >> 24));
        }

        public void SyncTime() {
            var time = GetNetworkTime();
            SetSystemDate((short)time.Year, (short)time.Month, (short)time.Day, (short)(time.Hour), (short)time.Minute, (short)time.Second);
        }

        public DateTime UpdateTimeAfterSync() {
            return GetNetworkTimeToLocal();
        }

        public string DebugInfo() {
            var result = string.Empty;

            var time = GetNetworkTime();
            result += $"UTC:\nKind: {time.Kind}\nIs DaylightSavingsTime: {time.IsDaylightSavingTime()}\nTime: {time.ToLongTimeString()}";
            time = time.ToLocalTime();
            result += $"\n\nLocal:\nKind: {time.Kind}\nIs DaylightSavingsTime: {time.IsDaylightSavingTime()}\nTime: {time.ToLongTimeString()}\n";
            result += $"\n\nCurrent TimeZone:\nDST Name: {TimeZone.CurrentTimeZone.DaylightName}\nStandard Name: {TimeZone.CurrentTimeZone.StandardName}\nIs DST: {TimeZone.CurrentTimeZone.IsDaylightSavingTime(DateTime.Now)}\nUTC Offset: {TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)}";

            return result;
        }

        public bool IsProgramRunAtStartup() {
            using (var ts = new TaskService()) {
                return ts.RootFolder.AllTasks.SingleOrDefault(t => t.Name.Equals("TimeSync")) != null;
            }
        }

        public bool SetRunAtStartup(bool enable = true) {
            using (var ts = new TaskService()) {
                if (!enable) {
                    ts.RootFolder.DeleteTask("TimeSync");
                    return true;
                }

                var td = ts.NewTask();
                var path = '"' + Application.ExecutablePath + '"';

                td.RegistrationInfo.Description = "Syncs time with windows time server";
                td.Triggers.Add(new LogonTrigger { Enabled = true });
                td.Principal.RunLevel = TaskRunLevel.Highest;
                td.Actions.Add(new ExecAction(path, "--onstartup", null));

                ts.RootFolder.RegisterTaskDefinition(@"TimeSync", td);
                return true;
            }
        }

        public void ShowTimeDifference() {
            var proc1 = new ProcessStartInfo {
                UseShellExecute = true,
                WorkingDirectory = @"C:\Windows\System32",
                FileName = @"C:\Windows\System32\cmd.exe",
                Verb = "runas",
                Arguments = "/c " + "w32tm /stripchart /computer:time.windows.com",
                WindowStyle = ProcessWindowStyle.Normal
            };
            Process.Start(proc1);
        }
    }
}
