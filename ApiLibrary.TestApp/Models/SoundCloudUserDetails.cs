using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ewk.SoundCloud.ApiLibrary.Entities;

namespace Ewk.SoundCloud.ApiLibrary.TestApp.Models
{
    public class SoundCloudUserDetails
    {
        public User User { get; set; }
        public IEnumerable<WebProfile> WebProfiles { get; set; }
        public IEnumerable<User> Followers { get; set; }
        public IEnumerable<User> Followings { get; set; } 
    }
}