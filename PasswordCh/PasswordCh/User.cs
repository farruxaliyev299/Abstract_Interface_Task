using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordCh
{
    class User : IAccount
    {
        public string Fullname;

        public string Email;

        public string Password;

        public bool PasswordChecker(string pass)
        {
            bool check;
            bool issmall
            int count=0;
            if (pass.Length < 8)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsUpper(pass[i]))
                    {
                        check = true;
                    }
                    if (char.IsLower(pass[j]))
                    {
                        count++;
                        return;
                    }

                }
                for (int j = 0; j < pass.Length; j++)
                {
                  
                }
                for (int n = 0; n < pass.Length; n++)
                {
                    count++;
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sifre-nin xarakteri 8 den azdir");
            }

            if(count == 3)
            {
                return;
            }
            
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
