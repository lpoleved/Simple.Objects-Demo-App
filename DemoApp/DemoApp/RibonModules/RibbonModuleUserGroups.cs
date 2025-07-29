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
    public partial class RibbonModuleUserGroups : RibbonModuleSplitPanelTemplate
    {
		int columnNameIndex, columnDescriptionIndex;

		public RibbonModuleUserGroups()
        {
            InitializeComponent();
        }

		protected override void OnStart()
        {
            base.OnStart();

            this.columnNameIndex = this.graphController.Columns.Add(new GraphColumn(UserGroupModel.PropertyModel.Name.PropertyName));
            this.columnDescriptionIndex = this.graphController.Columns.Add(new GraphColumn(UserGroupModel.PropertyModel.Description.PropertyName));

			this.graphController.SetAddButtonPolicy(typeof(UserGroup), this.barButtonItemAddUserGroup, this.barButtonItemAddUserGroupPopup);
			this.graphController.AfterSetColumnsEnableProperty += GraphController_AfterSetColumnsEnableProperty;

            this.graphController.Bind();
            this.graphController.BestFitGraphColumns();

            this.ControlsToValidate.Add(this.graphController);

            //this.treeList.Focus();
        }

		private void GraphController_AfterSetColumnsEnableProperty(object sender, GraphElementEventArgs e)
		{
			if (e.GraphElement.SimpleObject.Id == 1) // Administrators are predefined and not editable
				this.graphController.Columns[this.columnNameIndex].Enabled = false;
		}

		protected override void OnSetIsActive()
		{
			base.OnSetIsActive();
			this.graphController.IsActive = this.IsActive;
			this.treeList.Visible = this.IsActive;
			this.simpleGroupEditPanel.Visible = this.IsActive;
		}		

        //private void barButtonItemApplyPolicy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    base.barButtonItemApplyPolicy_ItemClick

        //    if (this.graphController.ValidateAndTrySaveNodeIfRequired())
        //    {
        //        FormApplyPolicy formApplyPolicy = new FormApplyPolicy();
        //        formApplyPolicy.ApplyPolicy();
        //    }
        //}

        protected override void OnModuleSelected()
        {
            // Refresh context for group membership and other dependecies
            this.simpleGroupEditPanel.RefreshContext();
        }

        private void barButtonItemFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (!this.graphController.ValidateAndTrySaveNodeIfRequired())
				return;

			this.ShowFormFind(this.GraphController); 
		}

		private void barButtonItemExpandAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.GraphExpandAll(this.graphController);
		}

		private void barButtonItemCollapseAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.GraphExpandAll(this.graphController);
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
