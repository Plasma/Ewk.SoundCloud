using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Users
{
    [TestClass]
    public class MeConnectionsTests : SoundCloudResourcesTestBase<Connection>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/me/connections";

            TestGetEntityList(expectedPath, () => SoundCloud.Me.Connections.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/me/connections";

            TestGetEntityList(expectedPath, () => SoundCloud.Me.Connections.GetAsync());
        }

        [TestMethod]
        public void When_a_Post_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/me/connections";

            TestPostEntity(expectedPath, entity => SoundCloud.Me.Connections.Post(entity));
        }

        [TestMethod]
        public void When_a_Post_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/me/connections";

            TestPostEntity(expectedPath, entity => SoundCloud.Me.Connections.PostAsync(entity));
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string connectionId = "some connectionId";
            var expectedPath = string.Format("/me/connections/{0}", connectionId);

            TestGetEntity(expectedPath, () => SoundCloud.Me.Connections[connectionId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string connectionId = "some connectionId";
            var expectedPath = string.Format("/me/connections/{0}", connectionId);

            TestGetEntity(expectedPath, () => SoundCloud.Me.Connections[connectionId].GetAsync());
        }
    }
}