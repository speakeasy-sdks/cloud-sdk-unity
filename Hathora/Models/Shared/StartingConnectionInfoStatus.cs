
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
    
    
    public enum StartingConnectionInfoStatus
    {
    	[JsonProperty("starting")]
		Starting,
    }
    
    public static class StartingConnectionInfoStatusExtension
    {
        public static string Value(this StartingConnectionInfoStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static StartingConnectionInfoStatus ToEnum(this string value)
        {
            foreach(var field in typeof(StartingConnectionInfoStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (StartingConnectionInfoStatus)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum StartingConnectionInfoStatus");
        }
    }
    
}