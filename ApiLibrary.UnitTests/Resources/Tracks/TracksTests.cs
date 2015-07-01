using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Tracks
{
    [TestClass]
    public class TracksTests : SoundCloudResourcesTestBase<Track>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/tracks";

            TestGetEntityList(expectedPath, () => SoundCloud.Tracks.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/tracks";

            TestGetEntityList(expectedPath, () => SoundCloud.Tracks.GetAsync());
        }

        [TestMethod]
        public void When_a_Post_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/tracks";

            TestPostEntity(expectedPath, entity => SoundCloud.Tracks.Post(entity));
        }

        [TestMethod]
        public void When_a_Post_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/tracks";

            TestPostEntity(expectedPath, entity => SoundCloud.Tracks.PostAsync(entity));
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}", trackId);

            TestGetEntity(expectedPath, () => SoundCloud.Tracks[trackId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}", trackId);

            TestGetEntity(expectedPath, () => SoundCloud.Tracks[trackId].GetAsync());
        }

        [TestMethod]
        public void When_a_Put_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}", trackId);

            TestPutEntity(expectedPath, entity => SoundCloud.Tracks[trackId].Put(entity));
        }

        [TestMethod]
        public void When_a_Put_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}", trackId);

            TestPutEntity(expectedPath, entity => SoundCloud.Tracks[trackId].PutAsync(entity));
        }

        [TestMethod]
        public void When_a_Delete_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}", trackId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Tracks[trackId].Delete());
        }

        [TestMethod]
        public void When_a_Delete_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}", trackId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Tracks[trackId].DeleteAsync());
        }
    }
}