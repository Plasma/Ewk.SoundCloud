using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Users
{
    [TestClass]
    public class UserTracksTests : SoundCloudResourcesTestBase<Track>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}/tracks", userId);

            TestGetEntityList(expectedPath, () => SoundCloud.Users[userId].Tracks.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}/tracks", userId);

            TestGetEntityList(expectedPath, () => SoundCloud.Users[userId].Tracks.GetAsync());
        }
    }
}