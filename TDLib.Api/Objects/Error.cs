using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class Error : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "error";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("code")]
            public int Code { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("message")]
            public string Message { get; set; }
        }
    }
}