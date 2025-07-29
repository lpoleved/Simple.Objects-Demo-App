using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.SocketEngine;
using Simple.Serialization;
using Simple.Objects;
using Simple.Objects.SocketProtocol;
using DemoApp.SocketProtocol;
using System.Reflection;

namespace DemoApp.SocketProtocol
{
	public class DemoAppServer : SimpleObjectServer
	{
		public DemoAppServer(SimpleObjectManager objectManager)
			: base(objectManager)
		{
		}

		public override Version AppServerVersion =>  new Version(0, 0);

		protected override PackageArgsFactory CreatePackageArgsFactory() => new PackageArgsFactory(Assembly.GetExecutingAssembly()).AddSimpleObjectAssembly();

		#region |   App Request Responses   |

		[RequestCommand((int)AppRequest.Test)]
		public ISerializable Discover(SimpleSession session, SerialReader reader)
		{
			var args = new TestRequestArgs();

			// TODO:

			return new TestResponseArgs();
		}

		#endregion |   App Request Responses   |
	}
}
