using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3   //Lærke
{
    public class AuctionHouse
    {
        protected decimal Bid;
        protected int ID;
        protected int sellerID;
        protected string Read;
        protected decimal mp;
        public int AuctionNum;
        public decimal Fees;

        List<Auction> Auctions = new List<Auction>();
        List<Auction> DoneAuctions = new List<Auction>(); 

        /*public Vehicels makeVehicels
        {
            get
            {
                return Vehicel;
            }
            set
            {
                Vehicels.Vehicel();
            } 
        }*/

        public int SetForSale(Vehicels v, Seller s, decimal mp)
        {
            Auctions.Add(new Auction() { Vehicel = v, MinPrice = mp, Seller = s });
            AuctionNum = Auctions.Count;
            return AuctionNum;
        }

        public bool ReciveBid(Buyer Buyer, int AuctionNumber, decimal Bid)
        {
            if (Bid >= Auctions[AuctionNumber].MinPrice)
            {
                Auctions[AuctionNumber].Seller.Notification(Bid);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AcceptBid(Seller seller, int AuctionNumber)
        {
            /*tjek om seller har sat auctionNumber til salg*/
            if (seller != Auctions[AuctionNumber].Seller)
            {
                return false;
            }
            if (Bid - Getfee(Bid) < Auctions[AuctionNumber].MinPrice)
            {

            }
            seller.purchase(Bid);
            Fees += Getfee(Bid);
            Auctions[AuctionNumber].Buyer.purchase(Bid - Getfee(Bid));
            DoneAuctions.Add(Auctions[AuctionNumber]);
            return false;        
        }

        public decimal Getfee(decimal PricePayed)
        {
            if (PricePayed < 10000)
            {
                return 1900;
            }
            else if (PricePayed < 50000)
            {
                return 2250;
            }
            else if (PricePayed < 100000)
            {
                return 2550;
            }
            else if (PricePayed < 150000)
            {
                return 2850;
            }
            else if (PricePayed < 200000)
            {
                return 3400;
            }
            else if (PricePayed < 300000)
            {
                return 3700;
            }
            else
            {
                return 4400;
            }
        }

        public int SalesNotification(Vehicels k, Seller s, decimal mp, int notificationsMetode)
        {
            
            return ID;
        }
    }
}
