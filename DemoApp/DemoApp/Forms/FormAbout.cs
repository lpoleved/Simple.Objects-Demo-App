using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;
using DemoApp.AppContext;

namespace DemoApp
{
    public partial class FormAbout : XtraForm
    {
        #region |   Private Members   |

        private Assembly aboutAssembly;

        #endregion

        #region |   Constructors and Initialization   |

        public FormAbout()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            this.memoEditDescription.DeselectAll();
            this.memoEditDescription.Focus();
            this.pictureEdit.Focus();
            this.Focus();
        }

        #endregion

        #region |   Public Methods  |

        public void SetData(string caption, string productName, string version, string copyright, string license, string serialNumber, string numberOfNodes, string description)
        {
            this.Text = caption;
            this.labelProductName.Text = productName;
            this.labelVersion.Text = String.Format("{0} ({1}-bit)", version, (IntPtr.Size * 8));
            this.labelCopyright.Text = copyright;
            this.labelLicence.Text = license;
            this.labelSerialNumber.Text = serialNumber;
            this.labelNumberOfNodes.Text = numberOfNodes;
            this.memoEditDescription.Text = description;
        }

        #endregion

        #region |   Assembly Attribute Accessors   |

        [Browsable(false)]
        public Assembly AboutAssembly
        {
            set { this.aboutAssembly = value; }
        }

        [Browsable(false)]
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = this.aboutAssembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(aboutAssembly.CodeBase);
            }
        }

        [Browsable(false)]
        public string AssemblyVersion
        {
            get
            {
                return aboutAssembly.GetName().Version.ToString();
            }
        }

        [Browsable(false)]
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = this.aboutAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        [Browsable(false)]
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = this.aboutAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        [Browsable(false)]
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = this.aboutAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        [Browsable(false)]
        public string AssemblyCompany
        {
            get
            {
                object[] attributes = this.aboutAssembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        #region |   Static Methods  |

        public static DialogResult ShowMe()
        {
            return ShowMe(Assembly.GetExecutingAssembly());
        }

        public static DialogResult ShowMe(Assembly assembly)
        {
            FormAbout frm = new FormAbout();
            frm.AboutAssembly = assembly;
            frm.Text = String.Format("About {0}", frm.AssemblyTitle);
            frm.labelProductName.Text = frm.AssemblyProduct;
            frm.labelVersion.Text = String.Format("Version {0}", frm.AssemblyVersion);
            frm.labelCopyright.Text = frm.AssemblyCopyright;
            frm.labelLicence.Text = frm.AssemblyCompany;
            frm.memoEditDescription.Text = frm.AssemblyDescription;

            return frm.ShowDialog();
        }

        public static DialogResult ShowMe(string caption, string productName, string version, string copyright, string licencedTo, string serialNumber, string numberOfNodes, string description)
        {
            FormAbout frm = new FormAbout();
            
            frm.SetData(caption, productName, version, copyright, licencedTo, serialNumber, numberOfNodes, description);
            
            return frm.ShowDialog();
        }

        public static DialogResult ShowAbout()
        {
            string caption = "About";

            string productName = ClientAppContext.Instance.AppName;
            string version = "Version: " + ClientAppContext.Instance.Version;
            string copyright = ClientAppContext.Instance.Copyright;
            string serialNumber = "Serial Number: XXXX-XXXX-XXXX-XXXX";
            string license = "License: Free";
            string numberOfNodes = "Number of Nodes: Unlimited";
            string description = 
                "Application is designed for MS Windows operating systems and tested on:\r\n" +
				"- (32b) Windows 8, 7\r\n" +
				"- (64b) Windows 10, 8, 7, Windows Server 2012, 2016, 2019 \r\n\r\n" +
				"Acknowledgement:\r\n" +
				"Super Socket:  http://www.supersocket.net/" + "\r\n" +
				"SNMP#Net:  http://www.snmpsharpnet.com" + "\r\n" +
				"Smart Thread Pool:  http://smartthreadpool.codeplex.com" + "\r\n" +
				"HtmlAgilityPack:  http://htmlagilitypack.codeplex.com" + "\r\n" +
				"log4net:  http://logging.apache.org/log4net";

            FormAbout frm = new FormAbout();
            
            frm.SetData(caption, productName, version, copyright, license, serialNumber, numberOfNodes, description);

            return frm.ShowDialog();


        }

		#endregion
	}
}
