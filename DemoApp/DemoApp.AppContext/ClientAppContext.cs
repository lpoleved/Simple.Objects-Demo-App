using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Text;
//using System.Management;
using System.Security.Cryptography;
using Microsoft.Win32;
using Simple.AppContext;
using Simple.Security;

namespace DemoApp.AppContext
{
    public class ClientAppContext : ClientAppContextBase, IClientAppContext
    {
		private ClientAppSecurity security = null;

        static ClientAppContext()
		{
			Instance = new ClientAppContext();
		}

		public ClientAppContext()
        {
			this.AppName = "Demo App™";
			this.Copyright = "Copyright © 2024 by Simple.Objects.  All Rights Reserved.";
        }

		public string GetFormMainText()
        {
			return this.Security.GetFormMainText();
        }

		public static ClientAppContext Instance { get; private set; }

        public ClientAppSecurity Security
		{
			get
			{
				if (this.security == null)
					this.security = new ClientAppSecurity(this);

				return security;
			}
		}

		public ClientSystemSettings SystemSettings
        {
			get { return base.GetSystemSettings<ClientSystemSettings>(); }
        }

		public new ClientUserSettings UserSettings
		{
			get { return base.GetUserSettings<ClientUserSettings>(); }
		}
	}
}
