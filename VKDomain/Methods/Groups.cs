namespace Knfa.VK
{
    public static partial class Methods
    {
        public enum Groups
        {
            /// <summary>
            /// Returns true if user subscribes to specified community.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            IsMember,

            /// <summary>
            /// Returns communitys info.
            /// </summary>
            GetById,

            /// <summary>
            /// Returns user list of communitys.
            /// </summary>
            Get,

            /// <summary>
            /// Returns list of community members.
            /// </summary>
            GetMembers,

            /// <summary>
            /// Joins to specified group, meeting or public page.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            Join,

            /// <summary>
            /// Leaves from specified group, meeting or public page.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            Leave,

            /// <summary>
            /// 
            /// </summary>
            Search,

            /// <summary>
            /// 
            /// </summary>
            GetInvites,

            /// <summary>
            /// 
            /// </summary>
            BanUser,

            /// <summary>
            /// 
            /// </summary>
            UnbanUser,

            /// <summary>
            /// 
            /// </summary>
            GetBanned
        }
    }
}
