using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class PassportAuthorizationForm : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "passportAuthorizationForm";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("required_elements")]
            public PassportRequiredElement[] RequiredElements { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("elements")]
            public PassportElement[] Elements { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("errors")]
            public PassportElementError[] Errors { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("privacy_policy_url")]
            public string PrivacyPolicyUrl { get; set; }
        }
    }
}