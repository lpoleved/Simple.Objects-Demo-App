using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Threading;
using Simple;
using Simple.Objects;
using Simple.Datastore;
using Simple.Objects.MonitorProtocol;
using Simple.SocketEngine;
using DemoApp.Objects;
using DemoApp.SocketProtocol;
using DemoApp.AppContext;

namespace DemoApp
{
	public class Server
	{
		private const string sqlServerSaPassword = "Dog3soUr6akR";
		private const int startMonitorDelay = 2000;

		public static ServerAppContext AppContext;
		public static SimpleObjectModelDiscovery<Tables> ModelDiscovery;
		public static ObjectManager ObjectManager;
		public static DemoAppServer ObjectAppServer;
		public static SimpleObjectMonitorServer MonitorServer;
		public static int? MonitorPort;
		//public static SimpleObjectsServiceMonitorServer AppManagementServerMonitor = null;

		static Server()
		{
			AppContext = ServerAppContext.Instance;
			AppContext.Version = Assembly.GetEntryAssembly()?.GetName().Version;

			ModelDiscovery = new SimpleObjectModelDiscovery<Tables>(AppDomain.CurrentDomain.GetAssemblies().ToList());
			ObjectManager = new ObjectManager(ModelDiscovery);
			ObjectAppServer = new DemoAppServer(ObjectManager);
		}

		public static async ValueTask StartAsync(bool startWithMonitoringService = false)
		{
			Console.WriteLine("System initialization started...");

			//AppManagementServerMonitor = new SimpleObjectsServiceMonitorServer(AppServer);
			//NET.Manager.Services.AppContext.SetCurrentNetManagerAppServer(AppServer);


			//Console.WriteLine("System initialization succeeded.");
			//}
			//catch (Exception ex)
			//{
			//	ConsoleExit("System initialization Error: " + ExceptionHelper.GetFullErrorMessage(ex)); 
			//	return;
			//}


			AppContext.Security.SetLicensing();

			// TODO: TryToConnectToLogDatastore...


			//int restoreMonitorEngine = 0; // TODO:
			//// Start monitoring, if required.
			//if (AppContext.SystemSettings.MonitorDevices)
			//{
			//	Console.WriteLine("Starting Monitoring Service...");
			//	MonitorEngine.Start(startMonitorDelay);
			//	Console.WriteLine(" Started");
			//}

			Console.WriteLine("Connecting to Datastore...");

			if (!TryConnectToDatastore(ObjectAppServer.LocalDatastore, AppContext))
			{
				Console.WriteLine("Error connecting to Datastore");

				ConsoleExit("");
				
				return;
			}

			Console.Write(" Connected\r\n");

			// Initializing datastore objects...
			//try
			//{
			Console.WriteLine("Initializing Datastore Objects...");
			ObjectManager.InitializeLocalDatastore();
			//}
			//catch (Exception ex)
			//{
			//	ConsoleExit("Error Initializing Datastore Objects: " + ExceptionHelper.GetFullErrorMessage(ex));
			//	return;
			//}


			Console.WriteLine(String.Format("Starting Object Manager Service on port {0}... ", ObjectAppServer.Port));
			bool isStarted = await ObjectAppServer.StartAsync();

			if (isStarted)
			{
				Console.Write(" Started\r\n");
			}
			else
			{
				Console.Write(" Error Starting Server\r\n");
			}

			if (startWithMonitoringService)
			{
				MonitorServer = new SimpleObjectMonitorServer(ObjectAppServer);

				if (MonitorPort != null)
					MonitorServer.Port = (int)MonitorPort;
				
				Console.WriteLine(String.Format("Starting Object Manager Server Monitoring on port {0}... ", MonitorServer.Port));
				
				bool isMonitorStarted = await MonitorServer.StartAsync();

				if (isMonitorStarted)
				{
					Console.Write(" Started\r\n");
				}
				else
				{
					Console.Write(" Error Starting Server\r\n");
				}
			}


			//Console.WriteLine("Press 'q' to quit.");
			//while (Console.ReadKey(true).Key != ConsoleKey.Q);

			//Console.WriteLine(String.Format("Stoping Object Manager Service on port {0}... ", AppServer.Port));
			//AppServer.Stop();
			//Console.Write(" Service stopped.\r\n");

			//Console.WriteLine(String.Format("Disconnecting from {0} Datastore...", AppContext.AppName));
			//LocalDatastore.Disconnect();
			//Console.Write(" Disconnected.\r\n");
		}

		public static async ValueTask StopAsync()
		{
			if (MonitorServer != null)
			{
				Console.WriteLine("Stopping Simple.Objects Server Monitoring Service...");
				await MonitorServer.StopAsync();
				Console.Write(" Stopped");
			}
			else
			{
				Console.WriteLine("Simple.Objects Monitoring Service is already shutdown.");
			}

			if (ObjectAppServer != null)
			{
				Console.WriteLine("Stopping Object Manager Service...");
				await ObjectAppServer.StopAsync();
				Console.Write(" Stopped");

				Console.WriteLine("Disconnecting from Datastore...");
				ObjectAppServer.LocalDatastore.Disconnect();
				Console.Write("  Disconnected");
			}
			else
			{
				Console.WriteLine("Object Manager Service is already shutdown.");
			}
		}

		public static async ValueTask RestartAsync()
		{
			Console.WriteLine("Restarting NET.Manager™ Services...");
			
			await StopAsync();
			await StartAsync();
		}

		private static void ConsoleExit(string reasonMessage)
		{
			Console.WriteLine(reasonMessage);
			Console.WriteLine("Press any key to exit...");
			Console.Read();
		}

		private static bool TryConnectToDatastore(DatastoreProvider datastore, ServerAppContext appContext)
		{
			bool connected = false;

			try
			{
				Console.WriteLine(String.Format("Connecting to {0} Datastore...", appContext.AppName));

				datastore.DatastoreType = appContext.SystemSettings.DatastoreType;
				datastore.ConnectionString = appContext.CreateDatastoreConnectionString();
				datastore.Connect();

				connected = true;
				Console.WriteLine("Datastore connected successful.");
			}
			catch (Exception ex)
			{
				connected = false;
				Console.WriteLine("Datastore connection error: " + ExceptionHelper.GetFullErrorMessage(ex));
			}

			return connected;
		}
	}
}
