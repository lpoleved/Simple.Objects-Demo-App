using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Simple.Objects;
using Simple.Controls;
using Simple.Datastore.Controls;
using Simple.Objects.Controls;
using Simple.AppContext;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DemoApp.Objects;
using DemoApp.AppContext;

namespace DemoApp
{
    public partial class FormMain : SimpleRibbonFormBase
    {
        #region |   Private Members   |

        private const string skinNameBlack = "Black";
        private const string userManualText = "User Manual";
        private string userManualFileName = String.Empty; // <- put user manual file name here!!!
        private const string SettingLastUsername = "LastUsername";
        private const string SettingLastServer = "LastServer";


        private RibbonModuleUsers ribbonModuleUsers = new RibbonModuleUsers();
        private RibbonModuleUserGroups ribbonModuleUserGroups = new RibbonModuleUserGroups();
        private RibbonModuleDevelopment ribbonModuleDevelopment = null;

        private RibbonPageCategory ribbonPageCategory1 = new RibbonPageCategory("", Color.Magenta, visible: true) { AutoStretchPageHeaders = true };

        #endregion |   Private Members   |

        #region |   Constructors and Initialization   |

        public FormMain()
        {
            this.ObjectManager = Program.ObjectManager;
            this.AppContext = ClientAppContext.Instance;
            
            this.InitializeComponent();

            this.Text = ClientAppContext.Instance.GetFormMainText();

            string username = ClientAppContext.Instance.UserSettings.GetValue<string>(SettingLastUsername, this.ObjectManager.SystemAdmin.Username);
            string server = ClientAppContext.Instance.UserSettings.GetValue<string>(SettingLastServer, "localhost");


            this.barStaticItemUser.Caption = username;
            this.barStaticItemNetServer.Caption = server + " - Connected";

            this.userManualFileName = String.Format("{0} {1}.pdf", ClientAppContext.Instance.AppName, userManualText);

            base.Ribbon = this.ribbonMain;
            base.Panel = this.panelMain;

            base.BarSubItemChangeSkin = this.barSubItemChangeSkin;
            this.barSubItemChangeSkin.Enabled = !this.AppContext.UserSettings.DarkMode;

            //this.Ribbon.RibbonStyle = (RibbonControlStyle)this.AppContext.UserSettings.RibbonStyle;
            this.Ribbon.ColorScheme = (RibbonControlColorScheme)this.AppContext.UserSettings.RibbonColorScheme;
            this.SetSkinStyle();

            this.undoManager.ObjectManager = this.ObjectManager;
			this.ribbonModuleDevelopment = new Simple.Objects.Controls.RibbonModuleDevelopment(this.ObjectManager, ClientAppContext.Instance);

			SimpleRibbonModulePanel ribbonModuleEmpty = new SimpleRibbonModulePanel();

#if (DEBUG)
			this.ribbonModuleDevelopment.ShowCodeGenerator = false;
#endif
			this.LoadModulePanel((int)GraphKey.Empty, ribbonModuleEmpty);
            base.Initialize();
			this.Ribbon.PageCategories.Add(this.ribbonPageCategory1);

			//#if (DEBUG)
			//			this.ribbonPageCategory.Pages.Add(this.ribbonModuleDevelopment.RibbonPage);
			//			//this.ribbonPageCategory2.Pages.Add(this.ribbonModuleNetworkPolicy.RibbonPage);
			//			this.ribbonPageCategory.Text = "DEBUG";
			//			this.ribbonPageCategory.Visible = true;
			//#endif
			//this.Ribbon.RibbonStyle = (RibbonControlStyle)this.AppContext.UserSettings.RibbonStyle;

			this.ribbonPageCategory1.Pages.Add(this.ribbonModuleDevelopment.RibbonPage);
			//this.ribbonPageCategory2.Pages.Add(this.ribbonModuleNetworkPolicy.RibbonPage);
			this.ribbonPageCategory1.Text = "DEBUG";
			//this.ribbonModuleDevelopment.RibbonPage.Visible = true; // ClientAppContext.Instance.UserSettings.ShowDevelopmentTab;
			this.ribbonPageCategory1.Visible = ClientAppContext.Instance.UserSettings.ShowDevelopmentTab;


			this.ObjectManager.DefaultChangeContainer.RequireCommitChange += DefaultChangeContainer_RequireCommitChange;
			this.barButtonItemSave.Enabled = false;
			this.barButtonItemSave.ItemClick += BarButtonItemSave_ItemClick; ;

			// At start the first page (Inventory) is not initualized and TreeList content is not visible. 
			// So this is the trick to initialize and make visible Inventory ribbon page as first page, by activating page change actions.

			//if (ribbonModuleHome != null)
			//{
			//RibbonModuleHome ribbonModuleHome = new RibbonModuleHome();
			//this.LoadModulePanel((int)GraphKey.Empty, ribbonModuleHome);

			// Force first ribbon page to redraw

			ribbonModuleEmpty.Visible = false;
			ribbonModuleEmpty.Hide();

			this.Ribbon.SelectedPage = this.Ribbon.Pages[1]; // Inventory
															 //this.lastSelectedRibbonPage = this.Ribbon.SelectedPage;
			this.UnloadModulePanel(ribbonModuleEmpty);
        }

