using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Users
{
    [TestClass]
    public class MeTests : SoundCloudResourcesTestBase<UserMe>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/me";

            TestGetEntity(expectedPath, () => SoundCloud.Me.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/me";

            TestGetEntity(expectedPath, () => SoundCloud.Me.GetAsync());
        }
    }
}