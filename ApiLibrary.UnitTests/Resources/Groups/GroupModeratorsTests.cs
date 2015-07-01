using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Groups
{
    [TestClass]
    public class GroupModeratorsTests : SoundCloudResourcesTestBase<User>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            var expectedPath = string.Format("/groups/{0}/moderators", groupId);

            TestGetEntityList(expectedPath, () => SoundCloud.Groups[groupId].Moderators.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            var expectedPath = string.Format("/groups/{0}/moderators", groupId);

            TestGetEntityList(expectedPath, () => SoundCloud.Groups[groupId].Moderators.GetAsync());
        }
    }
}