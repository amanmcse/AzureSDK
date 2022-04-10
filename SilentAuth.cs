using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using System.Linq;

namespace repeat
{
    class SilentAuth
    {
        public static async Task<string> niAuthAsync()
        {
            string clientID = "78f3563a-207c-4238-b203-c6fd06cdf1f3";
            string tenantID = "4452048a-63be-4bff-81f7-a3d4824c995d";
            string replyURL = "http://localhost";
            string[] scopes = {"User.Read"};
            IPublicClientApplication app = PublicClientApplicationBuilder.Create(clientID)
            .WithAuthority(AzureCloudInstance.AzurePublic, tenantID)
            .WithRedirectUri(replyURL)
            .Build();
            TokenCacheHelper.EnableSerialization(app.UserTokenCache);

            var accounts = await app.GetAccountsAsync();
            AuthenticationResult result = null;
            try
                {
                    result = await app.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                                    .ExecuteAsync();
                }
            catch (MsalUiRequiredException)
                {
                    result = await app.AcquireTokenInteractive(scopes)
                          .ExecuteAsync();
                }
            return result.AccessToken;
        }
    }
}