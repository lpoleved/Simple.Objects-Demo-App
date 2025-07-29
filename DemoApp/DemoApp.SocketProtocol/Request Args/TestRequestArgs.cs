using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple.Serialization;
using Simple.SocketEngine;

namespace DemoApp.SocketProtocol
{
	public class TestRequestArgs : SerializableObject, ISerializable
	{
		public override void WriteTo(SerialWriter writer, object? context)
		{
			throw new NotImplementedException();
		}

		public override void ReadFrom(SerialReader reader, object? context)
		{
			throw new NotImplementedException();
		}
	}
}
