using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Playlists
{
    [TestClass]
    public class PlaylistsTests : SoundCloudResourcesTestBase<Playlist>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/playlists";

            TestGetEntityList(expectedPath, () => SoundCloud.Playlists.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/playlists";

            TestGetEntityList(expectedPath, () => SoundCloud.Playlists.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string playListId = "some playlistId";
            var expectedPath = string.Format("/playlists/{0}", playListId);

            TestGetEntity(expectedPath, () => SoundCloud.Playlists[playListId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_Async_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string playListId = "some playlistId";
            var expectedPath = string.Format("/playlists/{0}", playListId);

            TestGetEntity(expectedPath, () => SoundCloud.Playlists[playListId].GetAsync());
        }
    }
}