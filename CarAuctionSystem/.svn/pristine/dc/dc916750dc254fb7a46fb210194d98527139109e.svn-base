using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class Autocamper : Vehicels
    {

        public Autocamper(string name, int year, double km, string regNum, double newPrice, bool pullHook, string fuel,
        double moterSize, string energyClass, int amountSeats, double lenght, double hight, double width, string cardType, int amountSeats,
        bool toilet, string heatsystem, char energyClass, double kmPrLiter, double newMotorSize) 
        : base (name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass, amountSeats, lenght, hight, width)


        public void Vehicel(string CardType, int AmountSeats, int AmountBeds, bool Toilet, string HeatSystem, char EnergiClass, double KmPrLiter)
        {
            CardType = "B";
            AmountSeats = amountSeats;
            AmountBeds = amountBeds;
            Toilet = toilet;
            HeatSystem = heatSystem;
            KmPrLiter = kmPrLiter;
        }

        public string cardType
        {
            set { CardType = "B"; }
            get { return CardType; }
        }

        public int amountSeats
        {
            set;
            get;
        }

        public int amountBeds
        {
            set;
            get;
        }

        public bool Toilet
        {
            set;
            get;
        }

        public string HeatSystem
        {
            set;
            get;
        }

        public char EnergiClass(double kmPrLiter, string heatingSystem)
        {
            this.KmPrLiter = kmPrLiter;
            this.HeatSystem = heatingSystem;

            if (HeatSystem == "Oil")
            {
                double c = (kmPrLiter*0.7);

                if (Year < 2010)
                {
                    if (Fuel == "Diezel")
                    {
                        if (c >= 23)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (18 <= c)
                        {
                            if (c <= 22)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (13 <= c)
                        {
                            if (c <= 17)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 12)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }

                    if (Fuel == "Benzin")
                    {
                        if (18 <= c)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (14 <= c)
                        {
                            if (c <= 17)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (10 <= c)
                        {
                            if (c <= 13)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 10)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }
                }

            if (Year > 2010)
            {
                if (Fuel == "Diezel")
                    {
                        if (c >= 25)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (20 <= c)
                        {
                            if (c <= 24)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (15 <= c)
                        {
                            if (c <= 23)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 15)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }

                    if (Fuel == "Benzin")
                    {
                        if (20 <= c)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (16 <= c)
                        {
                            if (c <= 19)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (12 <= c)
                        {
                            if (c <= 15)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 12)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }
               }
         }
            if (HeatSystem == "Power")
            {
                double c = (kmPrLiter*0.8);

                if (Year < 2010)
                {
                    if (Fuel == "Diezel")
                    {
                        if (c >= 23)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (18 <= c)
                        {
                            if (c <= 22)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (13 <= c)
                        {
                            if (c <= 17)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 12)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }

                    if (Fuel == "Benzin")
                    {
                        if (18 <= c)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (14 <= c)
                        {
                            if (c <= 17)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (10 <= c)
                        {
                            if (c <= 13)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 10)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }
                }

            if (Year > 2010)
            {
                if (Fuel == "Diezel")
                    {
                        if (c >= 25)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (20 <= c)
                        {
                            if (c <= 24)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (15 <= c)
                        {
                            if (c <= 23)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 15)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }

                    if (Fuel == "Benzin")
                    {
                        if (20 <= c)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (16 <= c)
                        {
                            if (c <= 19)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (12 <= c)
                        {
                            if (c <= 15)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 12)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }
               }
          }
            if (HeatSystem == "Gas")
            {
                     double c = (kmPrLiter*0.8);

                if (Year < 2010)
                {
                    if (Fuel == "Diezel")
                    {
                        if (c >= 23)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (18 <= c)
                        {
                            if (c <= 22)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (13 <= c)
                        {
                            if (c <= 17)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 12)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }

                    if (Fuel == "Benzin")
                    {
                        if (18 <= c)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (14 <= c)
                        {
                            if (c <= 17)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (10 <= c)
                        {
                            if (c <= 13)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 10)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }
                }

            if (Year > 2010)
            {
                if (Fuel == "Diezel")
                    {
                        if (c >= 25)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (20 <= c)
                        {
                            if (c <= 24)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (15 <= c)
                        {
                            if (c <= 23)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 15)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }

                    if (Fuel == "Benzin")
                    {
                        if (20 <= c)
                        {
                            Console.WriteLine("energyClass is A");
                        }
                        
                        if (16 <= c)
                        {
                            if (c <= 19)
                            {
                                Console.WriteLine("energyClass is B");
                            }
                        }

                        if (12 <= c)
                        {
                            if (c <= 15)
                            {
                                Console.WriteLine("energyClass is C");
                            }
                        }

                        if (c <= 12)
                        {
                            Console.WriteLine("energyClass is D");
                        }
                    }
               }
          }
            return '\0';
        }
        public double SetMorterSize
        {
            set
            {
                value = MotorSize(value);
                MoterSize = value;
            }
            get { return MoterSize; }
        }
      }
}
