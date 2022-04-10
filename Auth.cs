using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Identity;

namespace repeat
{
    class Auth
    {
        public static InteractiveBrowserCredential authy()
        {
            string tID = "4452048a-63be-4bff-81f7-a3d4824c995d";
            string appID = "78f3563a-207c-4238-b203-c6fd06cdf1f3";
            string[] scp = {"user_impersonation"};

            var optiona = new InteractiveBrowserCredentialOptions
            {
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
                LoginHint = "globaladmin@amansicorp.onmicrosoft.com"
            };

            var authctx = new InteractiveBrowserCredential(tID,appID,optiona);

            return authctx;
        }
    }
}