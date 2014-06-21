using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3   //Lærke
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            string option;     
            string search;     
            bool found = false;
            string read;
            decimal mp;
            AuctionHouse AH;

            Seller s1 = new Seller(300000, 00000, true, 9000);
            Vehicels v1 = new PrivateCar(name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass, amountSeats, lenght, hight, width, isofix);
            Vehicels v2 = new WorkCar(name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass, amountSeats, lenght, hight, width);
            Vehicels v3 = new Bus(name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass);
            Vehicels v4 = new Autocamper(name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass);
            Seller s2 = new Seller(10000, 00001, false, 9220);
            Vehicels v5 = new PrivateCar(name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass, amountSeats, lenght, hight, width, isofix);
            AH.SetForSale(v1, s1, 20000);
            AH.SetForSale(v2, s1, 45000);
            AH.SetForSale(v3, s1, 100000);
            AH.SetForSale(v4, s1, 250000);
            AH.SetForSale(v5, s2, 65000);
#if(DEBUG)
            do
                {       
                    Console.WriteLine("Main menu");
                    Console.WriteLine("1: add auction.");
                    Console.WriteLine("2: Show auctions.");
                    Console.WriteLine("3: Search auctions");
                    Console.WriteLine("4: Return genneral enery class");
                    Console.WriteLine("5: Exit");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1": // Add a new auction
                            Console.WriteLine("Enter the type of the vehicel");
                            read = Console.ReadLine();
                            Console.WriteLine("Enter your minium price");
                            mp = Console.Read();
                           /*makeAuction*/
                            break;
                
                        case "2":  // Display all
                            if (AH.Auctions.Count == 0)
                            {
                                Console.WriteLine("No data to search");
                            }
                            else
                            {
                                for(int i = 0; i < AH.Auctions.Count; i++)
                                {
                                    Console.WriteLine("{0}, {1}, {2}, {3}, {4}.", i, i, i, i, i);
                                }
                            }
                            break;

                        case "3": // Search
                            Console.WriteLine("Enter keyword");
                            search = Console.ReadLine(); /*ToLower()*/
                            if(Auctions != null)
                            {
                                for (int i = 0; i < Auctions.Count; i++) // Loop through List
                                {
                                    /*Auctions.FindAll*/
                                    if (search == Auctions[i].VehicelType)
                                    {
                                        found = true;
                                    }
                                    if (found)
                                    {
                                        Console.WriteLine("{0}", Auctions[i]);
                                    }
                                }
                            }
                            else
                            { 
                                Console.WriteLine("List is NULL.");
                            }
                            break;
                        case "4":
                            /*Gennemsnitlig energiklasse*/
                            break;
                        case"5":
                            exit = true;
                            break;
                    }
                }while(exit != false);
#endif

        }
    }
}
