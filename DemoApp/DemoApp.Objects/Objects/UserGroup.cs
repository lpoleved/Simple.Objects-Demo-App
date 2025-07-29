using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Modeling;
using Simple.Objects;

namespace DemoApp.Objects
{
	public partial class UserGroup : UserObject
	{
		public UserGroup(SimpleObjectManager objectManager)
			: base(objectManager)
		{
		}

		protected override SimpleObjectCollection GetSortingCollection()
		{
			return (this.Manager as ObjectManager).UserGroups;
		}
	}
}
