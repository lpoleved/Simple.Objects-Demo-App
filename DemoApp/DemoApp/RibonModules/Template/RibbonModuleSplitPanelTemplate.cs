using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Simple.Objects.Controls;
using DemoApp.AppContext;
using System.Threading;

namespace DemoApp
{
    public partial class RibbonModuleSplitPanelTemplate : SimpleRibbonModuleSplitPanel
    {
        public RibbonModuleSplitPanelTemplate()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            base.OnStart();

            this.graphController.ObjectManager = ClientObjectManager.Instance;
			this.graphController.AppName = ClientAppContext.Instance.AppName;
		}
    }
}
