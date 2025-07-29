using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Skins;
using Simple;
using Simple.Controls;
using Simple.Datastore.Controls;
using Simple.Network;
using DemoApp.AppContext;
using DemoApp.Objects;
using DemoApp;
//using MsgPack.Serialization;

namespace DemoApp
{
	public partial class FormSettings : XtraForm
	{
		private int minNumOfPasswdChars = 6;
		private Dictionary<RibbonControlStyle, string> ribbonStylesByEnumKey = new Dictionary<RibbonControlStyle, string>();
		private Dictionary<RibbonControlColorScheme, string> ribbonColorSchemeByEnumKey = new Dictionary<RibbonControlColorScheme, string>();
		//private Dictionary<string, DefaultSystemAclPolicy> defaultAclPoliciesByEnumName = null;
		private Dictionary<DefaultSystemAclPolicy, string> defaultAclPoliciesByEnumKey = new Dictionary<DefaultSystemAclPolicy, string>();
		//private Dictionary<Enum, string> defaultAclPoliciesByEnumKey2 = null;
		private RibbonControl? ribbon = null;
		private RibbonControlStyle ribbonStyle;
		private RibbonControlColorScheme ribbonColorScheme;

		public FormSettings()
		{
			InitializeComponent();

			//// 
			//// tabPageDatastore
			//// 
			//this.tabPageDatastore.Controls.Add(this.datastoreSettings);
			//// 
			//// datastoreSettings
			//// 
			//this.datastoreSettings.DatastoreType = Simple.Datastore.DatastoreProviderType.SqlServer;
			//         this.datastoreSettings.Location = new System.Drawing.Point(14, 17);
			//         this.datastoreSettings.Name = "datastoreSettings";
			//         this.datastoreSettings.OfficeAccessFilePath = "";
			//         this.datastoreSettings.ServerSystemSettings = null;
			//         this.datastoreSettings.Size = new System.Drawing.Size(389, 278);
			//         this.datastoreSettings.SqlConnectByConnectionString = false;
			//         this.datastoreSettings.SqlConnectionString = "";
			//         this.datastoreSettings.SqlDatabase = "";
			//         this.datastoreSettings.SqlNetworkConnection = false;
			//         this.datastoreSettings.SqlNetworkPort = 1433;
			//         this.datastoreSettings.SqlServer = "";
			//         this.datastoreSettings.TabIndex = 6;
		}

