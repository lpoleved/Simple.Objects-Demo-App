namespace DemoApp
{
    partial class FormMain
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
			DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Simple.Controls.FormSplashScreen), true, true);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.ribbonMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
			this.barButtonSettings = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemStatistics = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemUserManual = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonAbout = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.menuItemHelp = new DevExpress.XtraBars.BarButtonItem();
			this.menuItemAbout = new DevExpress.XtraBars.BarButtonItem();
			this.menuItemVersionHistory = new DevExpress.XtraBars.BarButtonItem();
			this.menuHelp = new DevExpress.XtraBars.BarSubItem();
			this.menuItemChangeSkin = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItemChangeSkin = new DevExpress.XtraBars.BarSubItem();
			this.barButtonHelp = new DevExpress.XtraBars.BarButtonItem();
			this.barStaticItemUser = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItemNetServer = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItemInfo = new DevExpress.XtraBars.BarStaticItem();
			this.undoButton = new DevExpress.XtraBars.BarButtonItem();
			this.redoButton = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemSave = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.popupMenuDatastoreManagement = new DevExpress.XtraBars.PopupMenu(this.components);
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.panelMain = new System.Windows.Forms.Panel();
			this.undoManager = new Simple.Objects.Controls.UndoManager();
			((System.ComponentModel.ISupportInitialize)(this.ribbonMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuDatastoreManagement)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonMain
			// 
			this.ribbonMain.ApplicationButtonDropDownControl = this.applicationMenu;
			this.ribbonMain.ApplicationButtonImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonMain.ApplicationButtonImageOptions.Image")));
			this.ribbonMain.ApplicationButtonText = null;
			this.ribbonMain.AutoSizeItems = true;
			this.ribbonMain.ExpandCollapseItem.Id = 0;
			this.ribbonMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonMain.ExpandCollapseItem,
            this.ribbonMain.SearchEditItem,
            this.barButtonItem5,
            this.barButtonItem6,
            this.menuItemHelp,
            this.menuItemAbout,
            this.menuItemVersionHistory,
            this.menuHelp,
            this.menuItemChangeSkin,
            this.barButtonAbout,
            this.barSubItemChangeSkin,
            this.barButtonHelp,
            this.barStaticItemUser,
            this.barStaticItemNetServer,
            this.barStaticItemInfo,
            this.barButtonSettings,
            this.barButtonItemStatistics,
            this.barButtonItemUserManual,
            this.undoButton,
            this.redoButton,
            this.barButtonItemSave});
			this.ribbonMain.Location = new System.Drawing.Point(0, 0);
			this.ribbonMain.MaxItemId = 45;
			this.ribbonMain.Name = "ribbonMain";
			this.ribbonMain.PageHeaderItemLinks.Add(this.barButtonHelp);
			this.ribbonMain.QuickToolbarItemLinks.Add(this.barButtonItemSave);
			this.ribbonMain.QuickToolbarItemLinks.Add(this.undoButton, true);
			this.ribbonMain.QuickToolbarItemLinks.Add(this.redoButton);
			this.ribbonMain.QuickToolbarItemLinks.Add(this.barSubItemChangeSkin, true);
			this.ribbonMain.QuickToolbarItemLinks.Add(this.barButtonAbout);
			this.ribbonMain.Size = new System.Drawing.Size(1092, 58);
			this.ribbonMain.StatusBar = this.ribbonStatusBar;
			// 
			// applicationMenu
			// 
			this.applicationMenu.ItemLinks.Add(this.barButtonSettings);
			this.applicationMenu.ItemLinks.Add(this.barButtonItemStatistics);
			this.applicationMenu.ItemLinks.Add(this.barButtonItemUserManual, true);
			this.applicationMenu.ItemLinks.Add(this.barButtonAbout);
			this.applicationMenu.Name = "applicationMenu";
			this.applicationMenu.Ribbon = this.ribbonMain;
			this.applicationMenu.ShowRightPane = true;
			// 
			// barButtonSettings
			// 
			this.barButtonSettings.Caption = "Settings";
			this.barButtonSettings.Hint = "Edit Application Settings";
			this.barButtonSettings.Id = 37;
			this.barButtonSettings.ImageOptions.Image = global::DemoApp.Properties.Resources.Configure;
			this.barButtonSettings.ImageOptions.LargeImage = global::DemoApp.Properties.Resources.Configure_Large;
			this.barButtonSettings.Name = "barButtonSettings";
			this.barButtonSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSettings_ItemClick);
			// 
			// barButtonItemStatistics
			// 
			this.barButtonItemStatistics.Caption = "Statistics";
			this.barButtonItemStatistics.Hint = "Gets the Statistic Information";
			this.barButtonItemStatistics.Id = 40;
			this.barButtonItemStatistics.ImageOptions.Image = global::DemoApp.Properties.Resources.Statistics;
			this.barButtonItemStatistics.ImageOptions.LargeImage = global::DemoApp.Properties.Resources.Statistics_Large;
			this.barButtonItemStatistics.Name = "barButtonItemStatistics";
			this.barButtonItemStatistics.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemStatistics_ItemClick);
			// 
			// barButtonItemUserManual
			// 
			this.barButtonItemUserManual.Caption = "User Manual";
			this.barButtonItemUserManual.Hint = "Read the User Manual";
			this.barButtonItemUserManual.Id = 44;
			this.barButtonItemUserManual.ImageOptions.Image = global::DemoApp.Properties.Resources.BookOpen;
			this.barButtonItemUserManual.ImageOptions.LargeImage = global::DemoApp.Properties.Resources.BookOpen_Large;
			this.barButtonItemUserManual.Name = "barButtonItemUserManual";
			this.barButtonItemUserManual.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUserManual_ItemClick);
			// 
			// barButtonAbout
			// 
			this.barButtonAbout.Caption = "About";
			this.barButtonAbout.Hint = "Activate About Form";
			this.barButtonAbout.Id = 22;
			this.barButtonAbout.ImageOptions.Image = global::DemoApp.Properties.Resources.Info;
			this.barButtonAbout.ImageOptions.LargeImage = global::DemoApp.Properties.Resources.Info_Large;
			this.barButtonAbout.Name = "barButtonAbout";
			this.barButtonAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAbout_ItemClick);
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "Undo";
			this.barButtonItem5.Id = 8;
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// barButtonItem6
			// 
			this.barButtonItem6.Caption = "Delete";
			this.barButtonItem6.Id = 9;
			this.barButtonItem6.ImageOptions.Image = global::DemoApp.Properties.Resources.Remove;
			this.barButtonItem6.Name = "barButtonItem6";
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.Caption = "Help";
			this.menuItemHelp.Enabled = false;
			this.menuItemHelp.Id = 11;
			this.menuItemHelp.ImageOptions.Image = global::DemoApp.Properties.Resources.BookOpen;
			this.menuItemHelp.Name = "menuItemHelp";
			this.menuItemHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemHelp_ItemClick);
			// 
			// menuItemAbout
			// 
			this.menuItemAbout.Caption = "About";
			this.menuItemAbout.Id = 12;
			this.menuItemAbout.ImageOptions.Image = global::DemoApp.Properties.Resources.Info;
			this.menuItemAbout.Name = "menuItemAbout";
			this.menuItemAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAbout_ItemClick);
			// 
			// menuItemVersionHistory
			// 
			this.menuItemVersionHistory.Caption = "Version history";
			this.menuItemVersionHistory.Enabled = false;
			this.menuItemVersionHistory.Id = 13;
			this.menuItemVersionHistory.Name = "menuItemVersionHistory";
			this.menuItemVersionHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemVersionHistory_ItemClick);
			// 
			// menuHelp
			// 
			this.menuHelp.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.menuHelp.Caption = "Help";
			this.menuHelp.Id = 16;
			this.menuHelp.ImageOptions.Image = global::DemoApp.Properties.Resources.Help;
			this.menuHelp.MenuCaption = "Help";
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
			this.menuHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHelp_ItemClick);
			// 
			// menuItemChangeSkin
			// 
			this.menuItemChangeSkin.Caption = "Change Skin";
			this.menuItemChangeSkin.Id = 20;
			this.menuItemChangeSkin.Name = "menuItemChangeSkin";
			// 
			// barSubItemChangeSkin
			// 
			this.barSubItemChangeSkin.Caption = "Change Skin";
			this.barSubItemChangeSkin.Id = 23;
			this.barSubItemChangeSkin.ImageOptions.Image = global::DemoApp.Properties.Resources.PaintStyle;
			this.barSubItemChangeSkin.Name = "barSubItemChangeSkin";
			// 
			// barButtonHelp
			// 
			this.barButtonHelp.Caption = "Help";
			this.barButtonHelp.Id = 24;
			this.barButtonHelp.ImageOptions.Image = global::DemoApp.Properties.Resources.Help;
			this.barButtonHelp.Name = "barButtonHelp";
			this.barButtonHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHelp_ItemClick);
			// 
			// barStaticItemUser
			// 
			this.barStaticItemUser.Id = 28;
			this.barStaticItemUser.ImageOptions.Image = global::DemoApp.Properties.Resources.User;
			this.barStaticItemUser.Name = "barStaticItemUser";
			this.barStaticItemUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// barStaticItemNetServer
			// 
			this.barStaticItemNetServer.Id = 30;
			this.barStaticItemNetServer.ImageOptions.Image = global::DemoApp.Properties.Resources.Server;
			this.barStaticItemNetServer.Name = "barStaticItemNetServer";
			// 
			// barStaticItemInfo
			// 
			this.barStaticItemInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.barStaticItemInfo.Caption = "Powered by SimpleObjects";
			this.barStaticItemInfo.Id = 31;
			this.barStaticItemInfo.ImageOptions.Image = global::DemoApp.Properties.Resources.SimpleObjects_Large;
			this.barStaticItemInfo.ImageOptions.LargeImage = global::DemoApp.Properties.Resources.SimpleObjects_Large;
			this.barStaticItemInfo.Name = "barStaticItemInfo";
			this.barStaticItemInfo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// undoButton
			// 
			this.undoButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.undoButton.Caption = "Undo";
			this.undoButton.Enabled = false;
			this.undoButton.Hint = "Undo last action(s)";
			this.undoButton.Id = 70;
			this.undoButton.ImageOptions.Image = global::DemoApp.Properties.Resources.Undo;
			this.undoButton.Name = "undoButton";
			// 
			// redoButton
			// 
			this.redoButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.redoButton.Caption = "Redo";
			this.redoButton.Enabled = false;
			this.redoButton.Hint = "Redo previous action(s)";
			this.redoButton.Id = 71;
			this.redoButton.ImageOptions.Image = global::DemoApp.Properties.Resources.Redo;
			this.redoButton.Name = "redoButton";
			// 
			// barButtonItemSave
			// 
			this.barButtonItemSave.Caption = "Save";
			this.barButtonItemSave.Id = 72;
			this.barButtonItemSave.ImageOptions.Image = global::DemoApp.Properties.Resources.SaveButton;
			this.barButtonItemSave.Name = "barButtonItemSave";
			this.barButtonItemSave.ItemClick += BarButtonItemSave_ItemClick; ;
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.ItemLinks.Add(this.barStaticItemUser);
			this.ribbonStatusBar.ItemLinks.Add(this.barStaticItemNetServer, true);
			this.ribbonStatusBar.ItemLinks.Add(this.barStaticItemInfo);
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 659);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbonMain;
			this.ribbonStatusBar.Size = new System.Drawing.Size(1092, 24);
			// 
			// popupMenuDatastoreManagement
			// 
			this.popupMenuDatastoreManagement.Name = "popupMenuDatastoreManagement";
			this.popupMenuDatastoreManagement.Ribbon = this.ribbonMain;
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Black";
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.Color.Transparent;
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 58);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1092, 601);
			this.panelMain.TabIndex = 3;
			// 
			// undoManager
			// 
			this.undoManager.RedoButton = this.redoButton;
			this.undoManager.RibbonControl = this.ribbonMain;
			this.undoManager.UndoButton = this.undoButton;
			// 
			// FormMain
			// 
			this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.Appearance.Options.UseBackColor = true;
			this.Appearance.Options.UseFont = true;
			this.ClientSize = new System.Drawing.Size(1092, 683);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.ribbonMain);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormMain.IconOptions.Icon")));
			this.Name = "FormMain";
			this.Ribbon = this.ribbonMain;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "SimpleObjects Demo Application";
			((System.ComponentModel.ISupportInitialize)(this.ribbonMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.popupMenuDatastoreManagement)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonMain;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem menuItemHelp;
        private DevExpress.XtraBars.BarButtonItem menuItemVersionHistory;
        private DevExpress.XtraBars.BarButtonItem menuItemAbout;
        private DevExpress.XtraBars.BarSubItem menuHelp;
        private DevExpress.XtraBars.BarButtonItem menuItemChangeSkin;
        private DevExpress.XtraBars.BarButtonItem barButtonAbout;
        private DevExpress.XtraBars.BarSubItem barSubItemChangeSkin;
        private DevExpress.XtraBars.BarButtonItem barButtonHelp;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarStaticItem barStaticItemUser;
        private DevExpress.XtraBars.BarStaticItem barStaticItemNetServer;
        private DevExpress.XtraBars.BarStaticItem barStaticItemInfo;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraBars.BarButtonItem barButtonSettings;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItemStatistics;
        private DevExpress.XtraBars.PopupMenu popupMenuDatastoreManagement;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUserManual;
        private DevExpress.XtraBars.BarButtonItem undoButton;
        private DevExpress.XtraBars.BarButtonItem redoButton;
        private Simple.Objects.Controls.UndoManager undoManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSave;
    }
}