using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Simple.Objects;
using Simple.SocketEngine;
using Simple.Objects.SocketProtocol;

namespace DemoApp.SocketProtocol
{
	public class DemoAppClient : SimpleObjectClient
	{
		public DemoAppClient(SimpleObjectManager objectManager)
			: base(objectManager)
		{
		}

		protected override PackageArgsFactory CreatePackageArgsFactory() => new PackageArgsFactory(Assembly.GetExecutingAssembly()).AddSimpleObjectAssembly();
	}
}
