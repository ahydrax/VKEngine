using Knfa.VK.Model;

namespace Knfa.VK
{
    public static partial class Methods
    {
        public enum Utils
        {
            /// <summary>
            /// //TODO
            /// Use <see cref="int"/> as response type parameter.
            /// </summary>
            CheckLink,

            /// <summary>
            /// Determines type of object (user, community, application) by specified object name.
            /// Returns object info.
            /// Use <see cref="ScreenNameInfo"/> as response type parameter.
            /// </summary>
            ResolveScreenName,

            /// <summary>
            /// Returns current server time in UNIX timestamp format.
            /// Use <see cref="int"/> as response type parameter.
            /// </summary>
            GetServerTime
        }
    }
}
