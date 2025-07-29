using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Modeling;
using Simple.Objects;

namespace DemoApp.Objects
{
	public class UserGroupGraphPolicyModel : SimpleObjectModel<UserGroupGraphPolicy, UserGroupGraphPolicyPropertyModel, UserGroupGraphPolicyModel>, ISimpleObjectModel
    {
        public UserGroupGraphPolicyModel() : base(Tables.UserGroupGraphPolicy)
		{
			//this.UpdateValidationRules.Add(new ValidationRuleExistance(PropertyModel.Name));
   //         this.UpdateValidationRules.Add(new ValidationRuleUnique(PropertyModel.Name));
        }
    }

	public class UserGroupGraphPolicyPropertyModel : SimpleObjectPropertyModelBase
	{
		public PM PreviousId	 = new PreviousIdPM<long>(1);
		public PM UserGroupId			   = new PM<long>(2);
		public PM GraphElementId		   = new PM<long>(3);
		public PM GraphKey				    = new PM<int>(4);
		public PM PolicyRights = new PM<UserPolicyRights>(5) { DatastoreType = typeof(int) };

		public PM OrderIndex = new OrderIndexPM();
	}
}
