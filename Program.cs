using System;
using System.Security.Cryptography.X509Certificates;

namespace Emailcheck
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter you email address:");
            string? email = Console.ReadLine();
            try
            {
                int atlocation = email.IndexOf("@");
                string? Domain = email.Substring((atlocation + 1));
                string? Username = email.Substring(0,atlocation);
                int dotlocation = email.IndexOf(".");
                if (dotlocation <= 0 )
                {
                    throw new Exception("Invalid Email!");
                }
                Console.WriteLine($"Username: {Username}");
                Console.WriteLine($"Domain: {Domain}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid email!");
            }
        }
    } 
}