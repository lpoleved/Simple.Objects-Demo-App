using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
//using System.Management;
//using Simple.AppContext;
using Simple.Security;

namespace DemoApp.AppContext
{
    public class ServerAppSecurity : AppSecurity
    {
		private string formMainText = "Licensed";

        public ServerAppSecurity(ServerAppContext appContext)
			: base(appContext)
        {
        }

        public new ServerAppContext AppContext
		{
			get { return base.AppContext as ServerAppContext; }
		}

        public string GetFormMainText()
        {
            return this.formMainText;
        }

        public void SetLicensing()
		{
            // Put any licensing requrements here
		}
    }
}
