using Knfa.VK.Model;
using System.Collections.Generic;

namespace Knfa.VK
{
    public static partial class Methods
    {
        /// <summary>
        /// Represents list of methods for working with audio.
        /// </summary>
        public enum Audio
        {
            /// <summary>
            /// Returns a list of user or community audios.
            /// Use <see cref="ItemCollection{T}"/> as response type parameter.
            /// </summary>
            Get,

            /// <summary>
            /// Returns audios info for specified audio ids.
            /// Use <see cref="IEnumerable{T}"/> as response type parameter.
            /// </summary>
            GetById,

            /// <summary>
            /// Returns audio lyrics for specified lyrics id.
            /// Use <see cref="Lyrics"/> as response type parameter.
            /// </summary>
            GetLyrics,

            /// <summary>
            /// Returns list of audios selected with specified search parameters.
            /// Use <see cref="ItemCollection{Audio}"/> as response type parameter.
            /// </summary>
            Search,

            /// <summary>
            /// Returns upload server url.
            /// Use <see cref="UploadServerInfo"/> as response type parameter.
            /// </summary>
            GetUploadServer,

            /// <summary>
            /// Returns audios info after successful upload.
            /// Use <see cref="IEnumerable{Audio}"/> as response type parameter.
            /// </summary>
            Save,

            /// <summary>
            /// Adds audio to user or community playlist.
            /// Returns new id for added audio.
            /// Use <see cref="int"/> as response type parameter.
            /// </summary>
            Add,

            /// <summary>
            /// Deletes audio from user or community playlist.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            Delete,

            /// <summary>
            /// Edits audio info in user or community playlist.
            /// Returns lyrics id if entered otherwise 0.
            /// Use <see cref="int"/> as response type parameter.
            /// </summary>
            Edit,

            /// <summary>
            /// Reorders audios in user or community playlist.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            Reorder,

            /// <summary>
            /// Restores audio after removing from playlist.
            /// Returns audio info if operation successful otherwise it returns error 202.
            /// Use <see cref="Audio"/> as response type parameter.
            /// </summary>
            Restore,

            /// <summary>
            /// Returns list of user or community music albums.
            /// Use <see cref="ItemCollection{MusicAlbum}"/> as response type parameter.
            /// </summary>
            GetAlbums,

            /// <summary>
            /// Creates empty music album for user or community.
            /// Returns new album id.
            /// Use <see cref="MusicAlbum"/> as response type parameter.
            /// </summary>
            AddAlbum,

            /// <summary>
            /// Edits music album title.
            /// Returns true if operation successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            EditAlbum,

            /// <summary>
            /// Removes music album.
            /// Returns true if operation successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            DeleteAlbum,

            /// <summary>
            /// Moves audios to music album.
            /// Returns true if operation successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            MoveToAlbum,

            /// <summary>
            /// Broadcasts audio in user or community status.
            /// Returns an array of users or communitys ids.
            /// Use <see cref="IEnumerable{Int32}"/> as response type parameter.
            /// </summary>
            SetBroadcast,

            /// <summary>
            /// Returns list of friend's or community's broadcasts.
            /// // TODO Investigate correct returning type
            /// </summary>
            GetBroadcastList,

            /// <summary>
            /// Returns list of recommended audios.
            /// Use <see cref="IEnumerable{Audio}"/> as response type parameter.
            /// </summary>
            GetRecommendations,

            /// <summary>
            /// Returns an array of popular music.
            /// Use <see cref="IEnumerable{Audio}"/> as response type parameter.
            /// </summary>
            GetPopular,

            /// <summary>
            /// Returns audios count.
            /// Use <see cref="int"/> as response type parameter.
            /// </summary>
            GetCount
        }
    }
}
