using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Tracks
{
    [TestClass]
    public class TrackCommentsTests : SoundCloudResourcesTestBase<Comment>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}/comments", trackId);

            TestGetEntityList(expectedPath, () => SoundCloud.Tracks[trackId].Comments.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            var expectedPath = string.Format("/tracks/{0}/comments", trackId);

            TestGetEntityList(expectedPath, () => SoundCloud.Tracks[trackId].Comments.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            const string commentId = "some commentId";
            var expectedPath = string.Format("/tracks/{0}/comments/{1}", trackId, commentId);

            TestGetEntity(expectedPath, () => SoundCloud.Tracks[trackId].Comments[commentId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            const string commentId = "some commentId";
            var expectedPath = string.Format("/tracks/{0}/comments/{1}", trackId, commentId);

            TestGetEntity(expectedPath, () => SoundCloud.Tracks[trackId].Comments[commentId].GetAsync());
        }

        [TestMethod]
        public void When_a_Put_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            const string commentId = "some commentId";
            var expectedPath = string.Format("/tracks/{0}/comments/{1}", trackId, commentId);

            TestPutEntity(expectedPath, entity => SoundCloud.Tracks[trackId].Comments[commentId].Put(entity));
        }

        [TestMethod]
        public void When_a_Put_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            const string commentId = "some commentId";
            var expectedPath = string.Format("/tracks/{0}/comments/{1}", trackId, commentId);

            TestPutEntity(expectedPath, entity => SoundCloud.Tracks[trackId].Comments[commentId].PutAsync(entity));
        }

        [TestMethod]
        public void When_a_Delete_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            const string commentId = "some commentId";
            var expectedPath = string.Format("/tracks/{0}/comments/{1}", trackId, commentId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Tracks[trackId].Comments[commentId].Delete());
        }

        [TestMethod]
        public void When_a_Delete_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string trackId = "some trackId";
            const string commentId = "some commentId";
            var expectedPath = string.Format("/tracks/{0}/comments/{1}", trackId, commentId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Tracks[trackId].Comments[commentId].DeleteAsync());
        }
    }
}