
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
    /// Operations that allow you configure and manage an application&apos;s <a href="https://hathora.dev/docs/concepts/hathora-entities#build">build</a> at runtime.
    /// </summary>
    public interface IDeploymentV1
    {

        /// <summary>
        /// Create a new <a href="https://hathora.dev/docs/concepts/hathora-entities#deployment">deployment</a>. Creating a new deployment means all new rooms created will use the latest deployment configuration, but existing games in progress will not be affected.
        /// </summary>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request);

        /// <summary>
        /// Get details for a <a href="https://hathora.dev/docs/concepts/hathora-entities#deployment">deployment</a>.
        /// </summary>
        Task<GetDeploymentInfoResponse> GetDeploymentInfoAsync(GetDeploymentInfoRequest? request = null);

        /// <summary>
        /// Returns an array of <a href="https://hathora.dev/docs/concepts/hathora-entities#deployment">deployments</a> for an <a href="https://hathora.dev/docs/concepts/hathora-entities#application">application</a>.
        /// </summary>
        Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest? request = null);
    }

    /// <summary>
    /// Operations that allow you configure and manage an application&apos;s <a href="https://hathora.dev/docs/concepts/hathora-entities#build">build</a> at runtime.
    /// </summary>
    public class DeploymentV1: IDeploymentV1
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _target = "unity";
        private const string _sdkVersion = "0.28.4";
        private const string _sdkGenVersion = "2.239.0";
        private const string _openapiDocVersion = "0.0.1";
        private const string _userAgent = "speakeasy-sdk/unity 0.28.4 2.239.0 0.0.1 hathora-cloud";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public DeploymentV1(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request)
        {
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/deployments/v1/{appId}/create/{buildId}", request);
            
            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbPOST);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);
            
            var serializedBody = RequestBodySerializer.Serialize(request, "DeploymentConfig", "json");
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
            
            var response = new CreateDeploymentResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 201))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Deployment = JsonConvert.DeserializeObject<Deployment>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode == 400) || (response.StatusCode == 404) || (response.StatusCode == 500))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.ApiError = JsonConvert.DeserializeObject<ApiError>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }
                
                return response;
            }
            return response;
        }
        

        public async Task<GetDeploymentInfoResponse> GetDeploymentInfoAsync(GetDeploymentInfoRequest? request = null)
        {
            if (request == null)
            {
                request = new GetDeploymentInfoRequest();
            }
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/deployments/v1/{appId}/info/{deploymentId}", request);
            
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
            
            var response = new GetDeploymentInfoResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Deployment = JsonConvert.DeserializeObject<Deployment>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
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
        

        public async Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest? request = null)
        {
            if (request == null)
            {
                request = new GetDeploymentsRequest();
            }
            request.AppId ??= SDKConfiguration.AppId;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/deployments/v1/{appId}/list", request);
            
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
            
            var response = new GetDeploymentsResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Classes = JsonConvert.DeserializeObject<List<Deployment>>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
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
        
    }
}