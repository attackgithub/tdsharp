using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatMemberStatus : Object
        {
            public class ChatMemberStatusRestricted : ChatMemberStatus
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatMemberStatusRestricted";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_member")]
                public bool IsMember { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("restricted_until_date")]
                public int RestrictedUntilDate { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_send_messages")]
                public bool CanSendMessages { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_send_media_messages")]
                public bool CanSendMediaMessages { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_send_other_messages")]
                public bool CanSendOtherMessages { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_add_web_page_previews")]
                public bool CanAddWebPagePreviews { get; set; }
            }
        }
    }
}