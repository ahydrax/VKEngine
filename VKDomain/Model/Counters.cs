using System.Runtime.Serialization;

namespace Knfa.VK.Model
{
    [DataContract]
    public class Counters
    {
        [DataMember(Name = "friends")]
        public int Friends { get; set; }

        [DataMember(Name = "messages")]
        public int Messages { get; set; }

        [DataMember(Name = "photos")]
        public int Photos { get; set; }

        [DataMember(Name = "videos")]
        public int Videos { get; set; }

        [DataMember(Name = "notes")]
        public int Notes { get; set; }

        [DataMember(Name = "gifts")]
        public int Gifts { get; set; }

        [DataMember(Name = "events")]
        public int Events { get; set; }

        [DataMember(Name = "groups")]
        public int Groups { get; set; }

        [DataMember(Name = "notifications")]
        public int Notifications { get; set; }
    }
}