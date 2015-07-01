#if DEBUG
using System;
using System.Diagnostics;
using Ewk.SoundCloud.ApiLibrary.Entities;
using Ewk.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests
{
    [TestClass]
    public class SoundCloudClientTests : UnitTestBase
    {
        private const string ClientId = "db840ada2477a93d5fdbcc96a46b37c1"; // Not my own, but some clientId I found on soundcloud

        private SoundCloudClient SoundCloudClient { get; set; }

        protected override void AdditionalSetup()
        {
            SoundCloudClient = new SoundCloudClient(ClientId);
        }

        [TestMethod, Ignore]
        public void Get_something()
        {
            try
            {
                //var entity = SoundCloudClient.GetAsync<dynamic>("https://api.soundcloud.com/me").Result;
                //var entity = SoundCloudClient.GetPageAsync<WebProfile>("https://api.soundcloud.com/users/473781/web-profiles").Result;
                var entity = SoundCloudClient.GetAsync<dynamic>("https://api.soundcloud.com/tracks/62838515/shared-to/users").Result;
                //var entity = SoundCloudClient.GetAsync<dynamic>("https://api.soundcloud.com/tracks/62838515/shared-to/emails").Result;
                //var entity = SoundCloudClient.GetAsync<dynamic>("https://api.soundcloud.com/tracks/62838515/secret-token").Result;
                //var entity = SoundCloudClient.GetAsync<dynamic>("https://api.soundcloud.com/tracks/62838515").Result;

                Assert.IsNotNull(entity);
            }
            catch (AggregateException ex)
            {
                var innerEx = (SoundCloudException) ex.InnerException;
                Assert.IsNotNull(innerEx.Errors);
            }
        }
    }
}
#endif