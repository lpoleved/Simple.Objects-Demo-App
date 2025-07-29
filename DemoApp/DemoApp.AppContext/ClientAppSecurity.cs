using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
//using System.Management;
using Simple.AppContext;
using Simple.Security;

namespace DemoApp.AppContext
{
    public class ClientAppSecurity : AppSecurity
    {
        private string formMainText = "Demo App";

        public ClientAppSecurity(ClientAppContext appContext)
			: base(appContext)
        {
        }

		public new ClientAppContext AppContext
		{
			get { return base.AppContext as ClientAppContext; }
		}

		public int LicensedNumberOfNodes { get; private set; }

        public string GetFormMainText()
        {
            return this.formMainText;
        }
	}
}
