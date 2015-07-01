using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests.Resources.Comments
{
    [TestClass]
    public class CommentsTests : SoundCloudResourcesTestBase<Comment>
    {
        [TestMethod]
        public void When_a_Get_is_performed_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/comments";

            TestGetEntityList(expectedPath, () => SoundCloud.Comments.Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resourceList_via_the_library_then_the_relative_url_is_correct()
        {
            const string expectedPath = "/comments";

            TestGetEntityList(expectedPath, () => SoundCloud.Comments.GetAsync());
        }

        [TestMethod]
        public void When_a_Get_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string commentId = "some commentId";
            var expectedPath = string.Format("/comments/{0}", commentId);

            TestGetEntity(expectedPath, () => SoundCloud.Comments[commentId].Get());
        }

        [TestMethod]
        public void When_a_Get_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string commentId = "some commentId";
            var expectedPath = string.Format("/comments/{0}", commentId);

            TestGetEntity(expectedPath, () => SoundCloud.Comments[commentId].GetAsync());
        }

        [TestMethod]
        public void When_a_Put_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string commentId = "some commentId";
            var expectedPath = string.Format("/comments/{0}", commentId);

            TestPutEntity(expectedPath, entity => SoundCloud.Comments[commentId].Put(entity));
        }

        [TestMethod]
        public void When_a_Put_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string commentId = "some commentId";
            var expectedPath = string.Format("/comments/{0}", commentId);

            TestPutEntity(expectedPath, entity => SoundCloud.Comments[commentId].PutAsync(entity));
        }

        [TestMethod]
        public void When_a_Delete_is_performed_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string commentId = "some commentId";
            var expectedPath = string.Format("/comments/{0}", commentId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Comments[commentId].Delete());
        }

        [TestMethod]
        public void When_a_Delete_is_performed_Async_on_the_resource_via_the_library_then_the_relative_url_is_correct()
        {
            const string commentId = "some commentId";
            var expectedPath = string.Format("/comments/{0}", commentId);

            TestDeleteEntity(expectedPath, () => SoundCloud.Comments[commentId].DeleteAsync());
        }
    }
}