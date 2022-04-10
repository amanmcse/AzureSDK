using System;
using System.Threading.Tasks;
using Azure.Storage.Blobs;

namespace repeat
{
    class Bloby
    {
        public static Uri myBlob()
        {
            string containerName = "boxy";
            Uri accountUri = new Uri("https://sdkstor.blob.core.windows.net/");
            BlobServiceClient client = new BlobServiceClient(accountUri, Auth.authy());
            //BlobContainerClient containerClient = await client.CreateBlobContainerAsync(containerName);
            BlobContainerClient containerClient = client.GetBlobContainerClient(containerName);
            string blobName = "new7.txt";
            string filePath = @"d:\Docs\new 4.txt";

            // Get a reference to a blob named "sample-file" in a container named "sample-container"
            BlobClient blob = containerClient.GetBlobClient(blobName);

            // Upload local file
            blob.Upload(filePath);
            return blob.Uri;
        }
    }
}