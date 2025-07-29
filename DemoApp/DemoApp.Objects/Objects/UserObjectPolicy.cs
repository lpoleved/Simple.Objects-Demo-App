using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Modeling;
using Simple.Objects;

namespace DemoApp.Objects
{
    public partial class UserObjectPolicy : SortableSimpleObject
    {
		public UserObjectPolicy(SimpleObjectManager objectManager)
			: base(objectManager)
		{
		}

		protected override SimpleObjectCollection? GetSortingCollection() => null;

		public SimpleObject? SimpleObject
		{	
			get => this.Manager.GetObject(this.ObjectTableId, this.ObjectId);

			set
			{
				if (value != null)
				{
					this.ObjectTableId = value.GetModel().TableInfo.TableId;
					this.ObjectId = value.Id;
				}
				else
				{
					this.ObjectTableId = 0;
					this.ObjectId = 0;
				}
			}
		}
	}
}
