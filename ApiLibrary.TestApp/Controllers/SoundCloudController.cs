using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ewk.SoundCloud.ApiLibrary.TestApp.Models;

namespace Ewk.SoundCloud.ApiLibrary.TestApp.Controllers
{
    public class SoundCloudController : AsyncController
    {
        readonly SoundCloud _soundCloud = new SoundCloud("a313b5ea206fd041790313a29c227acf");

        public async Task<ActionResult> Index()
        {
            var user = await _soundCloud.Users[473781].GetAsync();
            ViewBag.Message = string.Format("Authorize the app to test the library. {0}", user.username);

            return View();
        }

        public ActionResult Authorize()
        {
            var redirectUrl = _soundCloud.GetAuthorizeUri(new Uri("http://localhost:64872/soundcloud/authorized"));

            return Redirect(redirectUrl.AbsoluteUri);
        }

        public async Task<ActionResult> Authorized(string code)
        {
            var token = _soundCloud.RequestOAuthToken(Request.Url, "8e2d532bf47e303c9f5c65d55c22098d");
            var me = await _soundCloud.Me.GetAsync();
/*
            var followers = await me.Followers.GetAsync();
            var followers2 = await followers.First().Followers.GetAsync();
            var name = followers2.First().full_name;
*/
            var model = new SoundCloudUserDetails
                {
                    User = me,
                    WebProfiles = await me.WebProfiles.GetAsync(),
                    Followers = await me.Followers.GetAsync(),
                    Followings = await me.Followings.GetAsync(),
                };

            ViewBag.Message = string.Format("Your token: {0}", token.access_token);

            return View("Details", model);
        }
    }
}