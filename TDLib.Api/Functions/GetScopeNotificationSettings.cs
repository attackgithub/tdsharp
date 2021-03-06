using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetScopeNotificationSettings : Function<ScopeNotificationSettings>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getScopeNotificationSettings";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("scope")]
            public NotificationSettingsScope Scope { get; set; }
        }
    }
}