
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
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(276, 144);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(185, 92);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnEnableRunOnStartup
            // 
            this.btnEnableRunOnStartup.Enabled = false;
            this.btnEnableRunOnStartup.Location = new System.Drawing.Point(30, 24);
            this.btnEnableRunOnStartup.Name = "btnEnableRunOnStartup";
            this.btnEnableRunOnStartup.Size = new System.Drawing.Size(143, 44);
            this.btnEnableRunOnStartup.TabIndex = 1;
            this.btnEnableRunOnStartup.Text = "Enable run on startup";
            this.btnEnableRunOnStartup.UseVisualStyleBackColor = true;
            this.btnEnableRunOnStartup.Click += new System.EventHandler(this.btnEnableRunOnStartup_Click);
            // 
            // btnDisableRunOnStartup
            // 
            this.btnDisableRunOnStartup.Enabled = false;
            this.btnDisableRunOnStartup.Location = new System.Drawing.Point(30, 74);
            this.btnDisableRunOnStartup.Name = "btnDisableRunOnStartup";
            this.btnDisableRunOnStartup.Size = new System.Drawing.Size(143, 44);
            this.btnDisableRunOnStartup.TabIndex = 2;
            this.btnDisableRunOnStartup.Text = "Disable run on startup";
            this.btnDisableRunOnStartup.UseVisualStyleBackColor = true;
            this.btnDisableRunOnStartup.Click += new System.EventHandler(this.btnDisableRunOnStartup_Click);
            // 
            // btnCheckTimeDifference
            // 
            this.btnCheckTimeDifference.Location = new System.Drawing.Point(30, 124);
            this.btnCheckTimeDifference.Name = "btnCheckTimeDifference";
            this.btnCheckTimeDifference.Size = new System.Drawing.Size(143, 44);
            this.btnCheckTimeDifference.TabIndex = 3;
            this.btnCheckTimeDifference.Text = "Check time difference";
            this.btnCheckTimeDifference.UseVisualStyleBackColor = true;
            this.btnCheckTimeDifference.Click += new System.EventHandler(this.btnCheckTimeDifference_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckTimeDifference);
            this.Controls.Add(this.btnDisableRunOnStartup);
            this.Controls.Add(this.btnEnableRunOnStartup);
            this.Controls.Add(this.btnSync);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnEnableRunOnStartup;
        private System.Windows.Forms.Button btnDisableRunOnStartup;
        private System.Windows.Forms.Button btnCheckTimeDifference;
    }
}

