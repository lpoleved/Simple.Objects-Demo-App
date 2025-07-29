using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Modeling;
using Simple.Objects;

namespace DemoApp.Objects
{
	public class UserGroupModel : SimpleObjectModel<UserGroup, UserGroupPropertyModel, UserGroupModel>, ISimpleObjectModel
	{
		public UserGroupModel() : base(Tables.UserGroups)

		{
			this.SortingModel = SortingModel.BySingleObjectTypeCollection;
			
			//this.MustHaveGraphElementGraphKey = (int)GraphKey.UserGroups;
			this.UpdateValidationRules.Add(new ValidationRuleExistance(PropertyModel.Name));
			this.UpdateValidationRules.Add(new ValidationRuleUnique(PropertyModel.Name, (simpleObject) => (simpleObject.Manager as ObjectManager)!.UserGroups!));
			this.UpdateValidationRules.Add(new ValidationRuleCustom(PropertyModel.Name, (so, tra) => !(so.Id == 1 && so.GetChangedPropertyIndexes().Contains(UserGroupModel.PropertyModel.Name.PropertyIndex)), "Administrators group name cannot be changed."));
			this.DeleteValidationRules.Add(new ValidationRuleCustom((so, tra) => !(so.Id == 1), "Administrators group is predefined and cannot be deleted."));
		}
	}

	public class UserGroupPropertyModel : SimpleObjectPropertyModelBase
	{
		public PM PreviousId = new PreviousIdPM<long>(1);
		public PM Name				 = new PM<string>(2);
		public PM Description		 = new PM<string>(3);
		public PM Disabled			   = new PM<bool>(4);
		public PM CodePage				= new PM<int>(5);
		public PM DefaultGraphPolicy    = new PM<int>(6);
		public PM DefaultObjectPolicy	= new PM<int>(7);

		public PM OrderIndex = new OrderIndexPM();
	}
}