		public FormSettings(RibbonControl ribbon)
		{
			this.ribbon = ribbon;

			InitializeComponent();

			this.ribbonStylesByEnumKey.Add(RibbonControlStyle.Office2007, "Office 2007");
			this.ribbonStylesByEnumKey.Add(RibbonControlStyle.Office2010, "Office 2010");
			this.ribbonStylesByEnumKey.Add(RibbonControlStyle.Office2013, "Office 2013");
			this.ribbonStylesByEnumKey.Add(RibbonControlStyle.Office2019, "Office 2019");
			this.ribbonStylesByEnumKey.Add(RibbonControlStyle.MacOffice, "Mac Office");
			this.ribbonStylesByEnumKey.Add(RibbonControlStyle.TabletOffice, "Tablet Office");
			this.ribbonStylesByEnumKey.Add(RibbonControlStyle.OfficeUniversal, "Office Universal");

			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.Yellow, "Yellow");
			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.Blue, "Blue");
			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.Green, "Green");
			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.Orange, "Orange");
			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.Purple, "Purple");
			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.Default, "Default");
			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.Teal, "Teal");
			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.Red, "Red");
			this.ribbonColorSchemeByEnumKey.Add(RibbonControlColorScheme.DarkBlue, "Dark Blue");

			//this.defaultAclPoliciesByEnumKey = DefaultSystemAclPolicy.Permit.ToDictionary<DefaultSystemAclPolicy>();

			this.defaultAclPoliciesByEnumKey.Add(DefaultSystemAclPolicy.DenyAny, "deny ip any");
			this.defaultAclPoliciesByEnumKey.Add(DefaultSystemAclPolicy.PermitAny, "permit ip any");
			//this.defaultAclPoliciesByEnumKey = DefaultSystemAclPolicy.DenyIpAnyAny.ToDictionary<DefaultSystemAclPolicy>();
			//this.defaultAclPoliciesByEnumKey2 = DefaultSystemAclPolicy.Permit.ToDictionary();

			this.Text = String.Format("{0} {1}", ClientAppContext.Instance.AppName, " Settings");

			try
			{
				// Ribbon Style
				this.ribbonStyle = (RibbonControlStyle)ClientAppContext.Instance.UserSettings.RibbonStyle;

				foreach (var item in this.ribbonStylesByEnumKey)
					this.comboBoxEditRibbonStyle.Properties.Items.Add(item.Value);

				this.comboBoxEditRibbonStyle.EditValue = this.ribbonStylesByEnumKey[this.ribbonStyle];

				// Ribbon Color Sheme
				this.ribbonColorScheme = (RibbonControlColorScheme)ClientAppContext.Instance.UserSettings.RibbonColorScheme;

				foreach (var item in this.ribbonColorSchemeByEnumKey)
					this.comboBoxEditRibbonColorSheme.Properties.Items.Add(item.Value);

				this.comboBoxEditRibbonColorSheme.EditValue = this.ribbonColorSchemeByEnumKey[this.ribbonColorScheme];

				// Ribbon Skin
				foreach (SkinContainer skin in SkinManager.Default.Skins)
					this.comboBoxEditRibbonSkin.Properties.Items.Add(skin.SkinName);

				this.comboBoxEditRibbonSkin.EditValue = ClientAppContext.Instance.UserSettings.RibbonSkinName;
				this.checkEditDarkMode_CheckedChanged(null, new EventArgs());

				// Dark Mode
				this.checkEditDarkMode.Checked = ClientAppContext.Instance.UserSettings.DarkMode;

				// Compact View
				this.checkEditCompactView.Checked = ClientAppContext.Instance.UserSettings.CompactUI;

				// System
				//this.checkEditAutoSyncVlanZoneInterfaces.Checked = ClientAppContext.Instance.SystemSettings.AutoSyncVlanZoneNetworksAndVlansWithL3Interfaces;
				this.checkEditShowDevelopmentTab.Checked = ClientAppContext.Instance.UserSettings.ShowDevelopmentTab;

				//foreach (var item in this.defaultAclPoliciesByEnumName)
				//    this.comboBoxEditDefaultAclPolicy.Properties.Items.Add(item.Key);

				//this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1));
				//this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Office 2013", RibbonControlStyle.Office2013, -1));
				//this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Office 2019", RibbonControlStyle.Office2019, -1));
				//this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Mac Office", RibbonControlStyle.MacOffice, -1));
				//this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Tablet Office", RibbonControlStyle.TabletOffice, -1));
				//this.repositoryItemImageComboBoxRibonStyle.Items.Add(new ImageComboBoxItem("Tablet Office Ex", RibbonControlStyle.OfficeUniversal, -1));

				// Datastore
				this.userControlDatastoreSettings.ServerSystemSettings = ServerAppContext.Instance.SystemSettings;
				this.userControlDatastoreSettings.LoadSettings();
				//this.datastoreSettings.DatastoreType = ServerAppContext.Instance.SystemSettings.DatastoreType;
				//this.datastoreSettings.SqlServer = ServerAppContext.Instance.SystemSettings.DatastoreSqlServer;
				//this.datastoreSettings.SqlDatabase = ServerAppContext.Instance.SystemSettings.DatastoreSqlDatabase;
				//this.datastoreSettings.SqlNetworkConnection = ServerAppContext.Instance.SystemSettings.DatastoreSqlNetworkConnection;
				//this.datastoreSettings.SqlNetworkPort = ServerAppContext.Instance.SystemSettings.DatastoreSqlNetworkPort;
				//this.datastoreSettings.SqlConnectByConnectionString = ServerAppContext.Instance.SystemSettings.DatastoreSqlConnectByConnectionString;
				//this.datastoreSettings.SqlConnectionString = ServerAppContext.Instance.SystemSettings.DatastoreSqlConnectionString;
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, ClientAppContext.Instance.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.tabPageGeneral.Focus();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.SetRibbonStyling((RibbonControlStyle)ClientAppContext.Instance.UserSettings.RibbonStyle, (RibbonControlColorScheme)ClientAppContext.Instance.UserSettings.RibbonColorScheme);
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			bool closeForm = true;

			Cursor? currentCursor = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;

			// Administration
			if (this.editorPassword.Text.Length > 0)
			{
				if (this.editorPassword.Text.Length < this.minNumOfPasswdChars)
				{
					closeForm = false;
					XtraMessageBox.Show("Minimum number of password characters is " + this.minNumOfPasswdChars.ToString() + ".", ClientAppContext.Instance.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else if (this.editorPassword.Text == this.editorRetypePassword.Text)
				{
					if (ClientObjectManager.Instance.SystemAdmin is User user && user is not null)
					{
						user.PasswordHash = this.editorPassword.Text;
						//ObjectManager.Instance.SystemAdmin.PasswordHash = AppSecurity.Instance.CreateAdminPasswordHash(this.editorPassword.Text);
						ClientObjectManager.Instance.CommitChanges();
					}
				}
				else
				{
					closeForm = false;
					XtraMessageBox.Show("Entered passwords do not match.", ClientAppContext.Instance.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			if (closeForm)
			{
				try
				{
					// Set Settings
					ClientAppContext.Instance.UserSettings.RibbonStyle = (int)this.ribbonStyle;
					ClientAppContext.Instance.UserSettings.RibbonColorScheme = (int)this.ribbonColorScheme;
					ClientAppContext.Instance.UserSettings.RibbonSkinName = this.comboBoxEditRibbonSkin.EditValue.ToString();
					ClientAppContext.Instance.UserSettings.CompactUI = this.checkEditCompactView.Checked;
					ClientAppContext.Instance.UserSettings.DarkMode = this.checkEditDarkMode.Checked;
					//ClientAppContext.Instance.SystemSettings.AutoSyncVlanZoneNetworksAndVlansWithL3Interfaces = this.checkEditAutoSyncVlanZoneInterfaces.Checked;
					ClientAppContext.Instance.UserSettings.ShowDevelopmentTab = this.checkEditShowDevelopmentTab.Checked;

					this.userControlDatastoreSettings.UpdateSettings();

					// Save Settings
					ClientAppContext.Instance.UserSettings.Save();
					ClientAppContext.Instance.SystemSettings.Save();
					ServerAppContext.Instance.SystemSettings.Save();
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message, ClientAppContext.Instance.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}

			Cursor.Current = currentCursor;

			if (closeForm)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				this.DialogResult = DialogResult.None;
			}
		}

		private void comboBoxEditRibbonStyle_EditValueChanged(object sender, EventArgs e)
		{
			this.ribbonStyle = this.GetRibbonControlStyle();
			this.SetRibbonStyling(this.ribbonStyle, this.ribbonColorScheme);
		}

		private void comboBoxEditRibbonColorSheme_EditValueChanged(object sender, EventArgs e)
		{
			this.ribbonColorScheme = this.GetRibbonColorScheme();
			this.SetRibbonStyling(this.ribbonStyle, this.ribbonColorScheme);
		}

		private void SetRibbonStyling(RibbonControlStyle ribbonStyle, RibbonControlColorScheme colorScheme)
		{
			if (this.ribbon is not null)
			{
				this.ribbon.RibbonStyle = this.ribbonStylesByEnumKey.FirstOrDefault(item => item.Value == this.comboBoxEditRibbonStyle.EditValue.ToString()).Key;
				//this.ribbon.ApplicationIcon = (this.ribbon.RibbonStyle == RibbonControlStyle.Office2007) ? global::Nubium.Icons.Properties.Resources.Nubium_Large : null;

				//this.comboBoxEditRibbonColorSheme.Enabled = (this.ribbon.RibbonStyle != RibbonControlStyle.Office2007);
				this.ribbon.ColorScheme = colorScheme;
			}
		}

		private RibbonControlStyle GetRibbonControlStyle()
		{
			return this.ribbonStylesByEnumKey.FirstOrDefault(item => item.Value == this.comboBoxEditRibbonStyle.EditValue.ToString()).Key;
		}

		private RibbonControlColorScheme GetRibbonColorScheme()
		{
			return this.ribbonColorSchemeByEnumKey.FirstOrDefault(item => item.Value == this.comboBoxEditRibbonColorSheme.EditValue.ToString()).Key;
		}

		private void checkEditDarkMode_CheckedChanged(object? sender, EventArgs e)
		{
			this.comboBoxEditRibbonSkin.Enabled = !this.checkEditDarkMode.Checked;
			this.labelControlRibbonSkin.Enabled = this.comboBoxEditRibbonSkin.Enabled;
		}

		private void checkEditShowDevelopmentTab_CheckedChanged(object sender, EventArgs e)
		{
		}
	}
}
