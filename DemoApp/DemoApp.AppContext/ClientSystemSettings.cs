using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Security;

namespace DemoApp.AppContext
{
	public class ClientSystemSettings : Simple.AppContext.ClientSystemSettings
	{
		public const string SettingTest = "Test";

		public ClientSystemSettings(string filePath)
			: base(filePath)
		{
		}

		public string Test
		{
			get { return this.GetValue<string>(SettingTest, defaultValue: "Test"); }
			set { this.SetValue(SettingTest, value); }
		}
	}
}
