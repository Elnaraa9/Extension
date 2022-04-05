using System;

namespace _1042022
{
    class Program
    {
        static void Main(string[] args)
        {
           User user = new User("elnare123","Elnara Vahabova","7KHTHT3@code.edu.az");
            user.ShowInfo();
            var a = user.PasswordChecker("Lnrv2002");
            Console.WriteLine(a);
        }
    }
}