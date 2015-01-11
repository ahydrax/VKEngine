using Knfa.VK;
using Xunit;

namespace VKTests
{
    public class ScopeHelperTests
    {
        [Fact]
        public void CreateStringTest()
        {
            var scope = Scope.Audio | Scope.Offline | Scope.Status;

            var scopeString = scope.CreateString();

            Assert.Equal("audio,status,offline", scopeString);
        }

        [Fact]
        public void CreateScopeTest()
        {
            var api = new VkApi();

            var response = api.Execute<int>(Methods.Account.GetAppPermissions.GetName(),
                TestsHelper.AccessToken,
                TestsHelper.ApiVersion);

            Scope scope = ScopeHelper.CreateScope(response.Result);

            Assert.Equal(Scope.Audio | Scope.Offline, scope);
        }
    }
}
