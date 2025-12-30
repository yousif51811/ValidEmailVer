using System;
using System.Security.Cryptography.X509Certificates;

namespace Emailcheck
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.ResetColor();
                Console.Write("Enter you email address: ");
                string? email = Console.ReadLine();
                try
                {
                    int atlocation = email.IndexOf("@");
                    string? Domain = email.Substring((atlocation + 1));
                    string? Username = email.Substring(0,atlocation);
                    int dotlocation = Domain.IndexOf(".");
                    if (dotlocation <= 0 )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new Exception("Invalid Domain!");
                        
                    }
                    Console.WriteLine($"\nUsername: {Username}");
                    Console.WriteLine($"Domain: {Domain}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Valid Email");
                    Console.ResetColor();
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid email!");
                }
            }

        }
    } 
}