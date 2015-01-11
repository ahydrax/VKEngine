using System;
using System.Runtime.Serialization;

namespace Knfa.VK.Model
{
    [DataContract]
    public sealed class LinkInfo
    {
        [DataMember(Name = "status")]
        public string StatusValue { get; set; }

        [DataMember(Name = "link")]
        public Uri Link { get; set; }

        public LinkStatus Status
        {
            get
            {
                switch (StatusValue)
                {
                    case "not_banned":
                        return LinkStatus.NotBanned;
                    case "banned":
                        return LinkStatus.Banned;
                    case "processing":
                        return LinkStatus.Processing;
                    default:
                        return LinkStatus.None;
                }
            }
        }
    }
}
