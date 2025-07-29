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
using Simple.Datastore;

namespace DemoApp.AppContext
{
    public class ServerAppContext : ServerAppContextBase
    {
		private ServerAppSecurity security = null;

		static ServerAppContext()
		{
			//Instance = new ServerAppContext();
		}

		public ServerAppContext()
        {
			this.AppName = "DemoApp.Server";
			this.Copyright = "Copyright © 2020 My Company.  All Rights Reserved.";

			this.DatastoreUsername = "AppAdmin";
            this.DatastorePassword = "sadj&9#'HlaJgU$(543khgdfkKCMtf(60wJlhls"; ;

			this.SystemSettings.DefaultSqlServerInstanceName = "DemoSQL";
			this.SystemSettings.DefaultDatastoreName = "DemoApp";

			this.EmptyDatastoreFileName = "DemoApp_Empty.bak";
			this.AdminUsername = "System Admin";

			this.UnregisteredExpirationTime = new DateTime(2021, 12, 21);
        }

		public DateTime UnregisteredExpirationTime { get; private set; }

		public string GetFormMainText()
        {
            return this.Security.GetFormMainText();
        }

		public string CreateDatastoreConnectionString()
		{
			string result = null;

			switch (this.SystemSettings.DatastoreType)
			{
				case DatastoreProviderType.SqlServer:

					if (this.SystemSettings.DatastoreSqlConnectByConnectionString)
					{
						result = this.SystemSettings.DatastoreSqlConnectionString;
					}
					else
					{
						SqlServerConnectionStringBuilder sqlServerConnectionStringBuilder = new SqlServerConnectionStringBuilder();

						sqlServerConnectionStringBuilder.Server = this.SystemSettings.DatastoreSqlServer;
						sqlServerConnectionStringBuilder.Database = this.SystemSettings.DatastoreSqlDatabase;
						sqlServerConnectionStringBuilder.Username = this.DatastoreUsername;
						sqlServerConnectionStringBuilder.Password = this.DatastorePassword;
						sqlServerConnectionStringBuilder.NetworkConnection = this.SystemSettings.DatastoreSqlNetworkConnection;
						sqlServerConnectionStringBuilder.NetworkPort = this.SystemSettings.DatastoreSqlNetworkPort;
						sqlServerConnectionStringBuilder.TrustedConnection = true;

						result = sqlServerConnectionStringBuilder.BuildConnectionString();
					}

					break;

				case DatastoreProviderType.OfficeAccess:

					OfficeAccessConnectionStringBuilder officeAccessConnectionStringBuilder = new OfficeAccessConnectionStringBuilder();
					officeAccessConnectionStringBuilder.DataSource = this.SystemSettings.DatastoreOfficeAccessFilePath; // + "\\" + this.DefaultDatastoreName + ".mdb";

					result = officeAccessConnectionStringBuilder.BuildConnectionString();

					break;

				//case DatastoreProviderType.FileSystem:
				//	XmlDatastoreConnectionStringBuilder xmlDatastoreConnectionStringBuilder = new XmlDatastoreConnectionStringBuilder();
				//	xmlDatastoreConnectionStringBuilder.DataSourceFolder = this.DefaultDatastoreXmlDataSourceFolder;

				//	result = xmlDatastoreConnectionStringBuilder.BuildConnectionString();
				//	break;
				default:
					throw new NotSupportedException();
			}

			return result;
		}

		public static ServerAppContext Instance = new ServerAppContext(); //{ get; private set; }

        public ServerAppSecurity Security
		{
			get
			{
				if (this.security == null)
					this.security = new ServerAppSecurity(this);

				return security;
			}
		}

		public new ServerSystemSettings SystemSettings
        {
			get { return base.GetSystemSettings<ServerSystemSettings>(); }
        }
    }
}
