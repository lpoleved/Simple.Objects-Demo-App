using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Modeling;
using Simple.Objects;

namespace DemoApp.Objects
{
	//[DatastoreTable(DatastoreTableInfo.Folders)]
	public class UserObjectPolicyModel : SimpleObjectModel<UserObjectPolicy, UserPolicyPropertyModel, UserObjectPolicyModel>, ISimpleObjectModel
	{
		public UserObjectPolicyModel() : base(Tables.UserObjectPolicy)
		{
			//this.ValidationRules.Add(new ValidationRuleExistance(PropertyModel.Name));
			//this.ValidationRules.Add(new ValidationRuleUnique(PropertyModel.Name));
		}
	}

	public class UserPolicyPropertyModel : SimpleObjectPropertyModelBase
	{
		public PM PreviousId	 = new PreviousIdPM<long>(1);
		public PM UserId				   = new PM<long>(2);
		public PM ObjectTableId		        = new PM<int>(3);
		public PM ObjectId                 = new PM<long>(4);
		public PM PolicyRights = new PM<UserPolicyRights>(5) { DatastoreType = typeof(int) };

		public PM OrderIndex = new OrderIndexPM();
	}
}