        #endregion |   Constructors and Initialization   |

        #region |   Public Properties    |

        public ClientObjectManager ObjectManager { get; private set; }

        #endregion |   Public Properties    |

        #region |   Protected Methods    |

        protected override void LoadModulePanels()
		{
            this.LoadModulePanel((int)GraphKey.Users, this.ribbonModuleUsers);
            this.LoadModulePanel((int)GraphKey.UserGroups, this.ribbonModuleUserGroups);
			this.LoadModulePanel(-1, this.ribbonModuleDevelopment);

//#if (DEBUG)
//			this.LoadModulePanel(-1, this.ribbonModuleDevelopment);
//#endif
        }

        //protected override void OnSkinStyleChange(string skinName)
        //{
        //    base.OnSkinStyleChange(skinName);

        //    if (!ClientAppContext.Instance.UserSettings.DarkMode)
        //    {
        //        ClientAppContext.Instance.UserSettings.RibbonSkinName = skinName;
        //        ClientAppContext.Instance.UserSettings.Save();
        //    }
        //}

        protected override bool OnFormClosing()
        {
            bool closing = base.OnFormClosing();

            if (closing)
            {
                Cursor? currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    if (Program.AppClient != null && Program.AppClient.IsConnected)
                        _ = Program.AppClient.CloseAsync();
                }
                catch
                {
                }
                finally
                {
                    Cursor.Current = currentCursor;
                }
            }

            return closing;

		}

		#endregion |   Protected Methods    |

		#region |   Menu Events    |

		private void DefaultChangeContainer_RequireCommitChange(object sender, Simple.Objects.RequireCommiChangeContainertEventArgs e)
        {
            this.barButtonItemSave.Enabled = e.RequireCommit;
        }

        private void BarButtonItemSave_ItemClick(object sender, ItemClickEventArgs e)
        {
			TransactionResult transactionResult = this.ObjectManager.CommitChanges();

			if (!transactionResult.TransactionSucceeded)
			{
				if (transactionResult.ValidationErrorResult != null)
				{
					if (!transactionResult.ValidationErrorResult.IsValidationErrorFormShown)
					{
						string caption = transactionResult.ValidationErrorResult.ValidationType.ToString() + " Validation Error";

						XtraMessageBox.Show(transactionResult.ValidationErrorResult.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						transactionResult.ValidationErrorResult.IsValidationErrorFormShown = true;
					}
				}
				else
				{
					XtraMessageBox.Show(transactionResult.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private void menuItemHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.barButtonItemUserManual_ItemClick(sender, e);
        }

        private void menuItemVersionHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void barButtonHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.barButtonItemUserManual_ItemClick(sender, e);
        }

        private void barButtonSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormSettings formSettings = new FormSettings(this.ribbonMain);
            DialogResult formSettingsDialogResult = formSettings.ShowDialog();

            if (formSettingsDialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;

				this.ribbonPageCategory1.Visible = ClientAppContext.Instance.UserSettings.ShowDevelopmentTab;

				//this.Ribbon.RibbonStyle = (RibbonControlStyle)this.AppContext.UserSettings.RibbonStyle;
				//this.Ribbon.ColorScheme = (RibbonControlColorScheme)this.AppContext.UserSettings.RibbonColorScheme;
				this.SetSkinStyle();
				this.Ribbon.Refresh();

				this.barSubItemChangeSkin.Enabled = !this.AppContext.UserSettings.DarkMode;

                Cursor.Current = currentCursor;
            }
		}

		private void barButtonItemStatistics_ItemClick(object sender, ItemClickEventArgs e)
        {
			Cursor? currentCursor = Cursor.Current;
			this.Cursor = Cursors.WaitCursor;

			FormStatistics formStatistics = new FormStatistics();

			this.Cursor = currentCursor;

			formStatistics.ShowDialog();
		}

		private void barButtonItemUserManual_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Process.Start(this.userManualFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ClientAppContext.Instance.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
			Cursor? currentCursor = Cursor.Current;

			this.Cursor = Cursors.WaitCursor;

			XtraForm formAbout = new FormAbout();

			this.Cursor = currentCursor;

			formAbout.ShowDialog();
		}

		#endregion |   Menu Events    |
	}
}