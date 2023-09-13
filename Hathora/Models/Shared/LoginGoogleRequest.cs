
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Hathora.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    using UnityEngine;
    
    
    [Serializable]
    public class LoginGoogleRequest
    {
        /// <summary>
        /// A Google-signed OIDC ID token representing a player's authenticated identity. Learn how to get an `idToken` [here](https://cloud.google.com/docs/authentication/get-id-token).
        /// </summary>
        [SerializeField]
        [JsonProperty("idToken")]
        public string IdToken { get; set; } = default!;
        
    }
    
}