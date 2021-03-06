using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PassportElement : Object
        {
            public class PassportElementIdentityCard : PassportElement
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "passportElementIdentityCard";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("identity_card")]
                public IdentityDocument IdentityCard { get; set; }
            }
        }
    }
}