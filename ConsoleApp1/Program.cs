using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hash
            // var hash = SecurePasswordHasher.Hash("mypassword");

            // Verify
            //var result = SecurePasswordHasher.Verify("mypassword", hash);

            Console.Write("Enter password: ");
            string pwd = Console.ReadLine();

            var hash = SecurePasswordHasher.Hash(pwd);
            Console.WriteLine("Hashed password = {0}", hash);

            char usin;

            Console.Write("Wanna veryfiy password: y/n?");
            usin = Console.ReadKey().KeyChar;

            if (usin == 'y')
            {
                Console.Write("Enter password to verify: ");
                string vpwd = Console.ReadLine();

                var result = SecurePasswordHasher.Verify(vpwd, hash);

                if (result is true)
                {
                    Console.WriteLine("Password is Correct");
                }
                else
                    Console.WriteLine("Password is Wrong");

            }
            else {
                Console.WriteLine("Your password was = {0}", pwd);
            }

            Console.ReadLine();
        }
    }
}
