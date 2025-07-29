using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DemoApp.AppContext;

namespace DemoApp
{
    public partial class FormStatistics : XtraForm
    {
        public FormStatistics()
        {
            InitializeComponent();

            this.Name = ClientAppContext.Instance.AppName + " Statistics";

            this.labelControlNumberOfUsers.Text = ClientObjectManager.Instance.Users.Count.ToString();
            this.labelControlNumberOfUserGroups.Text = ClientObjectManager.Instance.UserGroups.Count.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
