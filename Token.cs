using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Microsoft.Graph;

namespace repeat
{
    class Token
    {
        public static async Task<string> myToken()
        {
            string clientID = "78f3563a-207c-4238-b203-c6fd06cdf1f3";
            string tenantID = "4452048a-63be-4bff-81f7-a3d4824c995d";
            //string redirectURI = "http://localhost";
            string username = "username@amansicorp.onmicrosoft.com";
            System.Security.SecureString password = new NetworkCredential("", "*********").SecurePassword;
            string[] scopes = {"User.Read"};

            IPublicClientApplication app = PublicClientApplicationBuilder.Create(clientID)
            .WithAuthority(AzureCloudInstance.AzurePublic, tenantID)
            .Build();
            var result = await app.AcquireTokenByUsernamePassword(scopes, username, password).ExecuteAsync();
            return result.AccessToken;
        }
    }
}
