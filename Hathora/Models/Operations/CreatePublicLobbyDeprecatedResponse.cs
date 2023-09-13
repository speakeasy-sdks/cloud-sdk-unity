
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Models.Operations
{
    using System;
    using UnityEngine.Networking;
    using UnityEngine;
    
    
    [Serializable]
    public class CreatePublicLobbyDeprecatedResponse: IDisposable
    {
        [SerializeField]
        public string? ContentType { get; set; } = default!;
        
        [SerializeField]
        public string? CreatePublicLobbyDeprecated400ApplicationJSONString { get; set; }
        
        [SerializeField]
        public string? CreatePublicLobbyDeprecated401ApplicationJSONString { get; set; }
        
        [SerializeField]
        public string? CreatePublicLobbyDeprecated404ApplicationJSONString { get; set; }
        
        [SerializeField]
        public string? CreatePublicLobbyDeprecated422ApplicationJSONString { get; set; }
        
        [SerializeField]
        public string? CreatePublicLobbyDeprecated429ApplicationJSONString { get; set; }
        
        [SerializeField]
        public string? CreatePublicLobbyDeprecated500ApplicationJSONString { get; set; }
        
        /// <summary>
        /// Ok
        /// </summary>
        [SerializeField]
        public string? RoomId { get; set; }
        
        [SerializeField]
        public int StatusCode { get; set; } = default!;
        
        [SerializeField]
        public UnityWebRequest? RawResponse { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
    
}