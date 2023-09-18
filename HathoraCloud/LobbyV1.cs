
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
    using HathoraCloud.Models.Operations;
    using HathoraCloud.Models.Shared;
    using HathoraCloud.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System;
    using UnityEngine.Networking;

    public interface ILobbyV1SDK
    {
        Task<CreatePrivateLobbyDeprecatedResponse> CreatePrivateLobbyDeprecatedAsync(CreatePrivateLobbyDeprecatedRequest? request = null);
        Task<CreatePublicLobbyDeprecatedResponse> CreatePublicLobbyDeprecatedAsync(CreatePublicLobbyDeprecatedRequest? request = null);
        Task<ListActivePublicLobbiesDeprecatedResponse> ListActivePublicLobbiesDeprecatedAsync(ListActivePublicLobbiesDeprecatedRequest? request = null);
    }

    public class LobbyV1SDK: ILobbyV1SDK
    {
        public SDKConfig Config { get; private set; }
        private const string _target = "unity";
        private const string _sdkVersion = "0.7.0";
        private const string _sdkGenVersion = "2.115.2";
        private const string _openapiDocVersion = "0.0.1";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public LobbyV1SDK(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            Config = config;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreatePrivateLobbyDeprecatedResponse> CreatePrivateLobbyDeprecatedAsync(CreatePrivateLobbyDeprecatedRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v1/{appId}/create/private", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new CreatePrivateLobbyDeprecatedResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.RoomId = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobbyDeprecated400ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobbyDeprecated401ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobbyDeprecated404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 422))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobbyDeprecated422ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobbyDeprecated429ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePrivateLobbyDeprecated500ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreatePublicLobbyDeprecatedResponse> CreatePublicLobbyDeprecatedAsync(CreatePublicLobbyDeprecatedRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v1/{appId}/create/public", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new CreatePublicLobbyDeprecatedResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.RoomId = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 400))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobbyDeprecated400ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobbyDeprecated401ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobbyDeprecated404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 422))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobbyDeprecated422ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 429))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobbyDeprecated429ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.CreatePublicLobbyDeprecated500ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<ListActivePublicLobbiesDeprecatedResponse> ListActivePublicLobbiesDeprecatedAsync(ListActivePublicLobbiesDeprecatedRequest? request = null)
        {
            string baseUrl = _serverUrl;
            if (baseUrl.EndsWith("/"))
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v1/{appId}/list", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", $"speakeasy-sdk/{_target} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);
            
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");
            var response = new ListActivePublicLobbiesDeprecatedResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobbies = JsonConvert.DeserializeObject<List<Lobby>>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter() }});
                }
                
                return response;
            }
            if((response.StatusCode == 401))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ListActivePublicLobbiesDeprecated401ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ListActivePublicLobbiesDeprecated404ApplicationJSONString = httpResponse.downloadHandler.text;
                }
                
                return response;
            }
            return response;
        }
        
    }
}