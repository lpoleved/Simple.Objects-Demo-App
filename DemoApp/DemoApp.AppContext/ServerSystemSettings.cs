using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Datastore;

namespace DemoApp.AppContext
{
    public class ServerSystemSettings : Simple.AppContext.ServerSystemSettings
    {
        public ServerSystemSettings(string filePath)
            : base(filePath)
        {
        }

		public new DatastoreProviderType DatastoreType => (DatastoreProviderType)base.DatastoreType;
	}
}
