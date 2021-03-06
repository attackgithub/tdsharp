using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class RemoveStickerFromSet : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "removeStickerFromSet";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public InputFile Sticker { get; set; }
        }
    }
}