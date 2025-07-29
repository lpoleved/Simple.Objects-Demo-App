namespace DemoApp
{
    partial class EditPanelUser
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			labelPassword = new DevExpress.XtraEditors.LabelControl();
			editorPassword = new DevExpress.XtraEditors.TextEdit();
			labelUsername = new DevExpress.XtraEditors.LabelControl();
			editorUsername = new DevExpress.XtraEditors.TextEdit();
			labelLastName = new DevExpress.XtraEditors.LabelControl();
			editorLastName = new DevExpress.XtraEditors.TextEdit();
			tabPageUserGroupMembership = new DevExpress.XtraTab.XtraTabPage();
			treeListAdministratorGroupMembership = new Simple.Controls.TreeList.SimpleTreeList();
			imageListCheckBox = new System.Windows.Forms.ImageList(components);
			imageList = new System.Windows.Forms.ImageList(components);
			graphControllerAdministratorGroupMembership = new GraphController();
			editorLocation = new DevExpress.XtraEditors.TextEdit();
			labelLocation = new DevExpress.XtraEditors.LabelControl();
			checkEditAccountIsDisabled = new DevExpress.XtraEditors.CheckEdit();
			labelControlFirstName = new DevExpress.XtraEditors.LabelControl();
			editorFirstName = new DevExpress.XtraEditors.TextEdit();
			labelControlNextId = new DevExpress.XtraEditors.LabelControl();
			editorNextId = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)groupControlGeneral).BeginInit();
			groupControlGeneral.SuspendLayout();
			tabPageDescription.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)editorDescription.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)tabControl).BeginInit();
			tabControl.SuspendLayout();
			tabPageObjectName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			((System.ComponentModel.ISupportInitialize)editorPassword.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)editorUsername.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)editorLastName.Properties).BeginInit();
			tabPageUserGroupMembership.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)treeListAdministratorGroupMembership).BeginInit();
			((System.ComponentModel.ISupportInitialize)editorLocation.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)checkEditAccountIsDisabled.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)editorFirstName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)editorNextId.Properties).BeginInit();
			SuspendLayout();
			// 
			// groupControlGeneral
			// 
			groupControlGeneral.Controls.Add(editorNextId);
			groupControlGeneral.Controls.Add(labelControlNextId);
			groupControlGeneral.Controls.Add(labelControlFirstName);
			groupControlGeneral.Controls.Add(editorFirstName);
			groupControlGeneral.Controls.Add(checkEditAccountIsDisabled);
			groupControlGeneral.Controls.Add(labelLocation);
			groupControlGeneral.Controls.Add(editorLocation);
			groupControlGeneral.Controls.Add(labelPassword);
			groupControlGeneral.Controls.Add(editorPassword);
			groupControlGeneral.Controls.Add(labelUsername);
			groupControlGeneral.Controls.Add(editorUsername);
			groupControlGeneral.Controls.Add(labelLastName);
			groupControlGeneral.Controls.Add(editorLastName);
			// 
			// editorDescription
			// 
			errorProvider.SetError(editorDescription, "OK");
			errorProvider.SetErrorType(editorDescription, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
			errorProvider.SetIconAlignment(editorDescription, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			editorDescription.Size = new System.Drawing.Size(482, 630);
			// 
			// tabControl
			// 
			tabControl.SelectedTabPage = tabPageObjectName;
			tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabPageUserGroupMembership });
			tabControl.Controls.SetChildIndex(tabPageUserGroupMembership, 0);
			tabControl.Controls.SetChildIndex(tabPageDescription, 0);
			tabControl.Controls.SetChildIndex(tabPageObjectName, 0);
			// 
			// tabPageObjectName
			// 
			tabPageObjectName.Text = "User";
			// 
			// labelPassword
			// 
			labelPassword.Location = new System.Drawing.Point(16, 124);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new System.Drawing.Size(50, 13);
			labelPassword.TabIndex = 16;
			labelPassword.Text = "Password:";
			// 
			// editorPassword
			// 
			editorPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			editorPassword.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			editorPassword.Location = new System.Drawing.Point(77, 121);
			editorPassword.Name = "editorPassword";
			editorPassword.Properties.PasswordChar = '*';
			editorPassword.Size = new System.Drawing.Size(387, 20);
			editorPassword.TabIndex = 17;
			editorPassword.EditValueChanging += editorPassword_EditValueChanging;
			// 
			// labelUsername
			// 
			labelUsername.Location = new System.Drawing.Point(16, 98);
			labelUsername.Name = "labelUsername";
			labelUsername.Size = new System.Drawing.Size(52, 13);
			labelUsername.TabIndex = 14;
			labelUsername.Text = "Username:";
			// 
			// editorUsername
			// 
			editorUsername.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			errorProvider.SetError(editorUsername, "OK");
			errorProvider.SetErrorType(editorUsername, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
			errorProvider.SetIconAlignment(editorUsername, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			editorUsername.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			editorUsername.Location = new System.Drawing.Point(77, 95);
			editorUsername.Name = "editorUsername";
			editorUsername.Size = new System.Drawing.Size(387, 20);
			editorUsername.TabIndex = 15;
			// 
			// labelLastName
			// 
			labelLastName.Location = new System.Drawing.Point(16, 63);
			labelLastName.Name = "labelLastName";
			labelLastName.Size = new System.Drawing.Size(54, 13);
			labelLastName.TabIndex = 12;
			labelLastName.Text = "Last Name:";
			// 
			// editorLastName
			// 
			editorLastName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			errorProvider.SetError(editorLastName, "OK");
			errorProvider.SetErrorType(editorLastName, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
			errorProvider.SetIconAlignment(editorLastName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			editorLastName.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			editorLastName.Location = new System.Drawing.Point(77, 60);
			editorLastName.Name = "editorLastName";
			editorLastName.Size = new System.Drawing.Size(387, 20);
			editorLastName.TabIndex = 13;
			// 
			// tabPageUserGroupMembership
			// 
			tabPageUserGroupMembership.Controls.Add(treeListAdministratorGroupMembership);
			tabPageUserGroupMembership.Name = "tabPageUserGroupMembership";
			tabPageUserGroupMembership.Size = new System.Drawing.Size(488, 637);
			tabPageUserGroupMembership.Text = "User Group Membership";
			// 
			// treeListAdministratorGroupMembership
			// 
			treeListAdministratorGroupMembership.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			treeListAdministratorGroupMembership.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
			treeListAdministratorGroupMembership.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText;
			treeListAdministratorGroupMembership.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText;
			treeListAdministratorGroupMembership.Appearance.FocusedRow.Options.UseBackColor = true;
			treeListAdministratorGroupMembership.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
			treeListAdministratorGroupMembership.Appearance.HideSelectionRow.Options.UseBackColor = true;
			treeListAdministratorGroupMembership.Appearance.SelectedRow.Options.UseForeColor = true;
			treeListAdministratorGroupMembership.CheckBoxImageList = imageListCheckBox;
			treeListAdministratorGroupMembership.CustomCheckBoxDraw = true;
			treeListAdministratorGroupMembership.CustomNodeImagesDraw = true;
			treeListAdministratorGroupMembership.Location = new System.Drawing.Point(3, 4);
			treeListAdministratorGroupMembership.Name = "treeListAdministratorGroupMembership";
			treeListAdministratorGroupMembership.OptionsBehavior.Editable = false;
			treeListAdministratorGroupMembership.OptionsDragAndDrop.DropNodesMode = DevExpress.XtraTreeList.DropNodesMode.Advanced;
			treeListAdministratorGroupMembership.OptionsSelection.EnableAppearanceFocusedCell = false;
			treeListAdministratorGroupMembership.OptionsSelection.EnableAppearanceFocusedRow = false;
			treeListAdministratorGroupMembership.OptionsSimple.EditMode = Simple.Controls.TreeList.SimpleTreeEditMode.ViewOnly;
			treeListAdministratorGroupMembership.OptionsSimple.LookAndFeelStyle = Simple.Controls.TreeList.SimpleTreeLookAndFeelStyle.ExplorerStyle;
			treeListAdministratorGroupMembership.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
			treeListAdministratorGroupMembership.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
			treeListAdministratorGroupMembership.OptionsView.ShowHorzLines = false;
			treeListAdministratorGroupMembership.OptionsView.ShowIndicator = false;
			treeListAdministratorGroupMembership.OptionsView.ShowVertLines = false;
			treeListAdministratorGroupMembership.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
			treeListAdministratorGroupMembership.SelectImageList = imageList;
			treeListAdministratorGroupMembership.Size = new System.Drawing.Size(482, 630);
			treeListAdministratorGroupMembership.TabIndex = 1;
			// 
			// imageListCheckBox
			// 
			imageListCheckBox.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			imageListCheckBox.ImageSize = new System.Drawing.Size(16, 16);
			imageListCheckBox.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList
			// 
			imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			imageList.ImageSize = new System.Drawing.Size(16, 16);
			imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// graphControllerAdministratorGroupMembership
			// 
			graphControllerAdministratorGroupMembership.ChangableBindingObjectControl = this;
			graphControllerAdministratorGroupMembership.CheckBoxImageList = imageListCheckBox;
			graphControllerAdministratorGroupMembership.EditMode = Simple.Objects.Controls.GraphEditMode.ViewOnly;
			graphControllerAdministratorGroupMembership.GraphKey = Objects.GraphKey.UserGroups;
			graphControllerAdministratorGroupMembership.ImageList = imageList;
			graphControllerAdministratorGroupMembership.IsActive = true;
			graphControllerAdministratorGroupMembership.LoadAllNodes = true;
			graphControllerAdministratorGroupMembership.ManyToManyRelationKey = Objects.ManyToManyRelationKey.UserToUserGroup;
			graphControllerAdministratorGroupMembership.TreeList = treeListAdministratorGroupMembership;
			// 
			// editorLocation
			// 
			editorLocation.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			errorProvider.SetError(editorLocation, "OK");
			errorProvider.SetErrorType(editorLocation, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
			errorProvider.SetIconAlignment(editorLocation, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			editorLocation.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			editorLocation.Location = new System.Drawing.Point(77, 147);
			editorLocation.Name = "editorLocation";
			editorLocation.Size = new System.Drawing.Size(387, 20);
			editorLocation.TabIndex = 18;
			// 
			// labelLocation
			// 
			labelLocation.Location = new System.Drawing.Point(16, 150);
			labelLocation.Name = "labelLocation";
			labelLocation.Size = new System.Drawing.Size(44, 13);
			labelLocation.TabIndex = 19;
			labelLocation.Text = "Location:";
			// 
			// checkEditAccountIsDisabled
			// 
			errorProvider.SetIconAlignment(checkEditAccountIsDisabled, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			checkEditAccountIsDisabled.Location = new System.Drawing.Point(77, 184);
			checkEditAccountIsDisabled.Name = "checkEditAccountIsDisabled";
			checkEditAccountIsDisabled.Properties.AutoWidth = true;
			checkEditAccountIsDisabled.Properties.Caption = "Account is disabled";
			checkEditAccountIsDisabled.Size = new System.Drawing.Size(114, 20);
			checkEditAccountIsDisabled.TabIndex = 53;
			// 
			// labelControlFirstName
			// 
			labelControlFirstName.Location = new System.Drawing.Point(16, 37);
			labelControlFirstName.Name = "labelControlFirstName";
			labelControlFirstName.Size = new System.Drawing.Size(55, 13);
			labelControlFirstName.TabIndex = 54;
			labelControlFirstName.Text = "First Name:";
			// 
			// editorFirstName
			// 
			editorFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			errorProvider.SetError(editorFirstName, "OK");
			errorProvider.SetErrorType(editorFirstName, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
			errorProvider.SetIconAlignment(editorFirstName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			editorFirstName.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			editorFirstName.Location = new System.Drawing.Point(77, 34);
			editorFirstName.Name = "editorFirstName";
			editorFirstName.Size = new System.Drawing.Size(387, 20);
			editorFirstName.TabIndex = 55;
			// 
			// labelControlNextId
			// 
			labelControlNextId.Location = new System.Drawing.Point(22, 229);
			labelControlNextId.Name = "labelControlNextId";
			labelControlNextId.Size = new System.Drawing.Size(37, 13);
			labelControlNextId.TabIndex = 57;
			labelControlNextId.Text = "NextId:";
			// 
			// editorNextId
			// 
			editorNextId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			editorNextId.Enabled = false;
			errorProvider.SetError(editorNextId, "OK");
			errorProvider.SetErrorType(editorNextId, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
			errorProvider.SetIconAlignment(editorNextId, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			editorNextId.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			editorNextId.Location = new System.Drawing.Point(77, 226);
			editorNextId.Name = "editorNextId";
			editorNextId.Size = new System.Drawing.Size(387, 20);
			editorNextId.TabIndex = 58;
			// 
			// EditPanelUser
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Name = "EditPanelUser";
			((System.ComponentModel.ISupportInitialize)groupControlGeneral).EndInit();
			groupControlGeneral.ResumeLayout(false);
			groupControlGeneral.PerformLayout();
			tabPageDescription.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)editorDescription.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)tabControl).EndInit();
			tabControl.ResumeLayout(false);
			tabPageObjectName.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			((System.ComponentModel.ISupportInitialize)editorPassword.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)editorUsername.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)editorLastName.Properties).EndInit();
			tabPageUserGroupMembership.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)treeListAdministratorGroupMembership).EndInit();
			((System.ComponentModel.ISupportInitialize)editorLocation.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)checkEditAccountIsDisabled.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)editorFirstName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)editorNextId.Properties).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelPassword;
        private DevExpress.XtraEditors.TextEdit editorPassword;
        private DevExpress.XtraEditors.LabelControl labelUsername;
        private DevExpress.XtraEditors.TextEdit editorUsername;
        private DevExpress.XtraEditors.LabelControl labelLastName;
        private DevExpress.XtraEditors.TextEdit editorLastName;
        private DevExpress.XtraTab.XtraTabPage tabPageUserGroupMembership;
        private Simple.Controls.TreeList.SimpleTreeList treeListAdministratorGroupMembership;
        private System.Windows.Forms.ImageList imageListCheckBox;
        private System.Windows.Forms.ImageList imageList;
        private GraphController graphControllerAdministratorGroupMembership;
		private DevExpress.XtraEditors.LabelControl labelLocation;
		private DevExpress.XtraEditors.TextEdit editorLocation;
		protected DevExpress.XtraEditors.CheckEdit checkEditAccountIsDisabled;
		private DevExpress.XtraEditors.LabelControl labelControlFirstName;
		private DevExpress.XtraEditors.TextEdit editorFirstName;
		private DevExpress.XtraEditors.LabelControl labelControlNextId;
		private DevExpress.XtraEditors.TextEdit editorNextId;
	}
}
