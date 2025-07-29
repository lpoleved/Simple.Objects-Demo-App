using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Objects;

namespace DemoApp.Objects
{
	public partial class UserGroupGraphPolicy : SimpleObject
	{
		public UserGroupGraphPolicy(SimpleObjectManager objectManager)
			: base(objectManager)
		{
		}


		// TODO: GraphElerment

		public GraphElement GraphElement
		{
			get;
			set;
		}
    }
}
