namespace DemoApp
{
    partial class EditPanelUserGroup
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
			imageList = new System.Windows.Forms.ImageList(components);
			imageListCheckBox = new System.Windows.Forms.ImageList(components);
			tabPageUserMembers = new DevExpress.XtraTab.XtraTabPage();
			treeListUserMembers = new Simple.Controls.TreeList.SimpleTreeList();
			graphControllerAdministratorMembers = new GraphController();
			tabPageDescription.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)editorDescription.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)groupControlGeneral).BeginInit();
			groupControlGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)editorName.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)tabControl).BeginInit();
			tabControl.SuspendLayout();
			tabPageObjectName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			tabPageUserMembers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)treeListUserMembers).BeginInit();
			SuspendLayout();
			// 
			// editorDescription
			// 
			errorProvider.SetError(editorDescription, "OK");
			errorProvider.SetErrorType(editorDescription, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
			errorProvider.SetIconAlignment(editorDescription, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			editorDescription.Size = new System.Drawing.Size(486, 630);
			// 
			// editorName
			// 
			errorProvider.SetError(editorName, "OK");
			errorProvider.SetErrorType(editorName, DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
			errorProvider.SetIconAlignment(editorName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
			// 
			// tabControl
			// 
			tabControl.SelectedTabPage = tabPageObjectName;
			tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabPageUserMembers });
			tabControl.Controls.SetChildIndex(tabPageUserMembers, 0);
			tabControl.Controls.SetChildIndex(tabPageDescription, 0);
			tabControl.Controls.SetChildIndex(tabPageObjectName, 0);
			// 
			// tabPageObjectName
			// 
			tabPageObjectName.Text = "User Group";
			// 
			// imageList
			// 
			imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			imageList.ImageSize = new System.Drawing.Size(16, 16);
			imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageListCheckBox
			// 
			imageListCheckBox.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			imageListCheckBox.ImageSize = new System.Drawing.Size(16, 16);
			imageListCheckBox.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tabPageUserMembers
			// 
			tabPageUserMembers.Controls.Add(treeListUserMembers);
			tabPageUserMembers.Name = "tabPageUserMembers";
			tabPageUserMembers.Size = new System.Drawing.Size(488, 637);
			tabPageUserMembers.Text = "User Members";
			// 
			// treeListUserMembers
			// 
			treeListUserMembers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			treeListUserMembers.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
			treeListUserMembers.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.ControlText;
			treeListUserMembers.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.ControlText;
			treeListUserMembers.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
			treeListUserMembers.Appearance.SelectedRow.Options.UseForeColor = true;
			treeListUserMembers.CheckBoxImageList = imageListCheckBox;
			treeListUserMembers.CustomCheckBoxDraw = true;
			treeListUserMembers.CustomNodeImagesDraw = true;
			treeListUserMembers.Location = new System.Drawing.Point(3, 4);
			treeListUserMembers.Name = "treeListUserMembers";
			treeListUserMembers.OptionsBehavior.Editable = false;
			treeListUserMembers.OptionsDragAndDrop.DropNodesMode = DevExpress.XtraTreeList.DropNodesMode.Advanced;
			treeListUserMembers.OptionsSelection.EnableAppearanceFocusedCell = false;
			treeListUserMembers.OptionsSelection.EnableAppearanceFocusedRow = false;
			treeListUserMembers.OptionsSimple.EditMode = Simple.Controls.TreeList.SimpleTreeEditMode.ViewOnly;
			treeListUserMembers.OptionsSimple.LookAndFeelStyle = Simple.Controls.TreeList.SimpleTreeLookAndFeelStyle.ExplorerStyle;
			treeListUserMembers.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
			treeListUserMembers.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
			treeListUserMembers.OptionsView.ShowHorzLines = false;
			treeListUserMembers.OptionsView.ShowIndicator = false;
			treeListUserMembers.OptionsView.ShowVertLines = false;
			treeListUserMembers.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
			treeListUserMembers.SelectImageList = imageList;
			treeListUserMembers.Size = new System.Drawing.Size(482, 630);
			treeListUserMembers.TabIndex = 1;
			// 
			// graphControllerAdministratorMembers
			// 
			graphControllerAdministratorMembers.ChangableBindingObjectControl = this;
			graphControllerAdministratorMembers.CheckBoxImageList = imageListCheckBox;
			graphControllerAdministratorMembers.EditMode = Simple.Objects.Controls.GraphEditMode.ViewOnly;
			graphControllerAdministratorMembers.GraphKey = Objects.GraphKey.Users;
			graphControllerAdministratorMembers.ImageList = imageList;
			graphControllerAdministratorMembers.IsActive = true;
			graphControllerAdministratorMembers.LoadAllNodes = true;
			graphControllerAdministratorMembers.ManyToManyRelationKey = Objects.ManyToManyRelationKey.UserToUserGroup;
			graphControllerAdministratorMembers.TreeList = treeListUserMembers;
			// 
			// EditPanelUserGroup
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Name = "EditPanelUserGroup";
			tabPageDescription.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)editorDescription.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)groupControlGeneral).EndInit();
			groupControlGeneral.ResumeLayout(false);
			groupControlGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)editorName.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)tabControl).EndInit();
			tabControl.ResumeLayout(false);
			tabPageObjectName.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			tabPageUserMembers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)treeListUserMembers).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraTab.XtraTabPage tabPageUserMembers;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ImageList imageListCheckBox;
        private Simple.Controls.TreeList.SimpleTreeList treeListUserMembers;
        private GraphController graphControllerAdministratorMembers;
    }
}
