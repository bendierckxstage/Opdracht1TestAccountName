using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1TestAccountName
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string generateAccount()
        {
            string account = "";
            if (lastName.Length >= 6)
            {
                account += lastName.Substring(0, 5).ToLower();
                account += firstName.Substring(0, 1).ToLower();
            }
            else
            {
                account += lastName.Substring(0, lastName.Length).ToLower();
                account += firstName.Substring(0, 1).ToLower();
                int counter = lastName.Length;
                while (account.Length < 6)
                {
                    account += lastName[counter-1].ToString().ToLower();
                    counter--;
                    if (counter == 0)
                    {
                        counter = lastName.Length;
                    }
                }
            }

            return account;
        }
    }
}
