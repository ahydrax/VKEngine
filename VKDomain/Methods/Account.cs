using Knfa.VK.Model;

namespace Knfa.VK
{
    public static partial class Methods
    {
        public enum Account
        {
            /// <summary>
            /// Returns nonzero values of user counters (messages, notes, etc).
            /// Use <see cref="Counters"/> as response type parameter.
            /// </summary>
            GetCounters,

            /// <summary>
            /// 
            /// </summary>
            SetNameInMenu,

            /// <summary>
            /// Sets user status as online.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            SetOnline,

            /// <summary>
            /// Sets user status as offline.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            SetOffline,

            /// <summary>
            /// 
            /// </summary>
            LookupContacts,

            /// <summary>
            /// 
            /// </summary>
            RegisterDevice,

            /// <summary>
            /// 
            /// </summary>
            UnregisterDevice,

            /// <summary>
            /// 
            /// </summary>
            SetSilenceMode,

            /// <summary>
            /// 
            /// </summary>
            GetPushSettings,

            /// <summary>
            /// Returns bit mask of current application permissions.
            /// Use <see cref="int"/> as response type parameter.
            /// </summary>
            GetAppPermissions,

            /// <summary>
            /// 
            /// </summary>
            GetActiveOffers,

            /// <summary>
            /// Adds user to blacklist.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            BanUser,

            /// <summary>
            /// Removes user from blacklist.
            /// Returns true if operation was successful.
            /// Use <see cref="bool"/> as response type parameter.
            /// </summary>
            UnbanUser,

            /// <summary>
            /// 
            /// </summary>
            GetBanned,

            /// <summary>
            /// 
            /// </summary>
            GetInfo,

            /// <summary>
            /// 
            /// </summary>
            SetInfo,

            /// <summary>
            /// 
            /// </summary>
            ChangePassword,

            /// <summary>
            /// 
            /// </summary>
            GetProfileInfo,

            /// <summary>
            /// 
            /// </summary>
            SaveProfileInfo
        }
    }
}
