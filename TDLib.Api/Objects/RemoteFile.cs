using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class RemoteFile : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "remoteFile";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_uploading_active")]
            public bool IsUploadingActive { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_uploading_completed")]
            public bool IsUploadingCompleted { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("uploaded_size")]
            public int UploadedSize { get; set; }
        }
    }
}