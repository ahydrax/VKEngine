namespace Knfa.VK
{
    public static partial class Methods
    {
        public enum Users
        {
            /// <summary>
            /// Returns the extended user info.
            /// </summary>
            Get,

            /// <summary>
            /// Returns list of users with specified search parameters.
            /// </summary>
            Search,

            /// <summary>
            /// Returns true if user uses application.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            IsAppUser,

            /// <summary>
            /// Returns users' subscribers.
            /// </summary>
            GetSubscriptions,

            /// <summary>
            /// Returns users' followers.
            /// </summary>
            GetFollowers,

            /// <summary>
            /// Reports a user.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            Report
        }
    }
}
