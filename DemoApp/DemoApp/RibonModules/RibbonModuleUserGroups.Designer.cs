namespace DemoApp
{
	partial class RibbonModuleUserGroups
    {
		static RibbonModuleUserGroups()
		{
		}
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
			this.components = new System.ComponentModel.Container();
			this.ribbonPageGroupAdd = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barButtonItemAddFolder = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddSubFolder = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddUserGroup = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPageGroupElement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barButtonItemMoveUp = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemMoveDown = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemRemove = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemRejectChanges = new DevExpress.XtraBars.BarButtonItem();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.barButtonItemAddFolderPopup = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddSubFolderPopup = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddUserGroupPopup = new DevExpress.XtraBars.BarButtonItem();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.barButtonItemRemoveColumnSorting = new DevExpress.XtraBars.BarButtonItem();
			this.treeList = new Simple.Controls.TreeList.SimpleTreeList();
			this.simpleGroupEditPanel = new Simple.Objects.Controls.SimpleObjectGroupEditPanel();
			this.barButtonItemPrintPreview = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPageGroupGraphTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barButtonItemExpandAll = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemCollapseAll = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemFind = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemPrint = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPageGroupPrinting = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel1)).BeginInit();
			this.splitContainerMain.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel2)).BeginInit();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tempRibbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
			this.SuspendLayout();
			// 
			// graphController
			// 
			this.graphController.ButtonAddFolder = this.barButtonItemAddFolder;
			this.graphController.ButtonAddFolderPopup = this.barButtonItemAddFolderPopup;
			this.graphController.ButtonAddSubFolder = this.barButtonItemAddSubFolder;
			this.graphController.ButtonAddSubFolderPopup = this.barButtonItemAddSubFolderPopup;
			this.graphController.ButtonMoveDown = this.barButtonItemMoveDown;
			this.graphController.ButtonMoveUp = this.barButtonItemMoveUp;
			this.graphController.ButtonRejectChanges = this.barButtonItemRejectChanges;
			this.graphController.ButtonRemove = this.barButtonItemRemove;
			this.graphController.ButtonRemoveColumnSorting = this.barButtonItemRemoveColumnSorting;
			this.graphController.ButtonSave = this.barButtonItemSave;
			this.graphController.CanDragAndDrop = true;
			this.graphController.GraphKey = DemoApp.Objects.GraphKey.UserGroups;
			this.graphController.ImageList = this.imageList;
			this.graphController.ManyToManyRelationKey = DemoApp.Objects.ManyToManyRelationKey.Empty;
			this.graphController.PopupMenu = this.popupMenu;
			this.graphController.RibbonModulePanel = this;
			this.graphController.TreeList = this.treeList;
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Location = new System.Drawing.Point(0, 144);
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.treeList);
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.simpleGroupEditPanel);
			this.splitContainerMain.Size = new System.Drawing.Size(1081, 456);
			this.splitContainerMain.SplitterPosition = 637;
			// 
			// tempRibbonControl
			// 
			this.tempRibbonControl.ExpandCollapseItem.Id = 0;
			this.tempRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAddFolder,
            this.barButtonItemAddSubFolder,
            this.barButtonItemAddUserGroup,
            this.barButtonItemRemove,
            this.barButtonItemSave,
            this.barButtonItemAddFolderPopup,
            this.barButtonItemAddSubFolderPopup,
            this.barButtonItemAddUserGroupPopup,
            this.barButtonItemPrintPreview,
            this.barButtonItemFind,
            this.barButtonItemExpandAll,
            this.barButtonItemCollapseAll,
            this.barButtonItemPrint,
            this.barButtonItemMoveUp,
            this.barButtonItemMoveDown,
            this.barButtonItemRemoveColumnSorting,
            this.barButtonItemRejectChanges});
			this.tempRibbonControl.MaxItemId = 18;
			// 
			// 
			// 
			this.tempRibbonControl.SearchEditItem.AccessibleName = "Search Item";
			this.tempRibbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
			this.tempRibbonControl.SearchEditItem.EditWidth = 150;
			this.tempRibbonControl.SearchEditItem.Id = -5000;
			this.tempRibbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.tempRibbonControl.Size = new System.Drawing.Size(1081, 144);
			// 
			// ribbonPage
			// 
			this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAdd,
            this.ribbonPageGroupElement,
            this.ribbonPageGroupGraphTools,
            this.ribbonPageGroupPrinting});
			this.ribbonPage.Text = "User Groups";
			// 
			// ribbonPageGroupInsert
			// 
			this.ribbonPageGroupAdd.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroupAdd.ItemLinks.Add(this.barButtonItemAddFolder);
			this.ribbonPageGroupAdd.ItemLinks.Add(this.barButtonItemAddSubFolder);
			this.ribbonPageGroupAdd.ItemLinks.Add(this.barButtonItemAddUserGroup, true);
			this.ribbonPageGroupAdd.Name = "ribbonPageGroupInsert";
			this.ribbonPageGroupAdd.Text = "Add";
			// 
			// barButtonItemAddFolder
			// 
			this.barButtonItemAddFolder.Caption = "Folder";
			this.barButtonItemAddFolder.Hint = "Add";
			this.barButtonItemAddFolder.Id = 0;
			this.barButtonItemAddFolder.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Folder_Add;
			this.barButtonItemAddFolder.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Folder_Add_Large;
			this.barButtonItemAddFolder.Name = "barButtonItemAddFolder";
			// 
			// barButtonItemAddSubFolder
			// 
			this.barButtonItemAddSubFolder.Caption = "Sub Folder";
			this.barButtonItemAddSubFolder.Hint = "Add";
			this.barButtonItemAddSubFolder.Id = 1;
			this.barButtonItemAddSubFolder.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.SubFolder_Add;
			this.barButtonItemAddSubFolder.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.SubFolder_Add_Large;
			this.barButtonItemAddSubFolder.Name = "barButtonItemAddSubFolder";
			// 
			// barButtonItemAddUserGroup
			// 
			this.barButtonItemAddUserGroup.Caption = "User Group";
			this.barButtonItemAddUserGroup.Hint = "Add";
			this.barButtonItemAddUserGroup.Id = 2;
			this.barButtonItemAddUserGroup.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.AdministratorGroup_Add;
			this.barButtonItemAddUserGroup.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.AdministratorGroup_Add_Large;
			this.barButtonItemAddUserGroup.Name = "barButtonItemAddUserGroup";
			// 
			// ribbonPageGroupElement
			// 
			this.ribbonPageGroupElement.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroupElement.ItemLinks.Add(this.barButtonItemMoveUp);
			this.ribbonPageGroupElement.ItemLinks.Add(this.barButtonItemMoveDown);
			this.ribbonPageGroupElement.ItemLinks.Add(this.barButtonItemSave, true);
			this.ribbonPageGroupElement.ItemLinks.Add(this.barButtonItemRemove);
			this.ribbonPageGroupElement.Name = "ribbonPageGroupElement";
			this.ribbonPageGroupElement.Text = "Element";
			// 
			// barButtonItemMoveUp
			// 
			this.barButtonItemMoveUp.Caption = "Move Up";
			this.barButtonItemMoveUp.Id = 14;
			this.barButtonItemMoveUp.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.MoveUp;
			this.barButtonItemMoveUp.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.MoveUp_Large;
			this.barButtonItemMoveUp.Name = "barButtonItemMoveUp";
			// 
			// barButtonItemMoveDown
			// 
			this.barButtonItemMoveDown.Caption = "Move Down";
			this.barButtonItemMoveDown.Id = 15;
			this.barButtonItemMoveDown.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.MoveDown;
			this.barButtonItemMoveDown.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.MoveDown_Large;
			this.barButtonItemMoveDown.Name = "barButtonItemMoveDown";
			// 
			// barButtonItemSave
			// 
			this.barButtonItemSave.Caption = "Save";
			this.barButtonItemSave.Hint = "Save";
			this.barButtonItemSave.Id = 4;
			this.barButtonItemSave.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.SaveButton;
			this.barButtonItemSave.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.SaveButton_Large;
			this.barButtonItemSave.Name = "barButtonItemSave";
			// 
			// barButtonItemRemove
			// 
			this.barButtonItemRemove.Caption = "Remove";
			this.barButtonItemRemove.Hint = "Remove";
			this.barButtonItemRemove.Id = 3;
			this.barButtonItemRemove.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Remove;
			this.barButtonItemRemove.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Remove_Large;
			this.barButtonItemRemove.Name = "barButtonItemRemove";
			// 
			// barButtonItemRejectChanges
			// 
			this.barButtonItemRejectChanges.Caption = "Reject Changes";
			this.barButtonItemRejectChanges.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
			this.barButtonItemRejectChanges.Id = 17;
			this.barButtonItemRejectChanges.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.RejectChanges;
			this.barButtonItemRejectChanges.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.RejectChanges_Large;
			this.barButtonItemRejectChanges.Name = "barButtonItemRejectChanges";
			// 
			// popupMenu
			// 
			this.popupMenu.ItemLinks.Add(this.barButtonItemAddFolderPopup);
			this.popupMenu.ItemLinks.Add(this.barButtonItemAddSubFolderPopup);
			this.popupMenu.ItemLinks.Add(this.barButtonItemAddUserGroupPopup, true);
			this.popupMenu.ItemLinks.Add(this.barButtonItemRemove, true);
			this.popupMenu.MenuCaption = "Administrator Groups";
			this.popupMenu.Name = "popupMenu";
			this.popupMenu.Ribbon = this.tempRibbonControl;
			this.popupMenu.ShowCaption = true;
			// 
			// barButtonItemAddFolderPopup
			// 
			this.barButtonItemAddFolderPopup.Caption = "Add Folder";
			this.barButtonItemAddFolderPopup.Id = 5;
			this.barButtonItemAddFolderPopup.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Folder_Add;
			this.barButtonItemAddFolderPopup.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Folder_Add_Large;
			this.barButtonItemAddFolderPopup.Name = "barButtonItemAddFolderPopup";
			// 
			// barButtonItemAddSubFolderPopup
			// 
			this.barButtonItemAddSubFolderPopup.Caption = "Add Sub Folder";
			this.barButtonItemAddSubFolderPopup.Id = 6;
			this.barButtonItemAddSubFolderPopup.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.SubFolder_Add;
			this.barButtonItemAddSubFolderPopup.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.SubFolder_Add_Large;
			this.barButtonItemAddSubFolderPopup.Name = "barButtonItemAddSubFolderPopup";
			// 
			// barButtonItemAddUserGroupPopup
			// 
			this.barButtonItemAddUserGroupPopup.Caption = "Add Administrator Group";
			this.barButtonItemAddUserGroupPopup.Id = 7;
			this.barButtonItemAddUserGroupPopup.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.AdministratorGroup_Add;
			this.barButtonItemAddUserGroupPopup.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.AdministratorGroup_Add_Large;
			this.barButtonItemAddUserGroupPopup.Name = "barButtonItemAddUserGroupPopup";
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// barButtonItemRemoveColumnSorting
			// 
			this.barButtonItemRemoveColumnSorting.Caption = "Remove Column Sorting";
			this.barButtonItemRemoveColumnSorting.Id = 16;
			this.barButtonItemRemoveColumnSorting.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.RemoveSorting;
			this.barButtonItemRemoveColumnSorting.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.RemoveSorting_Large;
			this.barButtonItemRemoveColumnSorting.Name = "barButtonItemRemoveColumnSorting";
			// 
			// treeList
			// 
			this.treeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.treeList.Appearance.FocusedCell.Options.UseBackColor = true;
			this.treeList.Appearance.FocusedCell.Options.UseForeColor = true;
			this.treeList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.treeList.Appearance.FocusedRow.Options.UseForeColor = true;
			this.treeList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.treeList.Appearance.HideSelectionRow.Options.UseForeColor = true;
			this.treeList.Location = new System.Drawing.Point(2, 0);
			this.treeList.Name = "treeList";
			this.treeList.OptionsDragAndDrop.DropNodesMode = DevExpress.XtraTreeList.DropNodesMode.Advanced;
			this.treeList.OptionsMenu.ShowExpandCollapseItems = false;
			this.treeList.OptionsSimple.EditMode = Simple.Controls.TreeList.SimpleTreeEditMode.SelectEdit;
			this.treeList.OptionsSimple.LookAndFeelStyle = Simple.Controls.TreeList.SimpleTreeLookAndFeelStyle.ExplorerStyle;
			this.treeList.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
			this.treeList.OptionsView.ShowHorzLines = false;
			this.treeList.OptionsView.ShowIndicator = false;
			this.treeList.OptionsView.ShowVertLines = false;
			this.treeList.OptionsView.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
			this.treeList.SelectImageList = this.imageList;
			this.treeList.Size = new System.Drawing.Size(635, 454);
			this.treeList.TabIndex = 0;
			// 
			// simpleGroupEditPanel
			// 
			this.simpleGroupEditPanel.ChangableBindingObjectControl = this.graphController;
			this.simpleGroupEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.simpleGroupEditPanel.Location = new System.Drawing.Point(0, 0);
			this.simpleGroupEditPanel.Name = "simpleGroupEditPanel";
			this.simpleGroupEditPanel.Size = new System.Drawing.Size(438, 456);
			this.simpleGroupEditPanel.TabIndex = 0;
			// 
			// barButtonItemPrintPreview
			// 
			this.barButtonItemPrintPreview.Caption = "Print Preview";
			this.barButtonItemPrintPreview.Id = 9;
			this.barButtonItemPrintPreview.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.PrintPreview;
			this.barButtonItemPrintPreview.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.PrintPreview_Large;
			this.barButtonItemPrintPreview.Name = "barButtonItemPrintPreview";
			this.barButtonItemPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPrintPreview_ItemClick);
			// 
			// ribbonPageGroupGraphTools
			// 
			this.ribbonPageGroupGraphTools.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroupGraphTools.ItemLinks.Add(this.barButtonItemRemoveColumnSorting);
			this.ribbonPageGroupGraphTools.ItemLinks.Add(this.barButtonItemExpandAll, true);
			this.ribbonPageGroupGraphTools.ItemLinks.Add(this.barButtonItemCollapseAll);
			this.ribbonPageGroupGraphTools.ItemLinks.Add(this.barButtonItemFind, true);
			this.ribbonPageGroupGraphTools.Name = "ribbonPageGroupGraphTools";
			this.ribbonPageGroupGraphTools.Text = "Graph Tools";
			// 
			// barButtonItemExpandAll
			// 
			this.barButtonItemExpandAll.Caption = "Expand All";
			this.barButtonItemExpandAll.Id = 11;
			this.barButtonItemExpandAll.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.ExpandAll;
			this.barButtonItemExpandAll.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.ExpandAll_Large;
			this.barButtonItemExpandAll.Name = "barButtonItemExpandAll";
			this.barButtonItemExpandAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExpandAll_ItemClick);
			// 
			// barButtonItemCollapseAll
			// 
			this.barButtonItemCollapseAll.Caption = "Collapse All";
			this.barButtonItemCollapseAll.Id = 12;
			this.barButtonItemCollapseAll.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.CollapseAll;
			this.barButtonItemCollapseAll.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.CollapseAll_Large;
			this.barButtonItemCollapseAll.Name = "barButtonItemCollapseAll";
			this.barButtonItemCollapseAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCollapseAll_ItemClick);
			// 
			// barButtonItemFind
			// 
			this.barButtonItemFind.Caption = "Find";
			this.barButtonItemFind.Id = 10;
			this.barButtonItemFind.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Find;
			this.barButtonItemFind.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Find_Large;
			this.barButtonItemFind.Name = "barButtonItemFind";
			this.barButtonItemFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFind_ItemClick);
			// 
			// barButtonItemPrint
			// 
			this.barButtonItemPrint.Caption = "Print";
			this.barButtonItemPrint.Id = 13;
			this.barButtonItemPrint.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Printer;
			this.barButtonItemPrint.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Printer_Large;
			this.barButtonItemPrint.Name = "barButtonItemPrint";
			this.barButtonItemPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPrint_ItemClick);
			// 
			// ribbonPageGroupPrinting
			// 
			this.ribbonPageGroupPrinting.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroupPrinting.ItemLinks.Add(this.barButtonItemPrintPreview);
			this.ribbonPageGroupPrinting.ItemLinks.Add(this.barButtonItemPrint);
			this.ribbonPageGroupPrinting.Name = "ribbonPageGroupPrinting";
			this.ribbonPageGroupPrinting.Text = "Printing";
			// 
			// RibbonModuleUserGroups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.GraphController = this.graphController;
			this.Name = "RibbonModuleUserGroups";
			this.Size = new System.Drawing.Size(1081, 600);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel1)).EndInit();
			this.splitContainerMain.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel2)).EndInit();
			this.splitContainerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tempRibbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem barButtonItemAddFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddSubFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddUserGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRemove;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupElement;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private System.Windows.Forms.ImageList imageList;
        //private GraphController graphController;
        private Simple.Controls.TreeList.SimpleTreeList treeList;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddFolderPopup;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddSubFolderPopup;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddUserGroupPopup;
        private Simple.Objects.Controls.SimpleObjectGroupEditPanel simpleGroupEditPanel;
		private DevExpress.XtraBars.BarButtonItem barButtonItemPrintPreview;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGraphTools;
		private DevExpress.XtraBars.BarButtonItem barButtonItemFind;
		private DevExpress.XtraBars.BarButtonItem barButtonItemExpandAll;
		private DevExpress.XtraBars.BarButtonItem barButtonItemCollapseAll;
		private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupPrinting;
		private DevExpress.XtraBars.BarButtonItem barButtonItemMoveUp;
		private DevExpress.XtraBars.BarButtonItem barButtonItemMoveDown;
		private DevExpress.XtraBars.BarButtonItem barButtonItemRemoveColumnSorting;
		private DevExpress.XtraBars.BarButtonItem barButtonItemRejectChanges;
	}
}
