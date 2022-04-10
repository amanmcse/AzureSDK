using System;
using Microsoft.Identity.Client;
using Microsoft.Graph;
using Azure.Identity;
using System.Threading.Tasks;

namespace repeat
{
    class Graphy
    {
        public User me { get; set; }
        public Graphy(User me)
        {
            this.me = me;
        }
        public static async Task<User> myCallAsync()
        {
           string tenant_id = "4452048a-63be-4bff-81f7-a3d4824c995d";
           string client_id = "78f3563a-207c-4238-b203-c6fd06cdf1f3";
           string[] scope = {"https://graph.microsoft.com/user.read"};

           var options = new TokenCredentialOptions
           {
               AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
           };

           var mycred = new InteractiveBrowserCredential(tenant_id,client_id,options);

            GraphServiceClient graphClient = new GraphServiceClient( Auth.authy() );

            var user = await graphClient.Me
                .Request()
                .Select("DisplayName,department,employeeId")
                .GetAsync();

                return user;
        }
    }
}