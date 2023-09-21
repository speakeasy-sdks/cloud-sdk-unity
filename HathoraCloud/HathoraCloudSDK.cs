
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud
{
    using HathoraCloud.Utils;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// Hathora Cloud API: Welcome to the Hathora Cloud API documentation! Learn how to use the Hathora Cloud APIs to build and scale your game servers globally.
    /// </summary>
    public interface IHathoraCloudSDK
    {

        /// <summary>
        /// Operations that allow you manage your &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#application&quot;&gt;applications&lt;/a&gt;.
        /// </summary>
        public IAppV1SDK AppV1 { get; }

        /// <summary>
        /// Operations that allow you to generate a Hathora-signed &lt;a href=&quot;JWT&quot;&gt;JSON web token (JWT)&lt;/a&gt; for &lt;a href=&quot;https://hathora.dev/docs/lobbies-and-matchmaking/auth-service&quot;&gt;player authentication&lt;/a&gt;.
        /// </summary>
        public IAuthV1SDK AuthV1 { get; }
        public IBillingV1SDK BillingV1 { get; }

        /// <summary>
        /// Operations that allow you create and manage your &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#build&quot;&gt;builds&lt;/a&gt;.
        /// </summary>
        public IBuildV1SDK BuildV1 { get; }

        /// <summary>
        /// Operations that allow you configure and manage an application&amp;apos;s &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#build&quot;&gt;build&lt;/a&gt; at runtime.
        /// </summary>
        public IDeploymentV1SDK DeploymentV1 { get; }

        /// <summary>
        /// Service that allows clients to directly ping all Hathora regions to get latency information
        /// </summary>
        public IDiscoveryV1SDK DiscoveryV1 { get; }
        public ILobbyV1SDK LobbyV1 { get; }

        /// <summary>
        /// Operations to create and manage &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#lobby&quot;&gt;lobbies&lt;/a&gt;.
        /// </summary>
        public ILobbyV2SDK LobbyV2 { get; }

        /// <summary>
        /// Operations to get logs by &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#application&quot;&gt;applications&lt;/a&gt;, &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#process&quot;&gt;processes&lt;/a&gt;, and &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#deployment&quot;&gt;deployments&lt;/a&gt;. We store 20GB of logs data.
        /// </summary>
        public ILogV1SDK LogV1 { get; }
        public IManagementV1SDK ManagementV1 { get; }

        /// <summary>
        /// Operations to get metrics by &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#process&quot;&gt;process&lt;/a&gt;. We store 72 hours of metrics data.
        /// </summary>
        public IMetricsV1SDK MetricsV1 { get; }

        /// <summary>
        /// Operations to get data on active and stopped &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#process&quot;&gt;processes&lt;/a&gt;.
        /// </summary>
        public IProcessesV1SDK ProcessesV1 { get; }
        public IRoomV1SDK RoomV1 { get; }

        /// <summary>
        /// Operations to create, manage, and connect to &lt;a href=&quot;https://hathora.dev/docs/concepts/hathora-entities#room&quot;&gt;rooms&lt;/a&gt;.
        /// </summary>
        public IRoomV2SDK RoomV2 { get; }
    }
    
    public class SDKConfig
    {
    }

    public class HathoraCloudSDK: IHathoraCloudSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.hathora.dev",
            "/",
        };

        private const string _target = "unity";
        private const string _sdkVersion = "0.10.0";
        private const string _sdkGenVersion = "2.122.1";
        private const string _openapiDocVersion = "0.0.1";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IAppV1SDK AppV1 { get; private set; }
        public IAuthV1SDK AuthV1 { get; private set; }
        public IBillingV1SDK BillingV1 { get; private set; }
        public IBuildV1SDK BuildV1 { get; private set; }
        public IDeploymentV1SDK DeploymentV1 { get; private set; }
        public IDiscoveryV1SDK DiscoveryV1 { get; private set; }
        public ILobbyV1SDK LobbyV1 { get; private set; }
        public ILobbyV2SDK LobbyV2 { get; private set; }
        public ILogV1SDK LogV1 { get; private set; }
        public IManagementV1SDK ManagementV1 { get; private set; }
        public IMetricsV1SDK MetricsV1 { get; private set; }
        public IProcessesV1SDK ProcessesV1 { get; private set; }
        public IRoomV1SDK RoomV1 { get; private set; }
        public IRoomV2SDK RoomV2 { get; private set; }

        public HathoraCloudSDK(string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? HathoraCloudSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            Config = new SDKConfig()
            {
            };

            AppV1 = new AppV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            AuthV1 = new AuthV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            BillingV1 = new BillingV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            BuildV1 = new BuildV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            DeploymentV1 = new DeploymentV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            DiscoveryV1 = new DiscoveryV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            LobbyV1 = new LobbyV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            LobbyV2 = new LobbyV2SDK(_defaultClient, _securityClient, _serverUrl, Config);
            LogV1 = new LogV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            ManagementV1 = new ManagementV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            MetricsV1 = new MetricsV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            ProcessesV1 = new ProcessesV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            RoomV1 = new RoomV1SDK(_defaultClient, _securityClient, _serverUrl, Config);
            RoomV2 = new RoomV2SDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}