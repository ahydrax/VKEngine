using Knfa.VK;
using Xunit;

namespace VKTests
{
    public class MethodHelperTests
    {
        [Fact]
        public void GetApiMethodNameTest()
        {
            const string methodName = "audio.getBroadcastList";
            var method = Methods.Audio.GetBroadcastList;

            Assert.Equal(methodName, method.GetName());
        }
    }
}