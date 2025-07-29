using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Objects;

namespace DemoApp.Objects
{
	public class RelationPolicyModel : RelationPolicyModelBase, IRelationPolicyModel
    {
		//public static readonly OneToManyRelationModel OneToManyUserPolicyToUserObject = new OneToManyRelationModel()
		//{
		//	PrimaryObjectType = typeof(UserObject),
		//	//PrimaryObjectAllowedTypes = new Type[] { typeof(User), typeof(UserGroup) },
		//	//PrimaryObjectName = "SourceNetworkObject",
		//	ForeignObjectType = typeof(UserPolicy),
		//	ForeignCollectionName = "UserPolicies",
		//	//ForeignCollectionSummary = "Gets the foreign User Policy collection.",
		//	PrimaryTableIdPropertyModel = UserPolicyModel.PropertyModel.UserObjectTableId,
		//	PrimaryObjectIdPropertyModel = UserPolicyModel.PropertyModel.UserObjectId,
		//	CascadeDelete = true
		//};

		// One To Many Relations

		public static readonly OneToManyRelationModel OneToManyUserGraphPolicyToUser = new OneToManyRelationModel()
		{
			ForeignObjectType = typeof(UserGraphPolicy),
			ForeignCollectionName = "UserGraphPolicies",
			PrimaryObjectType = typeof(User),
			PrimaryObjectIdPropertyModel = UserGraphPolicyModel.PropertyModel.UserId,
			CascadeDelete = true,
		};

		public static readonly OneToManyRelationModel OneToManyUserObjectPolicyToUser = new OneToManyRelationModel()
		{
			ForeignObjectType = typeof(UserObjectPolicy),
			ForeignCollectionName = "UserObjectPolicies",
			PrimaryObjectType = typeof(User),
			PrimaryObjectIdPropertyModel = UserObjectPolicyModel.PropertyModel.UserId,
			CascadeDelete = true,
		};


		public static readonly OneToManyRelationModel OneToManyUserGroupGraphPolicyToUserGroup = new OneToManyRelationModel()
		{
			ForeignObjectType = typeof(UserGroupGraphPolicy),
			ForeignCollectionName = "UserGroupGraphPolicies",
			PrimaryObjectType = typeof(UserGroup),
			PrimaryObjectIdPropertyModel = UserGroupGraphPolicyModel.PropertyModel.UserGroupId,
			CascadeDelete = true,
		};

		public static readonly OneToManyRelationModel OneToManyUserGroupObjectPolicyToUserGroup = new OneToManyRelationModel()
		{
			ForeignObjectType = typeof(UserGroupObjectPolicy),
			ForeignCollectionName = "UserGroupObjectPolicies",
			PrimaryObjectType = typeof(UserGroup),
			PrimaryObjectIdPropertyModel = UserGroupObjectPolicyModel.PropertyModel.UserGroupId,
			CascadeDelete = true,
		};

		
		// Many To Many Relations

		public static readonly ManyToManyRelationModel ManyToManyUserToUserGroup = new ManyToManyRelationModel()
		{
			RelationKey = (int)ManyToManyRelationKey.UserToUserGroup,
			FirstObjectType = typeof(User),
			SecondObjectType = typeof(UserGroup)
		};
	}
}
