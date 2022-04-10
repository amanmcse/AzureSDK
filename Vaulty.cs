using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace repeat
{
    class Vaulty
    {
        public static async Task<string> myVaultAsync()
        {
            var client = new SecretClient(new Uri("https://kv82.vault.azure.net/"), Auth.authy());
            KeyVaultSecret secret = await client.GetSecretAsync("secret1");
            return secret.Value;
        }
    }
}