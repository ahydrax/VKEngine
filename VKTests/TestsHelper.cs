using System;
using System.Diagnostics;
using Knfa.VK;
using Knfa.VK.Model;

namespace VKTests
{
    internal static class TestsHelper
    {
        public static readonly Argument AccessToken = Argument.Create("access_token",
            "29144fd4099b60db48360c141a2b83229047deb65ad85b91c064e147e6beadd1b284beafcbe055e5c0b2a");

        public static readonly Argument ApiVersion = Argument.Create("v", "5.8");

        public static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0,
                                                          DateTimeKind.Utc);

        public const int UserId = 224581747;

        public static void TraceAudioInfo(Audio audio)
        {
            Trace.WriteLine(String.Format("{0} - {1} ({2} secs)",
                audio.Artist,
                audio.Title,
                audio.Duration));
        }
    }
}
