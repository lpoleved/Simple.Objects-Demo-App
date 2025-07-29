using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using System.Management;
using System.IO;
using System.Net;
using Simple;
using Simple.Network;
using Simple.Security;
using Simple.Datastore;
using Simple.Objects;
using Simple.Controls;
using Simple.Objects.Controls;
using Simple.Datastore.Controls;
using DemoApp.SocketProtocol;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting.Helpers;
using DemoApp.Objects;
using DemoApp.AppContext;
using System.Diagnostics.Metrics;

namespace DemoApp
{
	static class Program
	{
		private const string SettingLastServer = "LastServer";
		private const string SettingLastUsername = "LastUsername";
		//private const string sqlServerSaPassword = "Dog3soUr6akR";

		//private static ObjectRelationModel relationModel = null;
		//public static ClientAppContext AppContext = null;
		public static ImageControl ImageControl;
		public static DemoAppClient? AppClient;
		public static SimpleObjectModelDiscovery<Tables> ModelDiscovery;
		public static ClientObjectManager ObjectManager;
		public static LocalDatastore? LocalDatastore = null;

		public const int MonitorStartDelay = 20000;
		public const int MonitorStartingInterval = 1000;
		//public static SimpleObjectModelDiscovery ModelDiscovery = null;
		//public static IDatastore RemoteDatastore = null;
		//public static DatastoreProvider LocalDatastore = null;
		//      public static ClientObjectManager ObjectManager = null;
		//      public static MonitorEngine MonitorEngine = null;
		//private static FormBackgroundWorker backgroundWorker = null;
		//private const int startMonitorDelay = 10000;
		public const int DefaultServerPort = 2020;
		public const int DefaultServerMonitorPort = 2021;
		public const string DefaultServer = "localhost";

		public const int AppTimeout = 10000; // PackageEngine timeout in milliseconds
		public const int NumOfRetry = 3;


#if DEBUG
		public static bool IsDebug = true;
		private static Action RunMainForm = () => Application.Run(new FormMain());
		//private static Action RunMainForm = () => Application.Run(new FormMainFull());
#else
		public static bool IsDebug = false;
		private static Action RunMainForm = () => Application.Run(new FormMain());
#endif

		//public static SimpleObjectsServiceMonitorServer AppManagementServerMonitor = null;

		//
		// **** Start Options ****
		//
		//public static bool IsClientWithLocalDatastoreMode = false;
		//public static bool StartSimpleObjectServer = false;
		//public static bool StartSimpleObjectsServerMonitorGui = true;
		public static StartingMode StartingMode = StartingMode.ClientWithLocalDatastore;
		//
		//

		private static List<string> tableNamesExcludedFromDeletion = new List<string>
		{
			"master", SystemTables.Model.TableInfo.TableName, SystemSetting.Model.TableInfo.TableName, SystemTransaction.Model.TableInfo.TableName,
			SystemClient.Model.TableInfo.TableName, SystemServer.Model.TableInfo.TableName, 
			Tables.Users.TableName, Tables.UserGroups.TableName,
		};

		private static List<WhereCriteriaElement> graphElementsDeleteAllExceptThisWhereCriteria = new List<WhereCriteriaElement>()
		{
			new WhereCriteriaElement(GraphElementModel.PropertyModel.GraphKey.PropertyIndex, (int)GraphKey.Users, WhereComparator.NotEqual),
			new WhereCriteriaElement(GraphElementModel.PropertyModel.GraphKey.PropertyIndex, (int)GraphKey.UserGroups, WhereComparator.NotEqual),
		};

		private static List<WhereCriteriaElement> manyToManyRelationElementsDeleteAllExceptThisWhereCriteria = new List<WhereCriteriaElement>()
		{
			new WhereCriteriaElement(GroupMembershipModel.PropertyModel.RelationKey.PropertyIndex, (int)ManyToManyRelationKey.UserToUserGroup, WhereComparator.NotEqual),
		};

