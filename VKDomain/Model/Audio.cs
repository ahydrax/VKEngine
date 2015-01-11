using System;
using System.Runtime.Serialization;

namespace Knfa.VK.Model
{
    /// <summary>
    /// Represents VKApi Audio object.
    /// </summary>
    [DataContract]
    public class Audio
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "owner_id")]
        public int OwnerId { get; set; }

        [DataMember(Name = "artist")]
        public string Artist { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        [DataMember(Name = "url")]
        public Uri Uri { get; set; }

        [DataMember(Name = "lyrics_id")]
        public int LyricsId { get; set; }

        [DataMember(Name = "album_id")]
        public int AlbumsId { get; set; }

        [DataMember(Name = "genre_id")]
        public int GenreId { get; set; }

    }
}