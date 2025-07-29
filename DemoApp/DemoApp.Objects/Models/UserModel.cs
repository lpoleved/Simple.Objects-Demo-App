using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Modeling;
using Simple.Objects;

namespace DemoApp.Objects
{
	public class UserModel : SimpleObjectModel<User, UserPropertyModel, UserModel>, ISimpleObjectModel
	{
		protected override void Initialize()
		{
			this.TableInfo = Tables.Users;
			//this.MustHaveGraphElementGraphKey = (int)GraphKey.Users;
			this.SortingModel = SortingModel.BySingleObjectTypeCollection;
			this.NamePropertyModel = PropertyModel.Username;

			this.UpdateValidationRules.Add(new ValidationRuleExistance(PropertyModel.Username));
			this.UpdateValidationRules.Add(new ValidationRuleUnique(PropertyModel.Username, (simpleObject) => (simpleObject.Manager as ObjectManager)!.Users!));
			this.UpdateValidationRules.Add(new ValidationRuleExistance(PropertyModel.PasswordHash));
			this.UpdateValidationRules.Add(new ValidationRuleCustom(PropertyModel.FirstName, (so, tra) => !(so.Id == 1 && so.GetChangedPropertyIndexes().Contains(UserModel.PropertyModel.FirstName.PropertyIndex)), "System Admin first name cannot be changed."));
			this.UpdateValidationRules.Add(new ValidationRuleCustom(PropertyModel.LastName, (so, tra) => !(so.Id == 1 && so.GetChangedPropertyIndexes().Contains(UserModel.PropertyModel.LastName.PropertyIndex)), "System Admin last name cannot be changed."));
			this.UpdateValidationRules.Add(new ValidationRuleCustom(PropertyModel.Username, (so, tra) => !(so.Id == 1 && so.GetChangedPropertyIndexes().Contains(UserModel.PropertyModel.Username.PropertyIndex)), "System Admin username cannot be changed."));
			this.DeleteValidationRules.Add(new ValidationRuleCustom((so, tra) => !(so.Id == 1), "System Admin is predefined and cannot be changed or deleted."));
		}
	}

	public class UserPropertyModel : SimpleObjectPropertyModelBase
	{
		public PM PreviousId				 = new PreviousIdPM<long>( 1);
		public PM Description						 = new PM<string>( 2);
		public PM FirstName							 = new PM<string>( 3) { Caption = "First Name" };
		public PM LastName							 = new PM<string>( 4) { Caption = "Last Name" };
		public PM Username							 = new PM<string>( 5);
		public PM PasswordHash						 = new PM<string>( 6) { IsEncrypted = true, IsServerToClientSeriazable = false };
		public PM Location							 = new PM<string>( 7);
		public PM Disabled							   = new PM<bool>( 8);
		public PM CodePage								= new PM<int>( 9);
		public PM DefaultGraphPolicy  = new PM<DefaultSecurityPolicy>(10) { DefaultValue = DefaultSecurityPolicy.SystemDefault };
		public PM DefaultObjectPolicy = new PM<DefaultSecurityPolicy>(11) { DefaultValue = DefaultSecurityPolicy.SystemDefault };

		public PM OrderIndex = new OrderIndexPM();
	}
}