		static Program()
		{
			ImageControl = new ImageControl();
			//ImageControl.Load(new DemoApp.Icons.Properties.Resources());
			ImageControl.Load(new DemoApp.Properties.Resources());

			// Enforce assemblies to included in current domain in order to be discovered by SimpleObjectModelDiscovery engine
			foreach (AssemblyName assemblyName in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
				Assembly.Load(assemblyName);

			ModelDiscovery = new SimpleObjectModelDiscovery<Tables>(AppDomain.CurrentDomain.GetAssemblies().ToList());
			ObjectManager = new ClientObjectManager(ModelDiscovery);
		}

		// TODO: Redesign this, see Asynchronous Programming - Async from the Start: https://docs.microsoft.com/en-us/archive/msdn-magazine/2015/november/asynchronous-programming-async-from-the-start

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		//static async Task Main(string[] args)
		static void Main(string[] args)
		{

			// Get .NET version info
			//Assembly asm = Assembly.GetExecutingAssembly();
			Assembly? asm = Assembly.GetAssembly(typeof(FormMain));

			Console.WriteLine("Compiled on .NET Version: {0}", asm?.ImageRuntimeVersion.ToString());
			Console.WriteLine("Running on .NET Version: {0}", Environment.Version.ToString());

			ClientAppContext.Instance.Version = Assembly.GetEntryAssembly()?.GetName().Version;

			ClientAppContext.Instance.UserSettings.DefaultRibbonStyle = (int)RibbonControlStyle.Office2007;
			ClientAppContext.Instance.UserSettings.DefaultRibbonPagePlacement = (int)RibbonControlPagePlacement.Dynamic;
			ClientAppContext.Instance.UserSettings.DefaultRibbonControlColorScheme = (int)RibbonControlColorScheme.Orange;
			ClientAppContext.Instance.UserSettings.DefaultRibonSkinName = "Black"; // "Office 2010 Blue"; // "Office 2013 Dark Gray";;

			if (args.Length == 1)
			{
				if (args[0] == "localDb")
					ServerAppContext.Instance.SystemSettings.DatastoreSqlServer = "(LocalDB)\\V11.0"; // Inno Setup is signalling that LocalDB is installed instead of SQL Server
				else if (args[0] == "sqlExpress")
					ServerAppContext.Instance.SystemSettings.DatastoreSqlServer = ".\\SQLEXPRESS"; // Inno Setup is signalling that SQL Express is installed

				ServerAppContext.Instance.SystemSettings.Save();
			}

			if (!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
				DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
			else
				DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			DevExpress.UserSkins.BonusSkins.Register();
			DevExpress.Skins.SkinManager.EnableFormSkins();
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(ClientAppContext.Instance.UserSettings.GetRibbonSkinName());
			WindowsFormsSettings.CompactUIMode = (ClientAppContext.Instance.UserSettings.CompactUI) ? DefaultBoolean.True : DefaultBoolean.False;
			Application.EnableVisualStyles();

			if (StartingMode == StartingMode.ClientWithLocalDatastore)
			{
				//Process curr = Process.GetCurrentProcess();
				Process[] procs = Process.GetProcessesByName(Assembly.GetEntryAssembly()?.GetName().Name);

				if (procs.Length > 1)
				{
					XtraMessageBox.Show(ClientAppContext.Instance.AppName + " is already running! \r\nOnly one instane of application is allowed.", "Duplicate Instance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					return;
				}

				//foreach (Process p in procs)
				//{
				//	if ((p.Id != curr.Id) && (p.MainModule?.FileName == curr.MainModule?.FileName))
				//	{
				//		XtraMessageBox.Show(Assembly.GetEntryAssembly()?.GetName().Name + " is already running! Exiting the application.", "Duplicate Instance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				//		return;
				//	}
				//}


				//string appName = ClientAppContext.Instance.AppName + " Preview";
				////string? appName = Assembly.GetEntryAssembly()?.GetName().Name;
				//bool createdNew;

				//Mutex mutex = new Mutex(true, appName, out createdNew);

				//if (!createdNew)
				//{
				//	XtraMessageBox.Show(appName + " is already running! Exiting the application.", "Duplicate Instance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				//	return;
				//}


				//if (!mutex.WaitOne(0))
				//{
				//	Console.WriteLine($"Already running. Press any key to continue . . .");
				//	Console.ReadKey();
				//	Environment.Exit(1);
				//}
				//try
				//{
				//	//MainAsync(args).GetAwaiter().GetResult();
				//}
				//finally
				//{
				//	mutex.ReleaseMutex();
				//}

				ClientAppContext.Instance.Version = Assembly.GetEntryAssembly()?.GetName().Version;

				//ModelDiscovery = new SimpleObjectModelDiscovery<Tables>(AppDomain.CurrentDomain.GetAssemblies().ToList());
				LocalDatastore = new LocalDatastore();

				ObjectManager.SetClientWithLocalDatastoreWorkingMode(LocalDatastore);

				bool connected = false;

				do
				{
					FormBackgroundWorker<bool> backgroundWorker = new FormBackgroundWorker<bool>(); // = null
																									//backgroundWorker = new FormBackgroundWorker<bool>();
																									//FormLoginLocalDatastore datastoreConnectionForm = new FormLoginLocalDatastore();
					backgroundWorker.IconOptions.Image = global::DemoApp.Icons.Properties.Resources.Plug;
					backgroundWorker.IconOptions.LargeImage = global::DemoApp.Icons.Properties.Resources.Plug_Large;
					backgroundWorker.CanCancel = true;

					backgroundWorker.Start(ClientAppContext.Instance.AppName, TryConnectToDatastore);

					connected = (bool)backgroundWorker.WorkerContext.Result;

					if (backgroundWorker.WorkerContext.Canceled)
						return;

					backgroundWorker.Close();
					backgroundWorker.Dispose();

					if (!connected)
					{
						DatastoreConnectionForm datastoreConnectionForm = new DatastoreConnectionForm(ServerAppContext.Instance.SystemSettings);

						datastoreConnectionForm.DatastoreSettings.ServerSystemSettings = ServerAppContext.Instance.SystemSettings;

						DialogResult dialogResult = datastoreConnectionForm.ShowDialog();

						if (dialogResult != DialogResult.OK)
							return;
						//ServerAppContext.Instance.SystemSettings.Load();
						//else
						//	return;
					}
				}
				while (!connected);

				ObjectManager.InitializeLocalDatastore();

				if (!IsDebug)
				{
					//Open Login form
					bool authorized = false;
					string username = ClientAppContext.Instance.UserSettings.GetValue<string>(SettingLastUsername, defaultValue: ObjectManager.SystemAdmin.Username);
					FormLoginLocalDatastore formLogin = new FormLoginLocalDatastore(ClientAppContext.Instance.AppName, username);
					DialogResult loginDialogResult = formLogin.ShowDialog();

					while (!authorized)
					{
						if (loginDialogResult == DialogResult.OK)
						{
							authorized = ObjectManager.AuthenticateSession(formLogin.Username, PasswordSecurity.HashPassword(formLogin.Password), out long userId);

							if (!authorized)
							{
								XtraMessageBox.Show("Wrong username or password.", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								loginDialogResult = formLogin.ShowDialog();
							}

							ClientAppContext.Instance.UserSettings.SetValue(SettingLastUsername, formLogin.Username, defaultValue: ObjectManager.SystemAdmin.Username);
							ClientAppContext.Instance.UserSettings.Save();
						}
						else
						{
							ObjectManager.LocalDatastore.Disconnect();

							return;
						}
					}

					formLogin.Close();
				}

				RunMainForm();
				//}
				//catch (Exception ex)
				//{
				//    XtraMessageBox.Show(ex.Message, AppContext.Instance.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				//}
				//finally
				//{
				if (ObjectManager != null)
					ObjectManager.LocalDatastore.Disconnect();
				//}
			}
			else // Run Client, Server and optional Server Monitor acordingly
			{

				if (StartingMode == StartingMode.ServerOnly || StartingMode == StartingMode.ClentAndServer || StartingMode == StartingMode.ServerAndServerMonitor || StartingMode == StartingMode.ClientServerAndServerMonitor)
				{
					Server.ObjectAppServer.Port = DefaultServerPort;
					Server.MonitorPort = DefaultServerMonitorPort;

					//Nubium.Server.ObjectAppServer.MonitorServer.Port = DefaultServerMonitorPort;

					//Task.Run(async () => await Nubium.Server.StartAsync())
					//	.Wait();
					Server.StartAsync(startWithMonitoringService: true).GetAwaiter().GetResult();
				}
				//await Server.StartAsync();

				//task.RunSynchronously();
				//return task.Result;

				//var serverStart = Nubium.Server.StartAsync();
				//await serverStart;

				//Thread.Sleep(10000);
				//Thread.Sleep(100);

				#region Server Monitor GUI Start

				if (StartingMode == StartingMode.ServerMonitorOnly || StartingMode == StartingMode.ServerAndServerMonitor || StartingMode == StartingMode.ClientServerAndServerMonitor)
				{
					Thread monitorThread = new Thread(() =>
					{
						Thread.Sleep(5000); // Give time Nubium.Server to start
						Simple.Objects.ServerMonitor.Program.Main();
					});

					monitorThread.IsBackground = true;
					monitorThread.Priority = ThreadPriority.Normal;
					monitorThread.SetApartmentState(ApartmentState.STA);
					monitorThread.Start();
				}

				#endregion Server Monitor GUI Start

				if (StartingMode == StartingMode.ClientOnly || StartingMode == StartingMode.ClentAndServer || StartingMode == StartingMode.ClientServerAndServerMonitor)
				{
					try
					{
						bool connected = false;
						bool authorized = false;
						string server = ClientAppContext.Instance.UserSettings.GetValue<string>(SettingLastServer, defaultValue: DefaultServer);
						string username = ClientAppContext.Instance.UserSettings.GetValue<string>(SettingLastUsername, defaultValue: DemoApp.Objects.ObjectManager.SystemAdminUsername);

						AppClient = new DemoAppClient(ObjectManager) { Timeout = Program.AppTimeout, NumOfRetry = Program.NumOfRetry, StartReceiveOnConnect = false };

						if (IsDebug)
						{
							IPEndPoint endPoint = IpHelper.ParseIpEndPoint(server, DefaultServerPort);

							if (StartingMode == StartingMode.ServerMonitorOnly || StartingMode == StartingMode.ServerAndServerMonitor || StartingMode == StartingMode.ClientServerAndServerMonitor)
								Thread.Sleep(10000); // Give time monitor to start and attach to the server

							if (AppClient.IsConnected)
							{
								connected = true;
							}
							else
							{
								//var clientStart = Task.Run(async () => await AppClient.ConnectAsync(endPoint));
								//clientStart.Wait();

								XtraMessageBox.Show($"{AppContext.ClientAppContext.Instance.AppName} is about to be started... \r\nClick OK to run main application form.\r\nOtherwise you will wait forever.", "App Runner", MessageBoxButtons.OK, MessageBoxIcon.Information);

								connected = AppClient.ConnectAsync(endPoint).GetAwaiter().GetResult();
								//var clientStart = AppClient.ConnectAsync(endPoint);
								//await clientStart;
								//connected = clientStart.IsCompletedSuccessfully;
							}

							if (!connected)
							{
								XtraMessageBox.Show("Could not connect to remote server " + server, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

								return;
							}
							else
							{
								//var authenticationResult = Task.Run(async () => await AppClient.AuthenticateSession(username, "manager"));
								//authenticationResult.Wait();
								AppClient.StartReceive();

								var protoolVersion = AppClient.GetServerVersionInfo().GetAwaiter().GetResult();
								var response = AppClient.AuthenticateSession(username, "manager").GetAwaiter().GetResult();

								authorized = response.ResponseSucceeded && response.IsAuthenticated;

								//var authenticationResult = AppClient.AuthenticateSession(username, "manager");
								//await authenticationResult;

								//authorized = authenticationResult.Result;

								if (!authorized)
								{
									XtraMessageBox.Show("Wrong username or password.", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

									return;
								}
							}
						}
						else
						{
							//Open Login form
							FormLogin formLogin = new FormLogin(ClientAppContext.Instance.AppName, server, username);
							DialogResult loginDialogResult = formLogin.ShowDialog();

							while (!connected)
							{
								if (loginDialogResult == DialogResult.OK)
								{
									IPEndPoint endPoint = IpHelper.ParseIpEndPoint(formLogin.Server, DefaultServerPort);

									if (AppClient.IsConnected)
									{
										connected = true;
									}
									else
									{
										//var clientConnect = Task.Run(async () => await AppClient.ConnectAsync(endPoint));
										//clientConnect.Wait();
										//var clientConnect = AppClient.ConnectAsync(endPoint);
										//await clientConnect;

										//connected = clientConnect.IsCompletedSuccessfully;

										connected = AppClient.ConnectAsync(endPoint).GetAwaiter().GetResult();
									}

									if (!connected)
									{
										XtraMessageBox.Show("Could not connect to remote server " + formLogin.Server, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										loginDialogResult = formLogin.ShowDialog();
									}
									else
									{
										//var authenticationResult = Task.Run(async () => await AppClient.AuthenticateSession(formLogin.Username, formLogin.Password));

										//authenticationResult.Wait();

										//var authenticationResult = AppClient.AuthenticateSession(formLogin.Username, formLogin.Password);
										//await authenticationResult;

										//authorized = authenticationResult.Result;

										AppClient.StartReceive();

										var response = AppClient.AuthenticateSession(formLogin.Username, formLogin.Password).GetAwaiter().GetResult();

										authorized = response.ResponseSucceeded && response.IsAuthenticated;

										if (!authorized)
										{
											XtraMessageBox.Show("Wrong username or password.", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
											loginDialogResult = formLogin.ShowDialog();
										}
									}

									ClientAppContext.Instance.UserSettings.SetValue(SettingLastServer, formLogin.Server, defaultValue: DefaultServer);
									ClientAppContext.Instance.UserSettings.SetValue(SettingLastUsername, formLogin.Username, defaultValue: DemoApp.Objects.ObjectManager.SystemAdminUsername);
									ClientAppContext.Instance.UserSettings.Save();
								}
								else
								{
									//await AppClient.CloseAsync();
									//Task.Run(async () => await AppClient.CloseAsync())
									//	.Wait();

									AppClient.CloseAsync().GetAwaiter().GetResult();

									return;
								}
							}

							formLogin.Close();
						}

					}
					catch (Exception ex)
					{
						XtraMessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

						//Task.Run(async () => await AppClient.CloseAsync())
						//	.Wait();
						//await AppClient.CloseAsync();

						AppClient?.CloseAsync().GetAwaiter().GetResult();

						return;
					}

				}




				//Cursor.Current = currentCursor;

				//try
				//{
				//Application.Run(new FormMain());
				//Application.Run(new FormMain());
				//Task.Run(() => RunMainForm()); // Run additional new desktop instance

				//Thread thread2 = new Thread(() => RunMainForm());

				//thread2.IsBackground = true;
				//thread2.Priority = ThreadPriority.Normal;
				//thread2.SetApartmentState(ApartmentState.STA);
				//thread2.Start();

				RunMainForm();

				//RunMainForm();

				//}
				//catch (Exception ex)
				//{
				//    XtraMessageBox.Show(ex.Message, AppContext.Instance.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				//}
				//finally
				//{

				//Task.Run(async () => await Server.StopAsync())
				//	.Wait();
				//await Server.StopAsync();

				Server.StopAsync().GetAwaiter().GetResult();

				// Close monitor form if exists
				//Simple.Objects.ServerMonitor.Program.MonitorForm?.Close();
			}

			return;


			//Application.Run(new Form1());

			//// Insert test
			//Graph graph = manager.GetGraph((int)GraphKey.SelectNetworkObjectGraph);

			//for (int i = 0; i < 500; i++)
			//{
			//    NetworkGroup simpleObject = new NetworkGroup();
			//    simpleObject.Name = "SimpleObject" + i;
			//    simpleObject.Save();

			//    GraphElement graphElement = new GraphElement(graph, null, simpleObject);
			//    graphElement.Save();
			//}




#if !DEBUG && LOCALDATASTORE

		// Login to the application
		try
		{
			FormLogin formLogin = new FormLogin();
			DialogResult loginDialogResult = formLogin.ShowDialog();

			if (loginDialogResult != DialogResult.OK)
			{
				Datastore.Disconnect();
				return;
			}
		}
		catch (Exception ex)
		{
			XtraMessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

#endif


			//Folder folder = new Folder();
			//folder.Name = "FolderTest";
			//folder.Description = "FolderTest Description";

			//TransactionAction tac = new TransactionAction(TransactionActionType.Insert, folder.Key, folder.GetPropertyValueDictionary());
			//System.IO.Stream a = System.IO.File.OpenWrite("C:\\test.bin");
			//System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			//bf.Serialize(a, tac);
			//a.Close();
			//Graph graphUsers = manager.GetGraph((int)GraphKey.Users);

			//for (int i = 0; i < 1000; i++)
			//{
			//    User user = new User();
			//    user.FirstName = "Pero" + i;
			//    user.LastName = "Perković" + i;
			//    user.Username = "username" + i;
			//    user.Password = "password" + i;

			//    user.Save();

			//    GraphElement graphElement = new GraphElement(graphUsers, graphUsers.RootGraphElements[0], user);
			//    graphElement.Save();
			//}


			//Random random = new Random();

			//for (int i = 0; i < 100; i++)
			//{
			//	int tableId = random.Next(100000);
			//	int serverId = random.Next(100000);
			//	bool isClientDynamic = Convert.ToBoolean(unchecked(random.Next()));
			//	long clientId = random.Next(10000000);
			//	long objectId = random.Next(1000);
			//	objectId <<= 32;
			//	objectId |= (long)random.Next();

			//	SimpleObjectKey3 objectKey = new SimpleObjectKey3(tableId, serverId, isClientDynamic, clientId, objectId);

			//	//int tableId2 = objectKey.Value.GetTableId3();
			//	//int serverId2 = objectKey.Value.GetServerId3();
			//	//bool isClientId2 = objectKey.Value.GetIsClientDynamic3();
			//	//long clientId2 = objectKey.Value.GetClientId3();
			//	//long objectId2 = objectKey.Value.GetObjectId3();

			//	//if (tableId != objectKey.Value.GetTableId3() || serverId != objectKey.Value.GetServerId3() || isClientDynamic != objectKey.Value.GetIsClientDynamic3() || clientId != objectKey.Value.GetClientId3() || objectId != objectKey.Value.GetObjectId3())
			//	//	XtraMessageBox.Show("Error in " + objectKey.GetType().Name);
			//}



			//ConfigManager configManager = ConfigManager.Instance;

			// Initialization of Graph and MaynToManyRelation objects, that is not in datastore.
			//Graphs graphs = new Graphs();
			//ManyToManyRelations manyToManyRelations = new ManyToManyRelations();



			//User user = NetManagerClientObjectManager.Instance.Users[0];

			//SimpleObjectTypeCache userGroupsCache = manager.ObjectCache.GetObjectTypeCache(typeof(UserGroup));
			//SimpleObjectCollection<UserGroup> userGroups = new SimpleObjectCollection<UserGroup>(manager, userGroupsCache.ObjectKeys);
			//UserGroup userGroup = userGroups[0];

			//SimpleObjectCollection<UserGroup> userUserGroups = user.UserGroups; //user.GetManyToManyObjectCollection<SimpleObject>(NetManagerObjectRelationModel.ManyToManyRelationModel.UserToUserGroup);
			//(userUserGroups as IList).Add(userGroup);

			//user.UserGroups.Add(userGroup);






			//Graph graphUsers = manager.GetGraph(GraphKey.Users);
			//GraphElement ge = graphUsers.RootGraphElements[0];

			//Graph graphUserGroups = manager.GetGraph(GraphKey.UserGroups);

			//           ISimpleObjectRelationModel relModel = graphUsers.GetObjectRelationModel();

			//           SimpleObjectCollection ge0 = graphUsers.GraphElements;
			//           GraphElement ge = ge0[0] as GraphElement;
			//           Graph gr = ge.Graph;


			//           Folder folder = new Folder();
			//           folder.Name = "Folder Test";
			//           SimpleObjectKey key = folder.Key;

			//           GraphElement folderGraphElement = new GraphElement(graphUsers, null, folder);

			//  //         folderGraphElement.Graph = graphUserGroups;
			//           folderGraphElement.Graph = graphUsers;

			//           SimpleObjectCollection folderGraphElements = folder.GraphElements;


			//           folderGraphElement.Delete();
			//           folderGraphElement = null;

			//           folder.Delete();
			//           folder = null;



			//           ge = graphUsers.GraphElements[0];
			//           SimpleObject bo = ge.SimpleObject;

			//           User u = new User();

			//           ISimpleObjectModel uModel = u.GetObjectModel();

			//           IList<Simple.SimpleObjects.IPropertyModel> p = uModel.Properties;

			//           p.GetEnumerator().Reset();

			//           IList<Simple.SimpleObjects.IPropertyModel> p1 = uModel.Properties;


			//           foreach (Simple.SimpleObjects.IPropertyModel pm in p)
			//           {
			//           }

			//           foreach (Simple.SimpleObjects.IPropertyModel pm in p)
			//           {
			//           }

			//           Folder f = new Folder();
			//           foreach (Simple.SimpleObjects.IPropertyModel pm in f.GetObjectModel().Properties)
			//           {
			//           }

			//            foreach (GraphElement graphElement in graphUsers.GraphElements)
			//            {
			////                XtraMessageBox.Show(graphElement.SimpleObject.Name);
			//            }


			//Folder folder = manager.Folders[manager.Folders.Count - 1];
			//GraphElement geFolder = folder.GraphElements[0];


			//GraphElement geFolder = new GraphElement(graphUsers, null, folder);

			//ge = folder.GraphElements[0];

			//folder.Save();
			//geFolder.Save();

			//Graph graphUsers = manager.GetGraph((int)GraphKey.Users);
			//User user = new User();
			//GraphElement userGraphElement = new GraphElement(graphUsers, null, user);
			////GraphElement userGroupGraphElement = new GraphElement(graphUserGroups, null, user);
			////userGroupGraphElement.Delete();
			//GraphElement geu = user.GraphElements[0];

			//user.FirstName = "Pero2";
			//user.LastName = "Perić2";
			//user.Username = "pperic2";
			//user.Save();

			//GraphElement geUser = new GraphElement()
			//{
			//    Graph = graphUsers,
			//    Parent = geFolder,
			//    SimpleObject = user
			//};

			//geUser.Save();



			//            FolderModel fm = FolderModel.Instance;
			//            int objectTableId = fm.ObjectTableId;
			////            GraphElement ge = new GraphElement();



			//            List<Folder> folders = new List<Folder>();
			//            List<Folder> folders2 = new List<Folder>();

			//            foreach (Folder f in manager.Folders)
			//            {
			//                folders.Add(f);
			//            }

			//            Folder folder = new Folder();
			//            folder.Name = "Folder No.X";
			//            folder.Save();



			//            foreach (Folder f in manager.Folders)
			//            {
			//                folders2.Add(f);
			//            }

			//            for (int i = 0; i < 1000; i++)
			//            {
			//                folder = new Folder();
			//                folder.Name = "Folder No." + i.ToString();
			//                folder.Save();
			////                f.Delete();
			//            }

			//Type providerType = Simple.Providers.ProviderDiscoveryManager.Instance.GetProviderType(Simple.Providers.ProviderModel.NetworkDevice);
			//Type providerModuleType = Simple.Providers.ProviderDiscoveryManager.Instance.GetProviderModuleType(providerModuleModel: Simple.Providers.ProviderModel.NetworkDevice.ModuleModel.Interfaces,
			//                                                                                                   operatingSystemModel: Simple.Providers.ProviderModel.OperatingSystemModel.CiscoIOS);

			//NetworkDeviceProvider ndp = new NetworkDeviceProvider();
			//ndp.OperatingSystem = ProviderModel.OperatingSystemGeneric;
			//ndp.Connection.Snmp.RemoteHost = "localhost";
			//ndp.Connection.Snmp.CommunityString = "4wr1t1ng";
			//ndp.Connection.Snmp.Connect();
			//string text = ndp.System.GetName();
			//ndp.Connection.Snmp.Disconnect();

			//NetworkDeviceClientProvider ndcp = new NetworkDeviceClientProvider(Simple.Services.ProviderManager.Instance);
			//ndcp.OperatingSystem = ProviderModel.OperatingSystemModel.Generic.Name;
			//NET.Tools.SnmpManagerConnectionStringBuilder snmpConnString = new NET.Tools.SnmpManagerConnectionStringBuilder();
			//snmpConnString.RemoteHost = "localhost";
			//snmpConnString.CommunityString = "4wr1t1ng";
			//NET.Tools.TerminalConnectionStringBuilder termConnString = new NET.Tools.TerminalConnectionStringBuilder();

			//ndcp.SnmpConnectionString = snmpConnString.BuildConnectionString();
			//ndcp.TerminalConnectionString = termConnString.BuildConnectionString();
			//ndcp.Connect();

			//ndcp.System.SetContact("Pero Kvrgić");
			//text = ndcp.System.GetContact().Value;
			////ndcp.System.SetLocation("Bunker");

			//ndcp.Disconnect();

			//TerminalControl tm = new TerminalControl();
			//tm.RemoteHost = "194.126.213.223";
			//tm.Username = "rdosen";
			//tm.Password = "konjina25";
			//tm.EnableSecret = "cisco";
			//tm.Connect();
			//string text = tm.Send("show run");
			//text = tm.Send("show interfaces");


			//object o = bom.SystemTables;

			//Simple.Datastore.DatastoreProvoderAccess datastore = new Datastore.DatastoreProvoderAccess();
			//datastore.DataSource = System.IO.Directory.GetCurrentDirectory() + "\\Data.mdb";
			//datastore.Select("systemTableObjects");

			//foreach (Layer3Interface layer3Interface in manager.Layer3Interfaces)
			//{
			//    if (layer3Interface.NetworkNode != null)
			//    {
			//        layer3Interface[Layer3InterfaceModel.PropertyModel.NetworkNodeOrVlanTableId.Name] = layer3Interface.NetworkNode.GetModel().TableInfo.TableId;
			//        try
			//        {
			//            layer3Interface.Save();
			//        }
			//        catch
			//        {
			//        }
			//    }
			//    else if (layer3Interface.Vlan != null)
			//    {
			//        layer3Interface[Layer3InterfaceModel.PropertyModel.NetworkNodeOrVlanTableId.Name] = layer3Interface.Vlan.GetModel().TableInfo.TableId;
			//        layer3Interface.Save();
			//    }
			//}

			//foreach (Layer3InterfaceSecondaryIpAddress layer3InterfaceSecondaryIpAddress in manager.Layer3InterfaceSecondaryIpAddresses)
			//{
			//    if (layer3InterfaceSecondaryIpAddress.NetworkNode != null)
			//    {
			//        layer3InterfaceSecondaryIpAddress[Layer3InterfaceSecondaryIpAddressModel.PropertyModel.NetworkNodeTableId.Name] = layer3InterfaceSecondaryIpAddress.NetworkNode.GetModel().TableInfo.TableId;
			//        layer3InterfaceSecondaryIpAddress.Save();
			//    }
			//}

			//foreach (SystemTransactionLog systemTransactionLog in manager.ObjectCache.GetObjectCollection<SystemTransactionLog>())
			//{
			//    if (systemTransactionLog.Administrator != null)
			//    {
			//        systemTransactionLog[SystemTransactionLogModel.PropertyModel.AdministratorTableId.Name] = systemTransactionLog.Administrator.GetModel().TableInfo.TableId;
			//        systemTransactionLog.Save();
			//    }
			//}


			//Assembly asm = typeof(DevExpress.UserSkins.SimpleObjects).Assembly;
			//DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);

			// Splash screens and wait forms created with the help of the SplashScreenManager component run in a separate thread.  
			// Information on custom skins registered in the main thread is not available in the splash screen thread  
			// until you call the SplashScreenManager.RegisterUserSkins method.  
			// To provide information on custom skins to the splash screen thread, uncomment the following line. 
			// SplashScreenManager.RegisterUserSkins(asm);  


			//AppContext.Instance.UserSettings.SetValue("LastUser", "system");

			//			Cursor.Current = currentCursor;


			//			//int tableId = NetworkModel.TableId;

			//			//try
			//			//{
			//			Application.Run(new FormMain());
			//			//}
			//			//catch (Exception ex)
			//			//{
			//			//    XtraMessageBox.Show(ex.Message, AppContext.Instance.AppName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			//			//}
			//			//finally
			//			//{


			//#if LOCALDATASTORE
			//				if (LocalDatastore != null)
			//                    LocalDatastore.Disconnect();
			//#else

			//			//AppClient = Nubium.Client.AppClient = new NetManagerAppClient(ObjectManager);
			//			//RemoteDatastore = new RemoteDatastore(Nubium.Client.AppClient);
			//			//ObjectManager = new ClientObjectManager(ModelDiscovery, RemoteDatastore);
			//			////ObjectManager.ServerId = -1; // Client mode

			//			//Nubium.Client.AppService.Disconnect();
			//			Nubium.Server.Stop();

			//#endif
			//			//}

			//return 0;
		}

		// Recommended code for design-time skin initialization.  
		// In Visual Studio 2012 and higher, add the following code to your project  
		// to ensure that your custom skin assembly is loaded and that the custom skin is registered at design time.  
		public class SkinRegistration : Component
		{
			public SkinRegistration()
			{
				//DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.SimpleObjects).Assembly);
			}
		}

		private static void TryConnectToDatastore(WorkerContext<bool> workerContext)
		{
			bool connected = false;

			try
			{
				workerContext.ReportProgress(-1, "Connecting to Datastore...");

				ConnectToDatastore(ObjectManager.LocalDatastore, ServerAppContext.Instance);

				connected = true;
			}
			catch (Exception ex)
			{
				connected = false;
				XtraMessageBox.Show(ex.Message, "Datastore connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			workerContext.Result = connected;
		}

		private static void ConnectToDatastore(DatastoreProvider datastore, ServerAppContext appContext)
		{
			datastore.DatastoreType = appContext.SystemSettings.DatastoreType;
			datastore.ConnectionString = appContext.CreateDatastoreConnectionString();
			datastore.Connect();
		}


		//      private static void TryConnectToDatastore(WorkerContext workerContext)
		//      {
		//          bool connected = false;

		//          try
		//          {
		//              workerContext.ReportProgress(-1, "Connecting to Datastore...");

		//              LocalDatastore.DatastoreType = AppContext.SystemSettings.DatastoreType;
		//              LocalDatastore.ConnectionString = AppContext.CreateDatastoreConnectionString();
		//              LocalDatastore.Connect();

		//              connected = true;
		//          }
		//          catch (Exception ex)
		//          {
		//              connected = false;
		//		XtraMessageBox.Show(ExceptionHelper.GetFullErrorMessage(ex), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//          }

		//          workerContext.Result = connected;
		//      }

		//private static void DeleteAllDataFromDatastore()
		//{
		//	IList<string> tableNames = LocalDatastore.GetTableNames();

		//	foreach (string tableName in tableNames)
		//	{
		//		if (!tableNamesExcludedFromDeletion.Contains(tableName))
		//		{
		//			if (tableName == GraphElementModel.Instance.TableInfo.TableName)
		//			{
		//                      LocalDatastore.DeleteRecords(tableName, graphElementsDeleteAllExceptThisWhereCriteria);
		//			}
		//                  else if (tableName == ManyToManyRelationElementModel.Instance.TableInfo.TableName)
		//                  {
		//                      LocalDatastore.DeleteRecords(tableName, manyToManyRelationElementsDeleteAllExceptThisWhereCriteria);
		//                  }
		//                  else
		//			{
		//				LocalDatastore.DeleteRecords(tableName, null); // Delete All Records
		//			}
		//		}
		//	}
		//}
	}

	public enum StartingMode
	{
		ClientWithLocalDatastore = 0,
		ClientOnly,
		ClentAndServer,
		ClientServerAndServerMonitor,
		ServerOnly,
		ServerAndServerMonitor,
		ServerMonitorOnly
	}
}
