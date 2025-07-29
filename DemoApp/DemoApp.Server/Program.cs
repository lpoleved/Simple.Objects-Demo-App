using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;
using System.IO;
using System.Diagnostics;
//using Simple;
//using Simple.Objects;
//using Simple.Datastore.Controls;
//using Nubium.Services;

namespace DemoApp
{
	class Program
	{
		//private const string sqlServerSaPassword = "Dog3soUr6akR";
		//private const int startMonitorDelay = 10000;

  //      public static AppContext AppContext = null;
  //      public static SimpleObjectModelDiscovery ModelDiscovery = null;
  //      public static DatastoreProvider LocalDatastore = null;
		//public static ObjectManager ObjectManager = null;
  //      public static NetManagerServer NetManagerServer = null;
  //      public static MonitorEngine MonitorEngine = null;

		static async void Main(string[] args)
		{
			await DemoApp.Server.StartAsync();

			
			//// Object Manager class initialization
			////try
			////{
			//	Console.WriteLine("System initialization started...");

			//	AppContext = AppContext.Instance;
			//	AppContext.AppName = "Nubium Server";
			//	AppContext.Version = Assembly.GetEntryAssembly().GetName().Version;
			//	AppContext.Copyright = "Copyright © 2024 NETAKOD Community.  All Rights Reserved.";

   //             ModelDiscovery = new SimpleObjectModelDiscovery();
   //             LocalDatastore = new DatastoreProvider();
			//	ObjectManager = new ObjectManager(ModelDiscovery, LocalDatastore);
   //             MonitorEngine = new MonitorEngine(ObjectManager);
   //             NetManagerServer = new NetManagerServer(ObjectManager);

			//	Console.WriteLine("System initialization succeeded.");
			////}
			////catch (Exception ex)
			////{
			////	ConsoleExit("System initialization Error: " + ExceptionHelper.GetFullErrorMessage(ex)); 
			////	return;
			////}

			//// Connecting to datastore...
			//if (!TryConnectToDatastore(LocalDatastore, AppContext))
			//{
			//	ConsoleExit("");
			//	return;
			//}

			//// Initializing datastore objects...
			//try
			//{
			//	Console.WriteLine("Initializing Datastore Objects...");
			//	ObjectManager.InitializeLocalDatastore();
			//}
			//catch (Exception ex)
			//{
			//	ConsoleExit("Error Initializing Datastore Objects: " + ExceptionHelper.GetFullErrorMessage(ex));
			//	return;
			//}

			//AppContext.Instance.Security.SetLicensing();

			//// TODO: TryToConnectToLogDatastore...

			//// Start monitoring, if required.
			//if (AppContext.SystemSettings.MonitorDevices)
			//{
			//	Console.WriteLine("Starting Monitoring Service...");
   //             MonitorEngine.Start(startMonitorDelay);
			//}

			//Console.WriteLine(String.Format("Starting Object Manager Service on port {0}...", NetManagerServer.Port));
   //         NetManagerServer.Start();

   //         Console.WriteLine("\r\nStarting Client...\r\n");
   //         Thread thread = new Thread(() => Nubium.SocketProtocol.Program.Main(null));
   //         thread.IsBackground = true;
   //         thread.Priority = ThreadPriority.Normal;
   //         thread.Start();

   //         Console.WriteLine("Press 'q' to quit.");

			//while (Console.ReadKey(true).Key != ConsoleKey.Q)
			//{
			//	//while (!Console.KeyAvailable)
			//	//{
			//	//	// Do something
			//	//}
			//}
		}

		//private static void ConsoleExit(string reasonMessage)
		//{
		//	Console.WriteLine(reasonMessage);
		//	Console.WriteLine("Press any key to exit...");
		//	Console.ReadKey();
		//}

		//private static bool TryConnectToDatastore(DatastoreProvider datastore, AppContext appContext)
		//{
		//	bool connected = false;

		//	try
		//	{
		//		Console.WriteLine(String.Format("Connecting to {0} Datastore...", appContext.AppName));

  //              datastore.DatastoreType = appContext.UserSettings.DatastoreType;
  //              datastore.ConnectionString = appContext.GetDatastoreConnectionString();
  //              datastore.Connect();

		//		connected = true;
		//		Console.WriteLine("Datastore connected successful.");
		//	}
		//	catch (Exception ex)
		//	{
		//		connected = false;
		//		Console.WriteLine("Datastore Connection Error: " + ExceptionHelper.GetFullErrorMessage(ex));
		//	}

		//	return connected;
		//}
	}
}
