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
        private string lastName;

        public string MyProperty
        {
            get { return lastName; }
            set
            {
                string[] names = value.Split(' ');
                if(names.Count() >= 2)
                {
                    lastName = names[names.Count() - 1];
                }
                else
                {
                    lastName = value;
                }
                lastName = value;
            }
        }


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
                int counter = 0;
                while (account.Length < 6)
                {
                    account += lastName[counter-1].ToString().ToLower();
                    counter--;
                    if (counter == lastName.Length)
                    {
                        counter = 0;
                    }
                }
            }

            return account;
        }
    }
}
