using System;
using System.Globalization;
using Ewk.SoundCloud.ApiLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Ewk.SoundCloud.ApiLibrary.UnitTests
{
    [TestClass]
    public class AuthorizationTests : SoundCloudTestBase
    {
        const string ClientId = "someClientId";

        [TestMethod]
        public void Get_AuthorizeUri()
        {
            const string redirectUrl = "http://some.url.com/sub";
            var redirectUri = new Uri(redirectUrl);
            const string expectedUrlFormat = "https://soundcloud.com/connect?client_id={0}&redirect_uri={1}&response_type=code&scope=non-expiring";
            var expectedUrl = string.Format(CultureInfo.InvariantCulture, expectedUrlFormat, ClientId, redirectUrl);

            SoundCloudClient
                .Expect(client => client.ClientId)
                .Return(ClientId)
                .Repeat.Any();
            SoundCloudClient
                .Expect(client => client.RedirectUri = redirectUri)
                .Repeat.Any();
            SoundCloudClient.Replay();

            var result = SoundCloud.GetAuthorizeUri(redirectUri);

            Assert.AreEqual(expectedUrl, result.AbsoluteUri);
            SoundCloudClient.VerifyAllExpectations();
        }

        [TestMethod]
        public void Process_AuthorizeResponse()
        {
            var code = Guid.NewGuid().ToString();
            var apiSecret = Guid.NewGuid().ToString();
            const string redirectUrlFormat = "http://some.url.com/sub?code={0}";
            var redirectUrl = string.Format(CultureInfo.InvariantCulture, redirectUrlFormat, code);
            var authorizationToken = new OAuth2Token
                {
                    access_token = "09836ijg9u835yjihn909938y39863wrjg",
                    scope = "non-expiring"
                };

            SoundCloudClient
                .Expect(client => client.RequestOAuthToken(code, apiSecret))
                .Return(authorizationToken)
                .Repeat.Any();
            SoundCloudClient
                .Expect(client => client.RedirectUri)
                .SetPropertyWithArgument(
                    Arg<Uri>.Matches(uri =>
                                     uri.AbsoluteUri == "http://some.url.com/sub"))
                .Repeat.AtLeastOnce();
            SoundCloudClient
                .Expect(client => client.OAuthToken = authorizationToken)
                .Repeat.Any();
            SoundCloudClient.Replay();

            var result = SoundCloud.RequestOAuthToken(new Uri(redirectUrl), apiSecret);

            Assert.AreEqual(authorizationToken.access_token, result.access_token);

            SoundCloudClient.VerifyAllExpectations();
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void Process_AuthorizeResponse_Throws_ArgumentException_On_Error()
        {
            var apiSecret = Guid.NewGuid().ToString();
            const string redirectUrl = "http://someurl.com/?error=redirect_uri_mismatch&error_description=The+redirection+URI+provided+does+not+match+a+pre-registered+value";

            SoundCloudClient
                .Expect(client => client.RedirectUri)
                .SetPropertyWithArgument(
                    Arg<Uri>.Matches(uri =>
                                     uri.AbsoluteUri == "http://some.url.com/"))
                .Repeat.AtLeastOnce();
            SoundCloudClient.Replay();

            var result = SoundCloud.RequestOAuthToken(new Uri(redirectUrl), apiSecret);
        }
    }
}