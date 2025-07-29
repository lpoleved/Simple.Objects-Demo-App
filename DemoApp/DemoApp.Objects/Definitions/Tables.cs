using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Datastore;
using Simple.Objects;

namespace DemoApp.Objects
{
	public class Tables : SystemTablesBase
	{
		// SimpleObject Tables
		public static new TableInfo GraphElements	  = new TableInfo(1);
		public static new TableInfo GroupMembership   = new TableInfo(2);
		public static new TableInfo Folders			  = new TableInfo(3);

		// Administration & Security Access
		public static TableInfo Users				  = new TableInfo(4);
		public static TableInfo UserGroups			  = new TableInfo(5);
		public static TableInfo UserGraphPolicy		  = new TableInfo(6);
		public static TableInfo UserObjectPolicy	  = new TableInfo(7);
		public static TableInfo UserGroupGraphPolicy  = new TableInfo(8);
		public static TableInfo UserGroupObjectPolicy = new TableInfo(9);
	}
}
