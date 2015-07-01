using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Users
{
    [TestClass]
    public class UserFavoritesTests : SoundCloudResourcesTestBase<Track>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}/favorites", userId);

            TestGetEntityList(expectedPath, () => SoundCloud.Users[userId].Favorites.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}/favorites", userId);

            TestGetEntityList(expectedPath, () => SoundCloud.Users[userId].Favorites.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string favoriteId = "some favoriteId";
            var expectedPath = string.Format("/users/{0}/favorites/{1}", userId, favoriteId);

            TestGetEntity(expectedPath, () => SoundCloud.Users[userId].Favorites[favoriteId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string favoriteId = "some favoriteId";
            var expectedPath = string.Format("/users/{0}/favorites/{1}", userId, favoriteId);

            TestGetEntity(expectedPath, () => SoundCloud.Users[userId].Favorites[favoriteId].GetAsync());
        }

        [TestMethod]
        public void When_a_Put_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string favoriteId = "some favoriteId";
            var expectedPath = string.Format("/users/{0}/favorites/{1}", userId, favoriteId);

            TestPutEntity(expectedPath, entity => SoundCloud.Users[userId].Favorites[favoriteId].Put(entity));
        }

        [TestMethod]
        public void When_a_Delete_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string favoriteId = "some favoriteId";
            var expectedPath = string.Format("/users/{0}/favorites/{1}", userId, favoriteId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Users[userId].Favorites[favoriteId].Delete());
        }

        [TestMethod]
        public void When_a_Delete_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            const string favoriteId = "some favoriteId";
            var expectedPath = string.Format("/users/{0}/favorites/{1}", userId, favoriteId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Users[userId].Favorites[favoriteId].DeleteAsync());
        }
    }
}