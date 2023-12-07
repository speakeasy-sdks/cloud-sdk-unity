
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

    /// <summary>
    /// Deprecated. Use <a href="https://hathora.dev/api#tag/LobbyV3">LobbyV3</a>.
    /// </summary>
    public interface ILobbyV2
    {

        /// <summary>
        /// Create a new lobby for an <a href="https://hathora.dev/docs/concepts/hathora-entities#application">application</a>. A lobby object is a wrapper around a <a href="https://hathora.dev/docs/concepts/hathora-entities#room">room</a> object. With a lobby, you get additional functionality like configuring the visibility of the room, managing the state of a match, and retrieving a list of public lobbies to display to players.
        /// </summary>
        Task<CreateLobbyDeprecatedResponse> CreateLobbyDeprecatedAsync(CreateLobbyDeprecatedSecurity security, CreateLobbyDeprecatedRequest request);
        Task<CreateLocalLobbyResponse> CreateLocalLobbyAsync(CreateLocalLobbySecurity security, CreateLocalLobbyRequest request);
        Task<CreatePrivateLobbyResponse> CreatePrivateLobbyAsync(CreatePrivateLobbySecurity security, CreatePrivateLobbyRequest request);
        Task<CreatePublicLobbyResponse> CreatePublicLobbyAsync(CreatePublicLobbySecurity security, CreatePublicLobbyRequest request);

        /// <summary>
        /// Get details for a lobby.
        /// </summary>
        Task<GetLobbyInfoResponse> GetLobbyInfoAsync(GetLobbyInfoRequest? request = null);

        /// <summary>
        /// Get all active lobbies for a an <a href="https://hathora.dev/docs/concepts/hathora-entities#application">application</a>. Filter by optionally passing in a `region`. Use this endpoint to display all public lobbies that a player can join in the game client.
        /// </summary>
        Task<ListActivePublicLobbiesDeprecatedV2Response> ListActivePublicLobbiesDeprecatedV2Async(ListActivePublicLobbiesDeprecatedV2Request? request = null);

        /// <summary>
        /// Set the state of a lobby. State is intended to be set by the server and must be smaller than 1MB. Use this endpoint to store match data like live player count to enforce max number of clients or persist end-game data (i.e. winner or final scores).
        /// </summary>
        Task<SetLobbyStateResponse> SetLobbyStateAsync(SetLobbyStateRequest request);
    }

    /// <summary>
    /// Deprecated. Use <a href="https://hathora.dev/api#tag/LobbyV3">LobbyV3</a>.
    /// </summary>
    public class LobbyV2: ILobbyV2
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _target = "unity";
        private const string _sdkVersion = "0.27.1";
        private const string _sdkGenVersion = "2.210.6";
        private const string _openapiDocVersion = "0.0.1";
        private const string _userAgent = "speakeasy-sdk/unity 0.27.1 2.210.6 0.0.1 hathora-cloud";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public LobbyV2(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreateLobbyDeprecatedResponse> CreateLobbyDeprecatedAsync(CreateLobbyDeprecatedSecurity security, CreateLobbyDeprecatedRequest request)
        {
            request.AppId ??= SDKConfiguration.AppId;
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/create", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "CreateLobbyParams", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = SecuritySerializer.Apply(_defaultClient, security);
            
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
            
            var response = new CreateLobbyDeprecatedResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 422) || (response.StatusCode == 429) || (response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiError = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreateLocalLobbyResponse> CreateLocalLobbyAsync(CreateLocalLobbySecurity security, CreateLocalLobbyRequest request)
        {
            request.AppId ??= SDKConfiguration.AppId;
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/create/local", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = SecuritySerializer.Apply(_defaultClient, security);
            
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
            
            var response = new CreateLocalLobbyResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 422) || (response.StatusCode == 429) || (response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiError = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreatePrivateLobbyResponse> CreatePrivateLobbyAsync(CreatePrivateLobbySecurity security, CreatePrivateLobbyRequest request)
        {
            request.AppId ??= SDKConfiguration.AppId;
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/create/private", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = SecuritySerializer.Apply(_defaultClient, security);
            
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
            
            var response = new CreatePrivateLobbyResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 422) || (response.StatusCode == 429) || (response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiError = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<CreatePublicLobbyResponse> CreatePublicLobbyAsync(CreatePublicLobbySecurity security, CreatePublicLobbyRequest request)
        {
            request.AppId ??= SDKConfiguration.AppId;
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/create/public", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = SecuritySerializer.Apply(_defaultClient, security);
            
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
            
            var response = new CreatePublicLobbyResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 401) || (response.StatusCode == 404) || (response.StatusCode == 422) || (response.StatusCode == 429) || (response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiError = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<GetLobbyInfoResponse> GetLobbyInfoAsync(GetLobbyInfoRequest? request = null)
        {
            request.AppId ??= SDKConfiguration.AppId;
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/info/{roomId}", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
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
            
            var response = new GetLobbyInfoResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 404))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiError = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<ListActivePublicLobbiesDeprecatedV2Response> ListActivePublicLobbiesDeprecatedV2Async(ListActivePublicLobbiesDeprecatedV2Request? request = null)
        {
            request.AppId ??= SDKConfiguration.AppId;
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/list/public", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
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
            
            var response = new ListActivePublicLobbiesDeprecatedV2Response
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Classes = JsonConvert.DeserializeObject<List<Lobby>>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
        public async Task<SetLobbyStateResponse> SetLobbyStateAsync(SetLobbyStateRequest request)
        {
            request.AppId ??= SDKConfiguration.AppId;
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/lobby/v2/{appId}/setState/{roomId}", request);
            

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "SetLobbyStateParams", "json");
            if (serializedBody == null) 
            {
                throw new ArgumentNullException("request body is required");
            }
            else
            {
                httpRequest.uploadHandler = new UploadHandlerRaw(serializedBody.Body);
                httpRequest.SetRequestHeader("Content-Type", serializedBody.ContentType);
            }
            
            var client = _securityClient;
            
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
            
            var response = new SetLobbyStateResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Lobby = JsonConvert.DeserializeObject<Lobby>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 404) || (response.StatusCode == 422))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiError = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        
    }
}