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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Ribbon;
using Simple.Objects;
using Simple.Controls;
using Simple.Controls.TreeList;
using Simple.Objects.Controls;
using DemoApp.AppContext;

namespace DemoApp
{
    [ToolboxItem(false)]
    public partial class RibbonModuleHome : RibbonModuleSplitPanelTemplate
    {
        public RibbonModuleHome()
        {
            InitializeComponent();
            this.InitializeEditors();
        }

        private void InitializeEditors()
        {
            this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1));
            this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1));
			this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Office 2013", RibbonControlStyle.Office2013, -1));
            this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Office 201", RibbonControlStyle.Office2019, -1));
            this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Mac Office", RibbonControlStyle.MacOffice, -1));
			this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Tablet Office", RibbonControlStyle.TabletOffice, -1));
			this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Tablet Office Ex", RibbonControlStyle.OfficeUniversal, -1));
			this.barEditItemRibbonStyle.EditValue = ClientAppContext.Instance.UserSettings.RibbonStyle;

			//this.repositoryItemImageComboBoxRibonPageStyle.Items.Add(new ImageComboBoxItem("Static", RibbonControlPagePlacement.Static, -1));
			//this.repositoryItemImageComboBoxRibonPageStyle.Items.Add(new ImageComboBoxItem("Static Grouping", RibbonControlPagePlacement.StaticGrouping, -1));
            this.repositoryItemImageComboBoxRibonPageStyle.Items.Add(new ImageComboBoxItem("Dynamic", RibbonControlPagePlacement.Dynamic, -1));
            //this.repositoryItemImageComboBoxRibonPageStyle.Items.Add(new ImageComboBoxItem("Dynamic Grouping", RibbonControlPagePlacement.DynamicGrouping, -1));
			this.barEditItemRibbonPageStyle.EditValue = ClientAppContext.Instance.UserSettings.RibbonPagePlacement;


            foreach (object obj in Enum.GetValues(typeof(RibbonControlColorScheme)))
                this.repositoryItemComboBoxRibbonColorScheme.Items.Add(obj);

			this.barEditItemRibbonColorSheme.EditValue = ClientAppContext.Instance.UserSettings.RibbonColorScheme;

            TreeListColumn columnGroup = this.treeListWithColumnGroup1.ColumnGroup.Columns.Add();
            columnGroup.Name = "ApplicationData";
            columnGroup.Caption = "Application Data";
            columnGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            columnGroup.Visible = true;
            columnGroup.OptionsColumn.AllowSort = false;

            columnGroup = this.treeListWithColumnGroup1.ColumnGroup.Columns.Add();
            columnGroup.Name = "RemoteDeviceData";
            columnGroup.Caption = "Remote Device Data";
            columnGroup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            columnGroup.Visible = true;
            columnGroup.OptionsColumn.AllowSort = false;

            TreeListColumn column = this.treeListWithColumnGroup1.TreeList.Columns.Add();
            column.Name = "ApplicationDataName";
            column.Caption = "Name";
            column.Visible = true;

            column = this.treeListWithColumnGroup1.TreeList.Columns.Add();
            column.Name = "ApplicationDataDescription";
            column.Caption = "Description";
            column.Visible = true;
            
            column = this.treeListWithColumnGroup1.TreeList.Columns.Add();
            column.Name = "RemoteDeviceName";
            column.Caption = "Name2";
            column.Visible = true;
            
            column = this.treeListWithColumnGroup1.TreeList.Columns.Add();
            column.Name = "RemoteDeviceDescription";
            column.Caption = "Description2";
            column.Visible = true;

            this.treeListWithColumnGroup1.ColumnGroup.ColumnWidthChanged += new DevExpress.XtraTreeList.ColumnWidthChangedEventHandler(TreeListColumnGroup_ColumnWidthChanged);
            this.treeListWithColumnGroup1.TreeList.ColumnWidthChanged += new DevExpress.XtraTreeList.ColumnWidthChangedEventHandler(TreeList_ColumnWidthChanged);
            this.treeListWithColumnGroup1.TreeList.OptionsView.AutoWidth = false;
            this.treeListWithColumnGroup1.ColumnGroup.OptionsView.AutoWidth = false;
        }

        private void TreeList_ColumnWidthChanged(object sender, ColumnChangedEventArgs e)
        {
            if (e.Column.Name == "ApplicationDataName" || e.Column.Name == "ApplicationDataDescription")
            {
                this.treeListWithColumnGroup1.ColumnGroup.Columns[0].Width = this.treeListWithColumnGroup1.TreeList.Columns[0].Width + this.treeListWithColumnGroup1.TreeList.Columns[1].Width;
            }
        }

        private void TreeListColumnGroup_ColumnWidthChanged(object sender, ColumnChangedEventArgs e)
        {
            //if (e.Column.Name == "ApplicationData")
            //{
            //    this.treeListWithColumnGroup1.TreeList.Columns[1].Width = e.Column.Width - this.treeListWithColumnGroup1.TreeList.Columns[0].Width;
            //}
            //else if (e.Column.Name == "RemoteDeviceData")
            //{

            //}
        }

        private void barEditItemRibbonStyle_EditValueChanged(object sender, EventArgs e)
        {
            this.RibbonPage.Ribbon.RibbonStyle = (RibbonControlStyle)this.barEditItemRibbonStyle.EditValue;
            this.RibbonPage.Ribbon.ApplicationIcon = (this.RibbonPage.Ribbon.RibbonStyle == RibbonControlStyle.Office2007) ? global::DemoApp.Icons.Properties.Resources.SimpleObjects_Large : null;
            this.barEditItemRibbonColorSheme.Enabled = (this.RibbonPage.Ribbon.RibbonStyle != RibbonControlStyle.Office2007);

			ClientAppContext.Instance.UserSettings.RibbonStyle = (int)this.RibbonPage.Ribbon.RibbonStyle;
        }

        private void barEditItemRibbonPageStyle_EditValueChanged(object sender, EventArgs e)
        {
   //         if (this.RibbonPage.Ribbon.FindForm() is FormMainFullBase formMain)
   //         {
   //             formMain.ribbonPagePlacement = (RibbonControlPagePlacement)this.barEditItemRibbonPageStyle.EditValue;
   //             formMain.InitializeRibbonPageStyle();
   //             formMain.OnRibbon_SelectedPageChanged(this, new EventArgs());
   //         }

			ClientAppContext.Instance.UserSettings.RibbonPagePlacement = (int)this.barEditItemRibbonPageStyle.EditValue;
        }

        private void barEditItemRibbonColorSheme_EditValueChanged(object sender, EventArgs e)
        {
            this.RibbonPage.Ribbon.ColorScheme = (RibbonControlColorScheme)this.barEditItemRibbonColorSheme.EditValue;
			ClientAppContext.Instance.UserSettings.RibbonColorScheme = (int)this.RibbonPage.Ribbon.ColorScheme;
        }
    }
}
