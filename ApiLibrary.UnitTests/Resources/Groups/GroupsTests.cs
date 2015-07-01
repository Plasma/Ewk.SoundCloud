using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Groups
{
    [TestClass]
    public class GroupsTests : SoundCloudResourcesTestBase<Group>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/groups";

            TestGetEntityList(expectedPath, () => SoundCloud.Groups.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/groups";

            TestGetEntityList(expectedPath, () => SoundCloud.Groups.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            var expectedPath = string.Format("/groups/{0}", groupId);

            TestGetEntity(expectedPath, () => SoundCloud.Groups[groupId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_Async_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            var expectedPath = string.Format("/groups/{0}", groupId);

            TestGetEntity(expectedPath, () => SoundCloud.Groups[groupId].GetAsync());
        }
    }
}