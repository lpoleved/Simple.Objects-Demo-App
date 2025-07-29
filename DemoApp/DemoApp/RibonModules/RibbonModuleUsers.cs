using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Simple.Objects;
using Simple.Controls;
using Simple.Controls.TreeList;
using Simple.Objects.Controls;
using DemoApp.Objects;

namespace DemoApp
{
    [ToolboxItem(false)]
    public partial class RibbonModuleUsers : RibbonModuleSplitPanelTemplate
    {
		private int columnFirstNameIndex, columnLastNameIndex, columnUsernameIndex, columnLocationIndex, columnDescriptionIndex;
		
		public RibbonModuleUsers()
        {
            InitializeComponent();
        }
		
		protected override void OnStart()
        {
            base.OnStart();

            this.columnFirstNameIndex	= this.graphController.Columns.Add(new GraphColumn(UserModel.PropertyModel.FirstName.PropertyName, "Name / First Name"));
			this.columnLastNameIndex	= this.graphController.Columns.Add(new GraphColumn(UserModel.PropertyModel.LastName.PropertyName,  "Last Name"));
			this.columnUsernameIndex	= this.graphController.Columns.Add(new GraphColumn(UserModel.PropertyModel.Username.PropertyName));
			this.columnLocationIndex	= this.graphController.Columns.Add(new GraphColumn(UserModel.PropertyModel.Location.PropertyName));
			this.columnDescriptionIndex = this.graphController.Columns.Add(new GraphColumn(UserModel.PropertyModel.Description.PropertyName));

			this.graphController.SetGraphColumnBindingPolicy(this.columnFirstNameIndex, Simple.Objects.FolderModel.PropertyModel.Name);
			this.graphController.SetAddButtonPolicy(typeof(User), this.barButtonItemAddUser, this.barButtonItemAddUserPopup);
			this.graphController.AfterSetColumnsEnableProperty += GraphController_AfterSetGraphColumnsEnableProperty;
			this.graphController.AfterSetButtonsEnableProperty += GraphController_AfterSetButtonsEnableProperty;


			this.graphController.Bind();
            this.graphController.BestFitGraphColumns();

            this.ControlsToValidate.Add(this.graphController);

            //this.treeList.Focus();
        }

		private void GraphController_AfterSetGraphColumnsEnableProperty(object sender, Simple.Objects.GraphElementEventArgs e)
		{
			if (this.graphController != null && e.GraphElement?.SimpleObject.Id == 1) // System Admin is not editable, exept password and description fields
			{
				this.graphController.Columns[this.columnFirstNameIndex]!.Enabled = false;
				this.graphController.Columns[this.columnLastNameIndex]!.Enabled = false;
				this.graphController.Columns[this.columnUsernameIndex]!.Enabled = false;
			}
		}

		private void GraphController_AfterSetButtonsEnableProperty(object? sender, EventArgs e)
		{
			if (this.graphController.FocusedSimpleObject is User user && (user.Id == 1)) // System Admin is not editable, exept password and description fields
				this.barButtonItemRemove.Enabled = false;
		}

		protected override void OnSetIsActive()
		{
			base.OnSetIsActive();
			this.graphController.IsActive = this.IsActive;
			this.treeList.Visible = this.IsActive;
			this.simpleGroupEditPanel.Visible = this.IsActive;
		}		

		protected override void OnModuleSelected()
        {
            // Refresh context for group membership and other dependencies
            this.simpleGroupEditPanel.RefreshContext();
        }

		private void barButtonItemFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (!this.graphController.ValidateAndTrySaveNodeIfRequired())
				return;

			if (this.GraphController != null)
				this.ShowFormFind(this.GraphController); 
		}

		private void barButtonItemExpandAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.GraphExpandAll(this.graphController);
		}

		private void barButtonItemCollapseAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.GraphCollapseAll(this.graphController);
		}

		private void barButtonItemPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.ShowRibbonPrintPreview(this.treeList);
		}

		private void barButtonItemPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.PrintTreeList(this.treeList);
		}
    }
}
