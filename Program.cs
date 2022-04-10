using System;
using Microsoft.Identity.Client;

namespace repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphy u1 = new Graphy(Graphy.myCallAsync().GetAwaiter().GetResult());
            Console.WriteLine($"Hi [{u1.GU.DisplayName}], Your Employee ID is [{u1.GU.EmployeeId}] and Department is [{u1.GU.Department}].");
            System.Console.WriteLine($"Here is your secret: {Vaulty.myVaultAsync().GetAwaiter().GetResult()}");
            System.Console.WriteLine($"Download your file: {Bloby.myBlob()}");
        }
    }
}
