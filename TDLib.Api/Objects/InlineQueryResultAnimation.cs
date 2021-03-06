using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InlineQueryResult : Object
        {
            public class InlineQueryResultAnimation : InlineQueryResult
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "inlineQueryResultAnimation";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("animation")]
                public Animation Animation { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }
            }
        }
    }
}