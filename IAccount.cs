using System;
using System.Collections.Generic;
using System.Text;

namespace _1042022
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
