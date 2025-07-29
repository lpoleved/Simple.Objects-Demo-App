using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Objects;

namespace DemoApp.Objects
{
	public abstract partial class UserObject : SortableSimpleObject
	{
		public UserObject(SimpleObjectManager objectManager)
			: base(objectManager)
		{
		}
	}
}
