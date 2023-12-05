
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace HathoraCloud.Models.Operations
{
    using HathoraCloud.Models.Shared;
    using System.Collections.Generic;
    using System;
    using UnityEngine.Networking;
    using UnityEngine;
    
    [Serializable]
    public class ListActivePublicLobbiesDeprecatedV2Response: IDisposable
    {

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        [SerializeField]
        public string? ContentType { get; set; } = default!;
        

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        [SerializeField]
        public int StatusCode { get; set; } = default!;
        

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        [SerializeField]
        public UnityWebRequest RawResponse { get; set; } = default!;
        

        /// <summary>
        /// Ok
        /// </summary>
        [SerializeField]
        public List<Lobby>? Classes { get; set; }
        
        public void Dispose() {
            if (RawResponse != null) {
                RawResponse.Dispose();
            }
        }
    }
}