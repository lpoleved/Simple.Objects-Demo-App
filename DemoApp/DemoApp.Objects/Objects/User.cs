using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.Modeling;
using Simple.Objects;

namespace DemoApp.Objects
{
    public partial class User : UserObject, IUser
    {
        public User(SimpleObjectManager objectManager)
            : base(objectManager)
        {
        }

		protected override SimpleObjectCollection GetSortingCollection()
		{
            return (this.Manager as ObjectManager)!.Users!;
		}

        public Encoding CharacterEncoding => (this.CodePage == 0) ? Encoding.UTF8 : Encoding.GetEncoding(this.CodePage);

		public override string? GetName()
		{
			return this.FirstName + " " + this.LastName;
		}
	}
}
