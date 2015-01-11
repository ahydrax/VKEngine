using System.Runtime.Serialization;

namespace Knfa.VK.Model
{
    [DataContract]
    public sealed class Lyrics
    {
        [DataMember(Name = "lyrics_id")]
        public int Id { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}