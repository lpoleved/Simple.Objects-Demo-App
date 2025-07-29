namespace DemoApp
{
    partial class RibbonModuleHome
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
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.simpleGroupPanel = new Simple.Objects.Controls.SimpleObjectGroupEditPanel();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barEditItemRibbonStyle = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemImageComboBoxRibonStyle = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.barEditItemRibbonPageStyle = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemImageComboBoxRibonPageStyle = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.barEditItemRibbonColorSheme = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemComboBoxRibbonColorScheme = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.treeListWithColumnGroup1 = new Simple.Controls.TreeList.SimpleTreeListWithColumnGroup();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tempRibbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxRibonStyle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxRibonPageStyle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxRibbonColorScheme)).BeginInit();
			this.SuspendLayout();
			// 
			// graphController
			// 
			this.graphController.GraphKey = DemoApp.Objects.GraphKey.Empty;
			this.graphController.ManyToManyRelationKey = DemoApp.Objects.ManyToManyRelationKey.Empty;
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Location = new System.Drawing.Point(0, 150);
			this.splitContainerMain.Panel1.Controls.Add(this.treeListWithColumnGroup1);
			this.splitContainerMain.Panel2.Controls.Add(this.simpleGroupPanel);
			this.splitContainerMain.Size = new System.Drawing.Size(948, 435);
			this.splitContainerMain.SplitterPosition = 557;
			// 
			// tempRibbonControl
			// 
			this.tempRibbonControl.ExpandCollapseItem.Id = 0;
			this.tempRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItemRibbonPageStyle,
            this.barEditItemRibbonStyle,
            this.barEditItemRibbonColorSheme});
			this.tempRibbonControl.MaxItemId = 80;
			this.tempRibbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBoxRibonStyle,
            this.repositoryItemImageComboBoxRibonPageStyle,
            this.repositoryItemComboBoxRibbonColorScheme});
			// 
			// 
			// 
			this.tempRibbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
			this.tempRibbonControl.SearchEditItem.EditWidth = 150;
			this.tempRibbonControl.SearchEditItem.Id = -5000;
			this.tempRibbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
			this.tempRibbonControl.Size = new System.Drawing.Size(948, 150);
			// 
			// ribbonPage
			// 
			this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage.Text = "Home";
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// simpleGroupPanel
			// 
			this.simpleGroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.simpleGroupPanel.Location = new System.Drawing.Point(0, 0);
			this.simpleGroupPanel.Name = "simpleGroupPanel";
			this.simpleGroupPanel.Size = new System.Drawing.Size(385, 435);
			this.simpleGroupPanel.TabIndex = 0;
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemRibbonStyle);
			this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemRibbonPageStyle);
			this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemRibbonColorSheme);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
			this.ribbonPageGroup1.Text = "Visual Styling";
			// 
			// barEditItemRibbonStyle
			// 
			this.barEditItemRibbonStyle.Caption = "Ribbon Style:";
			this.barEditItemRibbonStyle.Edit = this.repositoryItemImageComboBoxRibonStyle;
			this.barEditItemRibbonStyle.EditWidth = 113;
			this.barEditItemRibbonStyle.Hint = "Set Ribbon Style";
			this.barEditItemRibbonStyle.Id = 78;
			this.barEditItemRibbonStyle.Name = "barEditItemRibbonStyle";
			this.barEditItemRibbonStyle.EditValueChanged += new System.EventHandler(this.barEditItemRibbonStyle_EditValueChanged);
			// 
			// repositoryItemImageComboBoxRibonStyle
			// 
			this.repositoryItemImageComboBoxRibonStyle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemImageComboBoxRibonStyle.Name = "repositoryItemImageComboBoxRibonStyle";
			// 
			// barEditItemRibbonPageStyle
			// 
			this.barEditItemRibbonPageStyle.Caption = "Ribbon Page Style:";
			this.barEditItemRibbonPageStyle.Edit = this.repositoryItemImageComboBoxRibonPageStyle;
			this.barEditItemRibbonPageStyle.EditWidth = 113;
			this.barEditItemRibbonPageStyle.Hint = "Set Ribbon Pages Appearance Style";
			this.barEditItemRibbonPageStyle.Id = 77;
			this.barEditItemRibbonPageStyle.Name = "barEditItemRibbonPageStyle";
			this.barEditItemRibbonPageStyle.EditValueChanged += new System.EventHandler(this.barEditItemRibbonPageStyle_EditValueChanged);
			// 
			// repositoryItemImageComboBoxRibonPageStyle
			// 
			this.repositoryItemImageComboBoxRibonPageStyle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemImageComboBoxRibonPageStyle.Name = "repositoryItemImageComboBoxRibonPageStyle";
			// 
			// barEditItemRibbonColorSheme
			// 
			this.barEditItemRibbonColorSheme.Caption = "Ribbon Color Sheme:";
			this.barEditItemRibbonColorSheme.Edit = this.repositoryItemComboBoxRibbonColorScheme;
			this.barEditItemRibbonColorSheme.EditWidth = 113;
			this.barEditItemRibbonColorSheme.Hint = "Set Ribbon Color Sheme";
			this.barEditItemRibbonColorSheme.Id = 79;
			this.barEditItemRibbonColorSheme.Name = "barEditItemRibbonColorSheme";
			this.barEditItemRibbonColorSheme.EditValueChanged += new System.EventHandler(this.barEditItemRibbonColorSheme_EditValueChanged);
			// 
			// repositoryItemComboBoxRibbonColorScheme
			// 
			this.repositoryItemComboBoxRibbonColorScheme.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.repositoryItemComboBoxRibbonColorScheme.Name = "repositoryItemComboBoxRibbonColorScheme";
			this.repositoryItemComboBoxRibbonColorScheme.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			// 
			// treeListWithColumnGroup1
			// 
			this.treeListWithColumnGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeListWithColumnGroup1.Location = new System.Drawing.Point(0, 0);
			this.treeListWithColumnGroup1.Name = "treeListWithColumnGroup1";
			this.treeListWithColumnGroup1.Size = new System.Drawing.Size(557, 435);
			this.treeListWithColumnGroup1.TabIndex = 0;
			// 
			// RibbonModuleHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "RibbonModuleHome";
			this.Size = new System.Drawing.Size(948, 585);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tempRibbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxRibonStyle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBoxRibonPageStyle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxRibbonColorScheme)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private Simple.Objects.Controls.SimpleObjectGroupEditPanel simpleGroupPanel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBoxRibonStyle;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBoxRibonPageStyle;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxRibbonColorScheme;
        private DevExpress.XtraBars.BarEditItem barEditItemRibbonStyle;
        private DevExpress.XtraBars.BarEditItem barEditItemRibbonPageStyle;
        private DevExpress.XtraBars.BarEditItem barEditItemRibbonColorSheme;
        private Simple.Controls.TreeList.SimpleTreeListWithColumnGroup treeListWithColumnGroup1;
    }
}
