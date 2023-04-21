using System;
using System.Threading;

namespace Dongulerr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user, password;

            do
            {
                Console.WriteLine("Kullanıcı adı ");
                user = Console.ReadLine();

                Console.WriteLine("Şifre");
                password = Console.ReadLine();
            } while (user != "admin" || password != "123");
        }
    }
}
