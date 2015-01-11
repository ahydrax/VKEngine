using System.Runtime.Serialization;

namespace Knfa.VK.Model
{
    [DataContract]
    public sealed class MusicAlbum
    {
        [DataMember(Name = "owner_id")]
        public int OwnerId { get; set; }

        [DataMember(Name = "album_id")]
        public int AlbumId { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}
