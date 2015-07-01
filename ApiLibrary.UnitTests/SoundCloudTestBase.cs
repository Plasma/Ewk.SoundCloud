using Ewk.UnitTests;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests
{
    public abstract class SoundCloudTestBase : UnitTestBase 
    {
        protected ISoundCloudClient SoundCloudClient { get; private set; }
        protected SoundCloud SoundCloud { get; private set; }

        protected override void AdditionalSetup()
        {
            SoundCloudClient = MockHelper.CreateMock<ISoundCloudClient>();
            SoundCloud = new SoundCloud(SoundCloudClient);
        }
   }
}