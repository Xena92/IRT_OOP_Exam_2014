using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3   //Lærke
{
    public class User
    {
        public decimal saldo;
        public int CVR;
        public int CPR;

        protected User(decimal startSaldo, int Id, bool company)
        {
            saldo = startSaldo;
            ID = Id;
            Company = company;
        }

        public bool Company { get; set; }

        public int ID
        {
            get;
            set
            {
                if (Company)
                {
                    CVR = ID;
                }
                else
                {
                    CPR = ID;
                }
            }
        }

        public decimal limit
        {
            set{
                
                if (Company)
                {
                    value = -30000;
                }
                else
                {
                    value = 0;
                }
                limit = value;
            }
            get { return limit; }
        }
    }
}
