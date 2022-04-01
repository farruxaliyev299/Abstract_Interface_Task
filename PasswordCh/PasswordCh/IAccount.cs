using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordCh
{
    interface IAccount
    {
        public bool PasswordChecker(string pass);

         void ShowInfo();
    }
}
