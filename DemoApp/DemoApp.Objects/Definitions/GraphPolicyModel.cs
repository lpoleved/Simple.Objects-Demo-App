using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Objects;

namespace DemoApp.Objects
{
    public class UsersGraphPolicyModel : SingleGraphPolicyModel
    {
        public UsersGraphPolicyModel()
            : base(DemoApp.Objects.GraphKey.Users)
        {
        }

        public GraphPolicyModelElement Folder = new GraphPolicyModelElement(typeof(Folder)) { SubTreePolicy = SubTreePolicy.AllowSubTree };
        public GraphPolicyModelElement User   = new GraphPolicyModelElement(typeof(User));
    }

    public class UserGroupsGraphPolicyModel : SingleGraphPolicyModel
    {
        public UserGroupsGraphPolicyModel()
            : base(DemoApp.Objects.GraphKey.UserGroups)
        {
        }

        public GraphPolicyModelElement Folder     = new GraphPolicyModelElement(typeof(Folder)) { SubTreePolicy = SubTreePolicy.AllowSubTree };
        public GraphPolicyModelElement UserGroups = new GraphPolicyModelElement(typeof(UserGroup));
    }
}
