using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Security;

namespace DemoApp.AppContext
{
	public class ClientUserSettings : Simple.AppContext.UserSettings
	{
		public const string SettingShowDevelopmentTab = "ShowDevelopmentTab";

		public ClientUserSettings(string filePath)
			: base(filePath)
		{
			this.DefaultRibonSkinName = "Black";
		}

		public bool ShowDevelopmentTab
		{
			get { return this.GetValue<bool>(SettingShowDevelopmentTab, defaultValue: false); }
			set { this.SetValue(SettingShowDevelopmentTab, value, defaultValue: false); }
		}
	}
}
