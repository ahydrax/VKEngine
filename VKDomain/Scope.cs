using System;

namespace Knfa.VK
{
    [Flags]
    public enum Scope
    {
        Notify = 1,
        Friends = 2,
        Photos = 4,
        Audio = 8,
        Video = 16,
        Pages = 128,
        AppLink = 256,
        Status = 1024,
        Notes = 2048,
        Messages = 4096,
        Wall = 8192,
        Ads = 32768,
        Offline = 65536,
        Docs = 131072,
        Groups = 262144,
        Notifications = 524288,
        Stats = 1048675
    }
}
