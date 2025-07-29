using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using Simple.Objects;

namespace DemoApp.Objects
{
    public class ObjectManager : SimpleObjectManager
    {
        private static byte[] cryptoKey = { 158, 161, 88, 129, 252, 217, 162, 229, 24, 193, 47, 69, 162, 198, 159, 183, 26, 13, 61, 105, 81, 168, 218, 84, 113, 42, 46, 181, 160, 34, 144, 150 };
        private static byte[] cryptoInitializationVector = { 251, 250, 243, 218, 144, 170, 103, 221, 113, 16, 141, 167, 55, 164, 9, 68 };
        public const string SystemAdminUsername = "System Admin";

        public ObjectManager(SimpleObjectModelDiscovery modelDiscovery)
    :       base(modelDiscovery, cryptoKey, cryptoInitializationVector)
        {
        }

		public SimpleObjectCollection<User>? Users => (this.GetObjectCache(UserModel.TableId) as ServerObjectCache)?.GetObjectCollection<User>();
		public SimpleObjectCollection<UserGroup>? UserGroups => (this.GetObjectCache(UserGroupModel.TableId) as ServerObjectCache)?.GetObjectCollection<UserGroup>();

		//public User SystemAdmin
		//{
		//    get
		//    {
		//        if (this.systemAdmin == null)
		//            this.systemAdmin = this.Users.FirstOrDefault(item => item.Username == SystemAdminUsername);

		//        return this.systemAdmin;
		//    }
		//}

		protected override int GetUserModelTableId()
		{
            return UserModel.TableId;
		}

		protected override Type GetGraphKeyEnumType()
        {
            return typeof(GraphKey);
        }

        protected override Type GetManyToManyRelationKeyEnumType()
        {
            return typeof(ManyToManyRelationKey);
        }
    }
}
