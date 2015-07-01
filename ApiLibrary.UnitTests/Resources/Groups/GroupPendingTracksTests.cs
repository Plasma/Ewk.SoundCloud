using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Groups
{
    [TestClass]
    public class GroupPendingTrackTests : SoundCloudResourcesTestBase<Track>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            var expectedPath = string.Format("/groups/{0}/pending_tracks", groupId);

            TestGetEntityList(expectedPath, () => SoundCloud.Groups[groupId].PendingTracks.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            var expectedPath = string.Format("/groups/{0}/pending_tracks", groupId);

            TestGetEntityList(expectedPath, () => SoundCloud.Groups[groupId].PendingTracks.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            const string trackId = "some trackId";
            var expectedPath = string.Format("/groups/{0}/pending_tracks/{1}", groupId, trackId);

            TestGetEntity(expectedPath, () => SoundCloud.Groups[groupId].PendingTracks[trackId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            const string trackId = "some trackId";
            var expectedPath = string.Format("/groups/{0}/pending_tracks/{1}", groupId, trackId);

            TestGetEntity(expectedPath, () => SoundCloud.Groups[groupId].PendingTracks[trackId].GetAsync());
        }

        [TestMethod]
        public void When_a_Put_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            const string trackId = "some trackId";
            var expectedPath = string.Format("/groups/{0}/pending_tracks/{1}", groupId, trackId);

            TestPutEntity(expectedPath, entity => SoundCloud.Groups[groupId].PendingTracks[trackId].Put(entity));
        }

        [TestMethod]
        public void When_a_Delete_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            const string trackId = "some trackId";
            var expectedPath = string.Format("/groups/{0}/pending_tracks/{1}", groupId, trackId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Groups[groupId].PendingTracks[trackId].Delete());
        }

        [TestMethod]
        public void When_a_Delete_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string groupId = "some groupId";
            const string trackId = "some trackId";
            var expectedPath = string.Format("/groups/{0}/pending_tracks/{1}", groupId, trackId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Groups[groupId].PendingTracks[trackId].DeleteAsync());
        }
    }
}