using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Users
{
    [TestClass]
    public class UserFollowingsTests : SoundCloudResourcesTestBase<User>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}/followings", userId);

            TestGetEntityList(expectedPath, () => SoundCloud.Users[userId].Followings.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}/followings", userId);

            TestGetEntityList(expectedPath, () => SoundCloud.Users[userId].Followings.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string followingId = "some followingId";
            var expectedPath = string.Format("/users/{0}/followings/{1}", userId, followingId);

            TestGetEntity(expectedPath, () => SoundCloud.Users[userId].Followings[followingId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string followingId = "some followingId";
            var expectedPath = string.Format("/users/{0}/followings/{1}", userId, followingId);

            TestGetEntity(expectedPath, () => SoundCloud.Users[userId].Followings[followingId].GetAsync());
        }

        [TestMethod]
        public void When_a_Put_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string followingId = "some followingId";
            var expectedPath = string.Format("/users/{0}/followings/{1}", userId, followingId);

            TestPutEntity(expectedPath, entity => SoundCloud.Users[userId].Followings[followingId].Put(entity));
        }

        [TestMethod]
        public void When_a_Delete_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string followingId = "some followingId";
            var expectedPath = string.Format("/users/{0}/followings/{1}", userId, followingId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Users[userId].Followings[followingId].Delete());
        }

        [TestMethod]
        public void When_a_Delete_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string followingId = "some followingId";
            var expectedPath = string.Format("/users/{0}/followings/{1}", userId, followingId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Users[userId].Followings[followingId].DeleteAsync());
        }
    }
}