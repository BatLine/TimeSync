using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSync {
    public partial class frmMain : Form {
        private DomainController _dc;

        public frmMain(DomainController _dc) {
            InitializeComponent();
            this._dc = _dc;
        }

        private void btnSync_Click(object sender, EventArgs e) {
            _dc.SyncTime();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            if (_dc.IsProgramRunAtStartup()) {
                btnDisableRunOnStartup.Enabled = true;
            } else {
                btnEnableRunOnStartup.Enabled = true;
            }

            btnUpdateTimeAfterSync_Click(sender, e);
        }

        private void btnEnableRunOnStartup_Click(object sender, EventArgs e) {
            if (!_dc.SetRunAtStartup()) return;
            btnEnableRunOnStartup.Enabled = false;
            btnDisableRunOnStartup.Enabled = true;
        }

        private void btnDisableRunOnStartup_Click(object sender, EventArgs e) {
            if (!_dc.SetRunAtStartup(false)) return;
            btnEnableRunOnStartup.Enabled = true;
            btnDisableRunOnStartup.Enabled = false;
        }

        private void btnCheckTimeDifference_Click(object sender, EventArgs e) {
            _dc.ShowTimeDifference();
        }

        private void btnUpdateTimeAfterSync_Click(object sender, EventArgs e) {
            lblTimeLabel.Text = _dc.UpdateTimeAfterSync().ToLongTimeString();
        }

        private void btnShowDebugInfo_Click(object sender, EventArgs e) {
            MessageBox.Show(_dc.DebugInfo(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
