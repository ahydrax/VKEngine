using Knfa.VK;
using Knfa.VK.Model;
using System;
using System.Diagnostics;
using Xunit;

namespace VKTests
{
    public class UtilsTests
    {
        [Fact]
        public void CheckLinkTest()
        {
            const string url = "http://google.ru";
            var api = new VkApi();

            var response = api.Execute<LinkInfo>(Methods.Utils.CheckLink.GetName(),
                Argument.Create("url", url),
                TestsHelper.ApiVersion).Result;

            Assert.Equal(LinkStatus.NotBanned, response.Status);
        }

        [Fact]
        public void ResolveScreenNameTest()
        {   
            const string screenName = "ahydrax";
            const int objectId = 224581747;
            var api = new VkApi();

            var response = api.Execute<ScreenNameInfo>(Methods.Utils.ResolveScreenName.GetName(),
                Argument.Create("screen_name", screenName),
                TestsHelper.ApiVersion).Result;

            Assert.Equal(ObjectType.User, response.Type);
            Assert.Equal(objectId, response.ObjectId);
        }

        [Fact]
        public void GetServerTimeTest()
        {
            var api = new VkApi();

            var response = api.Execute<int>(Methods.Utils.GetServerTime.GetName()).Result;
            var serverTime = TestsHelper.UnixEpoch.AddSeconds(response);

            Trace.WriteLine(String.Format("Server time: {0}", serverTime.ToLocalTime()));

            Assert.Equal(DateTime.Now.ToUniversalTime().Date, serverTime.Date);
        }
    }
}
