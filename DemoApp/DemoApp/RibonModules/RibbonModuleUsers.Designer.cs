namespace DemoApp
{
	partial class RibbonModuleUsers
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
			this.components = new System.ComponentModel.Container();
			this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.barButtonItemAddFolderPopup = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddSubFolderPopup = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddUserPopup = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemRemove = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddFolder = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddSubFolder = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAddUser = new DevExpress.XtraBars.BarButtonItem();
			this.treeList = new Simple.Controls.TreeList.SimpleTreeList();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.ribbonPageGroupAdd = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPageGroupElement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barButtonItemMoveUp = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemMoveDown = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemRejectChanges = new DevExpress.XtraBars.BarButtonItem();
			this.simpleGroupEditPanel = new Simple.Objects.Controls.SimpleObjectGroupEditPanel();
			this.barButtonItemRemoveColumnSorting = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
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
			this.graphController.GraphKey = DemoApp.Objects.GraphKey.Users;
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
			this.splitContainerMain.Size = new System.Drawing.Size(948, 441);
			this.splitContainerMain.SplitterPosition = 557;
			// 
			// tempRibbonControl
			// 
			this.tempRibbonControl.ExpandCollapseItem.Id = 0;
			this.tempRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAddUser,
            this.barButtonItemSave,
            this.barButtonItemRemove,
            this.barButtonItemAddFolder,
            this.barButtonItemAddSubFolder,
            this.barButtonItemAddUserPopup,
            this.barButtonItemAddFolderPopup,
            this.barButtonItemAddSubFolderPopup,
            this.barButtonItemRefresh,
            this.barButtonItemPrintPreview,
            this.barButtonItemFind,
            this.barButtonItemExpandAll,
            this.barButtonItemCollapseAll,
            this.barButtonItemPrint,
            this.barButtonItemMoveUp,
            this.barButtonItemMoveDown,
            this.barButtonItemRemoveColumnSorting,
            this.barButtonItemRejectChanges});
			this.tempRibbonControl.MaxItemId = 86;
			// 
			// 
			// 
			this.tempRibbonControl.SearchEditItem.AccessibleName = "Search Item";
			this.tempRibbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
			this.tempRibbonControl.SearchEditItem.EditWidth = 150;
			this.tempRibbonControl.SearchEditItem.Id = -5000;
			this.tempRibbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.tempRibbonControl.Size = new System.Drawing.Size(948, 144);
			// 
			// ribbonPage
			// 
			this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAdd,
            this.ribbonPageGroupElement,
            this.ribbonPageGroupGraphTools,
            this.ribbonPageGroupPrinting});
			this.ribbonPage.Text = "Users";
			// 
			// popupMenu
			// 
			this.popupMenu.ItemLinks.Add(this.barButtonItemAddFolderPopup, true);
			this.popupMenu.ItemLinks.Add(this.barButtonItemAddSubFolderPopup);
			this.popupMenu.ItemLinks.Add(this.barButtonItemAddUserPopup, true);
			this.popupMenu.ItemLinks.Add(this.barButtonItemRemove, true);
			this.popupMenu.MenuCaption = "Users";
			this.popupMenu.Name = "popupMenu";
			this.popupMenu.Ribbon = this.tempRibbonControl;
			this.popupMenu.ShowCaption = true;
			// 
			// barButtonItemAddFolderPopup
			// 
			this.barButtonItemAddFolderPopup.Caption = "Add Folder";
			this.barButtonItemAddFolderPopup.Id = 74;
			this.barButtonItemAddFolderPopup.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Folder_Add;
			this.barButtonItemAddFolderPopup.Name = "barButtonItemAddFolderPopup";
			// 
			// barButtonItemAddSubFolderPopup
			// 
			this.barButtonItemAddSubFolderPopup.Caption = "Add Sub Folder";
			this.barButtonItemAddSubFolderPopup.Id = 75;
			this.barButtonItemAddSubFolderPopup.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.SubFolder_Add;
			this.barButtonItemAddSubFolderPopup.Name = "barButtonItemAddSubFolderPopup";
			// 
			// barButtonItemAddUserPopup
			// 
			this.barButtonItemAddUserPopup.Caption = "Add User";
			this.barButtonItemAddUserPopup.Id = 73;
			this.barButtonItemAddUserPopup.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Administrator_Add;
			this.barButtonItemAddUserPopup.Name = "barButtonItemAddUserPopup";
			// 
			// barButtonItemRemove
			// 
			this.barButtonItemRemove.Caption = "Remove";
			this.barButtonItemRemove.Hint = "Remove";
			this.barButtonItemRemove.Id = 59;
			this.barButtonItemRemove.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Remove;
			this.barButtonItemRemove.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Remove_Large;
			this.barButtonItemRemove.Name = "barButtonItemRemove";
			// 
			// barButtonItemAddFolder
			// 
			this.barButtonItemAddFolder.AccessibleDescription = "";
			this.barButtonItemAddFolder.AccessibleName = "";
			this.barButtonItemAddFolder.Caption = "Folder";
			this.barButtonItemAddFolder.Hint = "Add";
			this.barButtonItemAddFolder.Id = 61;
			this.barButtonItemAddFolder.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Folder_Add;
			this.barButtonItemAddFolder.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Folder_Add_Large;
			this.barButtonItemAddFolder.Name = "barButtonItemAddFolder";
			// 
			// barButtonItemAddSubFolder
			// 
			this.barButtonItemAddSubFolder.Caption = "Sub Folder";
			this.barButtonItemAddSubFolder.Hint = "Add";
			this.barButtonItemAddSubFolder.Id = 62;
			this.barButtonItemAddSubFolder.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.SubFolder_Add;
			this.barButtonItemAddSubFolder.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.SubFolder_Add_Large;
			this.barButtonItemAddSubFolder.Name = "barButtonItemAddSubFolder";
			// 
			// barButtonItemAddUser
			// 
			this.barButtonItemAddUser.Caption = "User";
			this.barButtonItemAddUser.Hint = "Add";
			this.barButtonItemAddUser.Id = 56;
			this.barButtonItemAddUser.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Administrator_Add;
			this.barButtonItemAddUser.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Administrator_Add_Large;
			this.barButtonItemAddUser.Name = "barButtonItemAddUser";
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
			this.treeList.Size = new System.Drawing.Size(555, 439);
			this.treeList.TabIndex = 0;
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ribbonPageGroupInsert
			// 
			this.ribbonPageGroupAdd.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroupAdd.ItemLinks.Add(this.barButtonItemAddFolder);
			this.ribbonPageGroupAdd.ItemLinks.Add(this.barButtonItemAddSubFolder);
			this.ribbonPageGroupAdd.ItemLinks.Add(this.barButtonItemAddUser, true);
			this.ribbonPageGroupAdd.Name = "ribbonPageGroupInsert";
			this.ribbonPageGroupAdd.Text = "Add";
			// 
			// barButtonItemSave
			// 
			this.barButtonItemSave.Caption = "Save";
			this.barButtonItemSave.Hint = "Save";
			this.barButtonItemSave.Id = 58;
			this.barButtonItemSave.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.SaveButton;
			this.barButtonItemSave.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.SaveButton_Large;
			this.barButtonItemSave.Name = "barButtonItemSave";
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
			this.barButtonItemMoveUp.Id = 82;
			this.barButtonItemMoveUp.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.MoveUp;
			this.barButtonItemMoveUp.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.MoveUp_Large;
			this.barButtonItemMoveUp.Name = "barButtonItemMoveUp";
			// 
			// barButtonItemMoveDown
			// 
			this.barButtonItemMoveDown.Caption = "Move Down";
			this.barButtonItemMoveDown.Id = 83;
			this.barButtonItemMoveDown.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.MoveDown;
			this.barButtonItemMoveDown.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.MoveDown_Large;
			this.barButtonItemMoveDown.Name = "barButtonItemMoveDown";
			// 
			// barButtonItemRejectChanges
			// 
			this.barButtonItemRejectChanges.Caption = "Reject Changes";
			this.barButtonItemRejectChanges.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
			this.barButtonItemRejectChanges.Id = 85;
			this.barButtonItemRejectChanges.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.RejectChanges;
			this.barButtonItemRejectChanges.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.RejectChanges_Large;
			this.barButtonItemRejectChanges.Name = "barButtonItemRejectChanges";
			// 
			// simpleGroupEditPanel
			// 
			this.simpleGroupEditPanel.ChangableBindingObjectControl = this.graphController;
			this.simpleGroupEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.simpleGroupEditPanel.Location = new System.Drawing.Point(0, 0);
			this.simpleGroupEditPanel.Name = "simpleGroupEditPanel";
			this.simpleGroupEditPanel.Size = new System.Drawing.Size(385, 441);
			this.simpleGroupEditPanel.TabIndex = 0;
			// 
			// barButtonItemRemoveColumnSorting
			// 
			this.barButtonItemRemoveColumnSorting.Caption = "Remove Column Sorting";
			this.barButtonItemRemoveColumnSorting.Id = 84;
			this.barButtonItemRemoveColumnSorting.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.RemoveSorting;
			this.barButtonItemRemoveColumnSorting.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.RemoveSorting_Large;
			this.barButtonItemRemoveColumnSorting.Name = "barButtonItemRemoveColumnSorting";
			// 
			// barButtonItemRefresh
			// 
			this.barButtonItemRefresh.Caption = "Refresh";
			this.barButtonItemRefresh.Id = 76;
			this.barButtonItemRefresh.Name = "barButtonItemRefresh";
			// 
			// barButtonItemPrintPreview
			// 
			this.barButtonItemPrintPreview.Caption = "Print Preview";
			this.barButtonItemPrintPreview.Id = 77;
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
			this.barButtonItemExpandAll.Id = 79;
			this.barButtonItemExpandAll.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.ExpandAll;
			this.barButtonItemExpandAll.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.ExpandAll_Large;
			this.barButtonItemExpandAll.Name = "barButtonItemExpandAll";
			this.barButtonItemExpandAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemExpandAll_ItemClick);
			// 
			// barButtonItemCollapseAll
			// 
			this.barButtonItemCollapseAll.Caption = "Collapse All";
			this.barButtonItemCollapseAll.Id = 80;
			this.barButtonItemCollapseAll.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.CollapseAll;
			this.barButtonItemCollapseAll.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.CollapseAll_Large;
			this.barButtonItemCollapseAll.Name = "barButtonItemCollapseAll";
			this.barButtonItemCollapseAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCollapseAll_ItemClick);
			// 
			// barButtonItemFind
			// 
			this.barButtonItemFind.Caption = "Find";
			this.barButtonItemFind.Id = 78;
			this.barButtonItemFind.ImageOptions.Image = global::DemoApp.Icons.Properties.Resources.Find;
			this.barButtonItemFind.ImageOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Find_Large;
			this.barButtonItemFind.Name = "barButtonItemFind";
			this.barButtonItemFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemFind_ItemClick);
			// 
			// barButtonItemPrint
			// 
			this.barButtonItemPrint.Caption = "Print";
			this.barButtonItemPrint.Id = 81;
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
			// RibbonModuleUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.GraphController = this.graphController;
			this.Name = "RibbonModuleUsers";
			this.Size = new System.Drawing.Size(948, 585);
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

        private DevExpress.XtraBars.PopupMenu popupMenu;
        private Simple.Controls.TreeList.SimpleTreeList treeList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddUser;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupElement;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRemove;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddFolder;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddSubFolder;
        private System.Windows.Forms.ImageList imageList;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddUserPopup;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddFolderPopup;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddSubFolderPopup;
        private Simple.Objects.Controls.SimpleObjectGroupEditPanel simpleGroupEditPanel;
        //private GraphController graphController;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
		private DevExpress.XtraBars.BarButtonItem barButtonItemPrintPreview;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupGraphTools;
		private DevExpress.XtraBars.BarButtonItem barButtonItemFind;
		private DevExpress.XtraBars.BarButtonItem barButtonItemExpandAll;
		private DevExpress.XtraBars.BarButtonItem barButtonItemCollapseAll;
		private DevExpress.XtraBars.BarButtonItem barButtonItemPrint;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupPrinting;
		private DevExpress.XtraBars.BarButtonItem barButtonItemMoveDown;
		private DevExpress.XtraBars.BarButtonItem barButtonItemMoveUp;
		private DevExpress.XtraBars.BarButtonItem barButtonItemRemoveColumnSorting;
		private DevExpress.XtraBars.BarButtonItem barButtonItemRejectChanges;
	}
}
