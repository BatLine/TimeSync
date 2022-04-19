
namespace TimeSync
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSync = new System.Windows.Forms.Button();
            this.btnEnableRunOnStartup = new System.Windows.Forms.Button();
            this.btnDisableRunOnStartup = new System.Windows.Forms.Button();
            this.btnCheckTimeDifference = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeLabel = new System.Windows.Forms.Label();
            this.btnUpdateTimeAfterSync = new System.Windows.Forms.Button();
            this.btnShowDebugInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(253, 30);
            this.btnSync.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(388, 279);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnEnableRunOnStartup
            // 
            this.btnEnableRunOnStartup.Enabled = false;
            this.btnEnableRunOnStartup.Location = new System.Drawing.Point(40, 30);
            this.btnEnableRunOnStartup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnableRunOnStartup.Name = "btnEnableRunOnStartup";
            this.btnEnableRunOnStartup.Size = new System.Drawing.Size(191, 54);
            this.btnEnableRunOnStartup.TabIndex = 1;
            this.btnEnableRunOnStartup.Text = "Enable run on startup";
            this.btnEnableRunOnStartup.UseVisualStyleBackColor = true;
            this.btnEnableRunOnStartup.Click += new System.EventHandler(this.btnEnableRunOnStartup_Click);
            // 
            // btnDisableRunOnStartup
            // 
            this.btnDisableRunOnStartup.Enabled = false;
            this.btnDisableRunOnStartup.Location = new System.Drawing.Point(40, 91);
            this.btnDisableRunOnStartup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisableRunOnStartup.Name = "btnDisableRunOnStartup";
            this.btnDisableRunOnStartup.Size = new System.Drawing.Size(191, 54);
            this.btnDisableRunOnStartup.TabIndex = 2;
            this.btnDisableRunOnStartup.Text = "Disable run on startup";
            this.btnDisableRunOnStartup.UseVisualStyleBackColor = true;
            this.btnDisableRunOnStartup.Click += new System.EventHandler(this.btnDisableRunOnStartup_Click);
            // 
            // btnCheckTimeDifference
            // 
            this.btnCheckTimeDifference.Location = new System.Drawing.Point(40, 153);
            this.btnCheckTimeDifference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckTimeDifference.Name = "btnCheckTimeDifference";
            this.btnCheckTimeDifference.Size = new System.Drawing.Size(191, 54);
            this.btnCheckTimeDifference.TabIndex = 3;
            this.btnCheckTimeDifference.Text = "Check time difference";
            this.btnCheckTimeDifference.UseVisualStyleBackColor = true;
            this.btnCheckTimeDifference.Click += new System.EventHandler(this.btnCheckTimeDifference_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time after sync:";
            // 
            // lblTimeLabel
            // 
            this.lblTimeLabel.AutoSize = true;
            this.lblTimeLabel.Location = new System.Drawing.Point(365, 313);
            this.lblTimeLabel.Name = "lblTimeLabel";
            this.lblTimeLabel.Size = new System.Drawing.Size(34, 17);
            this.lblTimeLabel.TabIndex = 5;
            this.lblTimeLabel.Text = "time";
            // 
            // btnUpdateTimeAfterSync
            // 
            this.btnUpdateTimeAfterSync.Location = new System.Drawing.Point(40, 215);
            this.btnUpdateTimeAfterSync.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTimeAfterSync.Name = "btnUpdateTimeAfterSync";
            this.btnUpdateTimeAfterSync.Size = new System.Drawing.Size(191, 54);
            this.btnUpdateTimeAfterSync.TabIndex = 6;
            this.btnUpdateTimeAfterSync.Text = "Update time after sync";
            this.btnUpdateTimeAfterSync.UseVisualStyleBackColor = true;
            this.btnUpdateTimeAfterSync.Click += new System.EventHandler(this.btnUpdateTimeAfterSync_Click);
            // 
            // btnShowDebugInfo
            // 
            this.btnShowDebugInfo.Location = new System.Drawing.Point(40, 277);
            this.btnShowDebugInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDebugInfo.Name = "btnShowDebugInfo";
            this.btnShowDebugInfo.Size = new System.Drawing.Size(191, 54);
            this.btnShowDebugInfo.TabIndex = 7;
            this.btnShowDebugInfo.Text = "Show Debug Info";
            this.btnShowDebugInfo.UseVisualStyleBackColor = true;
            this.btnShowDebugInfo.Click += new System.EventHandler(this.btnShowDebugInfo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 339);
            this.Controls.Add(this.btnShowDebugInfo);
            this.Controls.Add(this.btnUpdateTimeAfterSync);
            this.Controls.Add(this.lblTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckTimeDifference);
            this.Controls.Add(this.btnDisableRunOnStartup);
            this.Controls.Add(this.btnEnableRunOnStartup);
            this.Controls.Add(this.btnSync);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeSync";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnEnableRunOnStartup;
        private System.Windows.Forms.Button btnDisableRunOnStartup;
        private System.Windows.Forms.Button btnCheckTimeDifference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeLabel;
        private System.Windows.Forms.Button btnUpdateTimeAfterSync;
        private System.Windows.Forms.Button btnShowDebugInfo;
    }
}

