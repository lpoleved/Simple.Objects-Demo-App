namespace DemoApp
{
    partial class FormStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.labelControlUsers = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNumberOfUsers = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNumberOfUserGroups = new DevExpress.XtraEditors.LabelControl();
            this.labelControlUserGroups = new DevExpress.XtraEditors.LabelControl();
            this.panelFooter = new DevExpress.XtraEditors.PanelControl();
            this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControlUsers
            // 
            this.labelControlUsers.Location = new System.Drawing.Point(54, 26);
            this.labelControlUsers.Name = "labelControlUsers";
            this.labelControlUsers.Size = new System.Drawing.Size(31, 13);
            this.labelControlUsers.TabIndex = 24;
            this.labelControlUsers.Text = "Users:";
            // 
            // labelControlNumberOfUsers
            // 
            this.labelControlNumberOfUsers.Location = new System.Drawing.Point(179, 26);
            this.labelControlNumberOfUsers.Name = "labelControlNumberOfUsers";
            this.labelControlNumberOfUsers.Size = new System.Drawing.Size(76, 13);
            this.labelControlNumberOfUsers.TabIndex = 25;
            this.labelControlNumberOfUsers.Text = "NumberOfUsers";
            // 
            // labelControlNumberOfUserGroups
            // 
            this.labelControlNumberOfUserGroups.Location = new System.Drawing.Point(179, 45);
            this.labelControlNumberOfUserGroups.Name = "labelControlNumberOfUserGroups";
            this.labelControlNumberOfUserGroups.Size = new System.Drawing.Size(105, 13);
            this.labelControlNumberOfUserGroups.TabIndex = 27;
            this.labelControlNumberOfUserGroups.Text = "NumberOfUserGroups";
            // 
            // labelControlUserGroups
            // 
            this.labelControlUserGroups.Location = new System.Drawing.Point(54, 45);
            this.labelControlUserGroups.Name = "labelControlUserGroups";
            this.labelControlUserGroups.Size = new System.Drawing.Size(63, 13);
            this.labelControlUserGroups.TabIndex = 26;
            this.labelControlUserGroups.Text = "User Groups:";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonOK);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 93);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(279, 38);
            this.panelFooter.TabIndex = 30;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(174, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(93, 26);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 131);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.labelControlNumberOfUserGroups);
            this.Controls.Add(this.labelControlUserGroups);
            this.Controls.Add(this.labelControlNumberOfUsers);
            this.Controls.Add(this.labelControlUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl labelControlUsers;
        protected DevExpress.XtraEditors.LabelControl labelControlNumberOfUsers;
        protected DevExpress.XtraEditors.LabelControl labelControlNumberOfUserGroups;
        protected DevExpress.XtraEditors.LabelControl labelControlUserGroups;
        private DevExpress.XtraEditors.PanelControl panelFooter;
        private DevExpress.XtraEditors.SimpleButton buttonOK;
    }
}