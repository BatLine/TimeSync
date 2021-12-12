using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSync
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var args = Environment.GetCommandLineArgs();
            var _dc = new DomainController();
            var runOnStartup = args.Contains("--onstartup");

            if (!_dc.IsUserAdministrator()) {
                var exeName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                startInfo.Verb = "runas";
                if (runOnStartup)
                    startInfo.Arguments = "--onstartup";
                Process.Start(startInfo);
                return;
            }

            if (runOnStartup) {
                _dc.SyncTime();
                return;
            }

            Application.Run(new frmMain(_dc));
        }
    }
}
