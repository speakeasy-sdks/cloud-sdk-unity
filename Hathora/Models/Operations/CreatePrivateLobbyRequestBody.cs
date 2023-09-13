
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
    using Hathora.Models.Shared;
    using Newtonsoft.Json;
    using System;
    using UnityEngine;
    
    
    [Serializable]
    public class CreatePrivateLobbyRequestBody
    {
        /// <summary>
        /// User input to initialize the game state. Object must be smaller than 64KB.
        /// </summary>
        [SerializeField]
        [JsonProperty("initialConfig")]
        public LobbyInitialConfig InitialConfig { get; set; } = default!;
        
        [SerializeField]
        [JsonProperty("region")]
        public Region Region { get; set; } = default!;
        
    }
    
}