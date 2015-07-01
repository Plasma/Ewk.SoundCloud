using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Tracks
{
    [TestClass]
    public class TrackFavoritersTests : SoundCloudResourcesTestBase<User>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}/favoriters", trackId);

            TestGetEntityList(expectedPath, () => SoundCloud.Tracks[trackId].Favoriters.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}/favoriters", trackId);

            TestGetEntityList(expectedPath, () => SoundCloud.Tracks[trackId].Favoriters.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            const string favoriterId = "some favoriterId";
            var expectedPath = string.Format("/tracks/{0}/favoriters/{1}", trackId, favoriterId);

            TestGetEntity(expectedPath, () => SoundCloud.Tracks[trackId].Favoriters[favoriterId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            const string favoriterId = "some favoriterId";
            var expectedPath = string.Format("/tracks/{0}/favoriters/{1}", trackId, favoriterId);

            TestGetEntity(expectedPath, () => SoundCloud.Tracks[trackId].Favoriters[favoriterId].GetAsync());
        }
    }
}