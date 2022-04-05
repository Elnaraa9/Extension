using System;

namespace _1042022
{
    class User:IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string password, string fullName, string email)
        {
            password = Password;
            fullName = FullName;
            email = Email;
        }
        public bool PasswordChecker(string password)
        {
            foreach (var item in password)
            {
                if (password.Length < 8)
                {
                    Console.WriteLine("Sifre uzunlugu duzgun deyil");
                }
                if (!(char.IsUpper(password, item) && char.IsLower(password, item) && char.IsNumber(password, item)))
                {
                    Console.WriteLine("Daxil edilen sifre formati yalnisdir");
                }
            } 
        }     

        public void ShowInfo(string name,string email)
        {
            Console.WriteLine($"Fullname: {FullName}, Email: {Email}");
        }
    }
}
