using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3   //Lærke
{
    public class Seller : User
    {
        public Seller(decimal startSaldo, int Id, bool company, int zipcode)
            : base(startSaldo, Id, company)
        {
            Zipcode = zipcode;
        }

        public bool purchase(decimal purchasePrice)
        {
            saldo += purchasePrice;
            return true;
        }

        public int Zipcode { get; set; }
        public decimal Bid { get; set; }
        public void Notification(decimal Bid)
        {
            Console.WriteLine("Your bid is: {0}", Bid);
        }
    }
}
