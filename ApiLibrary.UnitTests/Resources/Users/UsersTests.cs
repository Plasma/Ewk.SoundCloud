using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Users
{
    [TestClass]
    public class UsersTests : SoundCloudResourcesTestBase<User>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/users";

            TestGetEntityList(expectedPath, () => SoundCloud.Users.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/users";

            TestGetEntityList(expectedPath, () => SoundCloud.Users.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}", userId);

            TestGetEntity(expectedPath, () => SoundCloud.Users[userId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string userId = "some userId";
            var expectedPath = string.Format("/users/{0}", userId);

            TestGetEntity(expectedPath, () => SoundCloud.Users[userId].GetAsync());
        }
    }
}