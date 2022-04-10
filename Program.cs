using System;
using Microsoft.Identity.Client;

namespace repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphy u1 = new Graphy(Graphy.myCallAsync().GetAwaiter().GetResult());
            Console.WriteLine($"Hi {u1.me.DisplayName}, Your EmpID: {u1.me.EmployeeId} and Deptt.: {u1.me.Department}.!!!!!!!!");
            System.Console.WriteLine($"Here is your secret: {Vaulty.myVaultAsync().GetAwaiter().GetResult()}");
        }
    }
}