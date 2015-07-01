using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Users
{
    [TestClass]
    public class UserFollowersTests : SoundCloudResourcesTestBase<User>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}/followers", userId);

            TestGetEntityList(expectedPath, () => SoundCloud.Users[userId].Followers.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}/followers", userId);

            TestGetEntityList(expectedPath, () => SoundCloud.Users[userId].Followers.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string followerId = "some followerId";
            var expectedPath = string.Format("/users/{0}/followers/{1}", userId, followerId);

            TestGetEntity(expectedPath, () => SoundCloud.Users[userId].Followers[followerId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string followerId = "some followerId";
            var expectedPath = string.Format("/users/{0}/followers/{1}", userId, followerId);

            TestGetEntity(expectedPath, () => SoundCloud.Users[userId].Followers[followerId].GetAsync());
        }
    }
}