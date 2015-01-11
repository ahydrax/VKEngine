using Knfa.VK;
using Knfa.VK.Model;
using Xunit;

namespace VKTests
{
    public class AccountTests
    {
        [Fact]
        public void GetCountersTest()
        {
            var api = new VkApi(); 

            var counters = api.Execute<Counters>(Methods.Account.GetCounters.GetName(),
                TestsHelper.AccessToken,
                TestsHelper.ApiVersion).Result;

            Assert.NotNull(counters);   
        }

        [Fact]
        public void GetAppPermissionsTest()
        {
            var api = new VkApi();
            var scope = Scope.Offline | Scope.Audio;

            var currentScopeBitmask = api.Execute<int>(Methods.Account.GetAppPermissions.GetName(), 
                TestsHelper.AccessToken,
                TestsHelper.ApiVersion).Result;

            var currentScope = ScopeHelper.CreateScope(currentScopeBitmask);

            Assert.Equal(scope, currentScope);
        }
    }
}
