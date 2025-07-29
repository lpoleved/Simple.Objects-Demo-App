using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Controls;
using Simple.Objects.Controls;
using DemoApp.Objects;
using DemoApp.AppContext;

namespace DemoApp
{
	public class RibbonModulePolicyDefinition : RibbonModulePolicyDefinitionTemplate<RibbonModulePolicyDefinition>
	{
		public RibbonModuleModel Home, Users, UserGroups;
		public RibbonModuleGroupModel GroupUserPolicy;

		public RibbonModulePolicyDefinition()
		{
			//this.Home = new RibbonModuleModel(typeof(RibbonModuleHome), (int)GraphKey.Empty, "Home");
			this.Users = new RibbonModuleModel(typeof(RibbonModuleUsers), (int)GraphKey.Users, "Users");
			this.UserGroups = new RibbonModuleModel(typeof(RibbonModuleUserGroups), (int)GraphKey.UserGroups, "UserGroups", "User Groups");

			this.GroupUserPolicy = new RibbonModuleGroupModel("GroupUserPolicy", "User Policy");

			this.AddRibbonModuleModel(this.Home);
			this.AddRibbonModuleModel(this.Users);
			this.AddRibbonModuleModel(this.UserGroups);


			this.Users = new RibbonModuleModel(typeof(RibbonModuleUsers), (int)GraphKey.Users, "Users");
			this.UserGroups = new RibbonModuleModel(typeof(RibbonModuleUserGroups), (int)GraphKey.UserGroups, "UserGroups", "User Groups");

			this.GroupUserPolicy = new RibbonModuleGroupModel("GroupUserPolicy", "User Policy");

			this.AddRibbonModuleModel(this.Users);
			this.AddRibbonModuleModel(this.UserGroups);

			this.AddRibbonModuleGroupModel(this.GroupUserPolicy);
			this.GroupUserPolicy.AddRibbonModuleModelMembers(this.Users, this.UserGroups);
		}
	}
}
