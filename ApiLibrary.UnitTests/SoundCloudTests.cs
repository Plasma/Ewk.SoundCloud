#if DEBUG
using System;
using System.Linq;
using Ewk.SoundCloud.ApiLibrary.Entities;
using Ewk.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests
{
    [TestClass]
    public class SoundCloudTests : UnitTestBase
    {
        protected SoundCloud SoundCloud { get; private set; }

        protected override void AdditionalSetup()
        {
            const string clientId = "db840ada2477a93d5fdbcc96a46b37c1"; // Not my own, but some clientId I found on soundcloud
            SoundCloud = new SoundCloud(clientId);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Throws_ArgumentNullException_When_The_SoundCloudClient_Is_Null()
        {
            var soundCloud = new SoundCloud((ISoundCloudClient)null);
        }

        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_Throws_ArgumentNullException_When_The_ClientId_Is_Null()
        {
            var soundCloud = new SoundCloud((string)null);
        }

        [TestMethod, Ignore]
        public void Get_Me()
        {
            var entity = SoundCloud.Me.Get();

            Assert.IsNotNull(entity);
            Assert.IsInstanceOfType(entity, typeof (User));
        }

        [TestMethod, Ignore]
        public void Get_Me_Post_Comment_on_first_track()
        {
            var me = SoundCloud.Me.Get();
            var firstTrack = me.Tracks.Get().First();
            var comment = firstTrack.Comments.Get().First();
            comment.body = "Comment via API";
            var entity = firstTrack.Comments[comment.id].Put(comment);

            Assert.IsNotNull(entity);
            Assert.IsInstanceOfType(entity, typeof(User));
        }

        [TestMethod, Ignore]
        public void Get_Users()
        {
            var entities = SoundCloud.Users.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(User));
            }
        }

        [TestMethod, Ignore]
        public void Get_Users_PageTwo()
        {
            var entities = SoundCloud.Users.Get(1);

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(User));
            }
        }

        [TestMethod, Ignore]
        public void Get_User()
        {
            var entity = SoundCloud.Users[473781].Get();

            Assert.IsNotNull(entity);
            Assert.IsInstanceOfType(entity, typeof(User));
        }

        [TestMethod, Ignore]
        public void Get_UserTracks()
        {
            var entities = SoundCloud.Users[473781].Tracks.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Track));
            }
        }

        [TestMethod, Ignore]
        public void Get_UserPlaylists()
        {
            var entities = SoundCloud.Users[473781].Playlists.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Playlist));
            }
        }

        [TestMethod, Ignore]
        public void Get_UserWebProfiles()
        {
            var entities = SoundCloud.Users[473781].WebProfiles.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(WebProfile));
            }
        }

        [TestMethod, Ignore]
        public void Get_Groups()
        {
            var entities = SoundCloud.Groups.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Group));
            }
        }

        [TestMethod, Ignore]
        public void Get_Groups_PageTwo()
        {
            var entities = SoundCloud.Groups.Get(1);

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Group));
            }
        }

        [TestMethod, Ignore]
        public void Get_Group()
        {
            var entity = SoundCloud.Groups[7].Get();

            Assert.IsNotNull(entity);
            Assert.IsInstanceOfType(entity, typeof(Group));
        }

        [TestMethod, Ignore]
        public void Get_GroupModerators()
        {
            var entities = SoundCloud.Groups[7].Moderators.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(User));
            }
        }

        [TestMethod, Ignore]
        public void Get_GroupMembers()
        {
            var entities = SoundCloud.Groups[7].Members.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(User));
            }
        }

        [TestMethod, Ignore]
        public void Get_GroupUsers()
        {
            var entities = SoundCloud.Groups[7].Users.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(User));
            }
        }

        [TestMethod, Ignore]
        public void Get_Playlists()
        {
            var entities = SoundCloud.Playlists.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Playlist));

                foreach (var track in entity.tracks)
                {
                    Assert.IsNotNull(track);
                    Assert.IsInstanceOfType(track, typeof(Track));
                }
            }
        }

        [TestMethod, Ignore]
        public void Get_Playlists_PageTwo()
        {
            var entities = SoundCloud.Playlists.Get(1);

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Playlist));
            }
        }

        [TestMethod, Ignore]
        public void Get_Playlist()
        {
            var entity = SoundCloud.Playlists[7].Get();

            Assert.IsNotNull(entity);
            Assert.IsInstanceOfType(entity, typeof(Playlist));
        }

        [TestMethod, Ignore]
        public void Get_Tracks()
        {
            var entities = SoundCloud.Tracks.Get();

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Track));

                if (entity.user != null)
                {
                    var subEntities = entity.user.Tracks.Get();
                    Assert.IsNotNull(subEntities);
                }
            }
        }

        [TestMethod, Ignore]
        public void Get_Tracks_PageTwo()
        {
            var entities = SoundCloud.Tracks.Get(1);

            Assert.IsNotNull(entities);

            foreach (var entity in entities)
            {
                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Track));
            }
        }

        [TestMethod, Ignore]
        public void Get_Track()
        {
            var entity = SoundCloud.Tracks[53838079].Get();

            Assert.IsNotNull(entity);
            Assert.IsInstanceOfType(entity, typeof(Track));
        }

        [TestMethod, Ignore]
        public void Post_TrackComment()
        {
            try
            {
                var entity = SoundCloud.Tracks[80996722].Comments.Post(new Comment
                {
                    body = "Comment via API",
                    timestamp = 31,
                });

                Assert.IsNotNull(entity);
                Assert.IsInstanceOfType(entity, typeof(Comment));
            }
            catch (AggregateException ex)
            {
                var innerEx = (SoundCloudException) ex.InnerException;
                Assert.IsNotNull(innerEx.Errors);
                Assert.IsInstanceOfType(innerEx.Errors, typeof(Errors));
            }
        }
    }
}
#endif