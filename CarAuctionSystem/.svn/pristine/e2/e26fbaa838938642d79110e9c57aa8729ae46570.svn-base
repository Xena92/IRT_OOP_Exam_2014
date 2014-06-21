using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace ConsoleApplication3
{
    public class Vehicels
    {
        protected Vehicels(string name, int year, double km, string regNum, double newPrice, bool pullHook, string fuel,
            double moterSize, string energyClass)
        {
            Name = name;
            Year = year;
            Km = km;
            RegNum = regNum;
            NewPrice = newPrice;
            PullHook = pullHook;
            Fuel = fuel;
            MoterSize = moterSize;
            EnergyClass = energyClass;
        }

        public string Name
        {
            get { return Name; }
            private set { Name = value;  }
        }

        public double Km
        {
            private set;
            get;
        }

        public string RegNum
        {
            private set {
                if (value.Length == 7)
                    RegNum = value;
                else RegNum = "0000000";
            }
            get { return RegNum; }
        }

        public int Year
        {
            private set { Year = value; }
            get { return Year; }
        }

        public double NewPrice
        {
            set { NewPrice = value; }
            get { return NewPrice; }
        }

        public bool PullHook
        {
            set;
            get;
        }

        public string Fuel
        {
            set;
            get;
        }
        public double MoterSize { get; set; }


        public double MotorSize(double vehicel)
        {

            if (vehicel.GetType() == typeof (Truck))
            {
                Console.WriteLine("moterSize 4.2 - 15 Liter");
                Console.WriteLine("Enter motersize");
                double c = Console.Read();
                if (MoterSize >= 4.2)
                {
                    if (MoterSize <= 15)
                    {
                        MoterSize = c;
                        return c;
                    }
                    else
                    {
                        Console.WriteLine("The number needs to be between 4.2 and 15");
                    }
                }
            }
            if (vehicel.GetType() == typeof (Bus))
            {
                Console.WriteLine("moterSize 4.2 - 15 Liter");
                Console.WriteLine("Enter motersize");
                double c = Console.Read();
                if (MoterSize >= 4.2)
                {
                    if (MoterSize <= 15)
                    {
                        MoterSize = c;
                        return c;
                    }
                    else
                    {
                        Console.WriteLine("The number needs to be between 4.2 and 15");
                    }
                }
            }
            if (vehicel.GetType() == typeof (PrivateCar))
            {
                Console.WriteLine("moterSize  0.7 - 10 Liter");
                Console.WriteLine("Enter motersize");
                double c = Console.Read();
                if (MoterSize >= 0.7)
                {
                    if (MoterSize <= 10)
                    {
                        MoterSize = c;
                        return c;
                    }
                    else
                    {
                        Console.WriteLine("The number needs to be between 0.7 and 10");
                    }

                }
            }
            if (vehicel.GetType() == typeof (Autocamper))
            {
                Console.WriteLine("moterSize 2.4 - 6.2 Liter");
                Console.WriteLine("Enter motersize");
                double c = Console.Read();
                if (MoterSize >= 2.4)
                {
                    if (MoterSize <= 6.2)
                    {
                        MoterSize = c;
                        return c;
                    }
                    else
                    {
                        Console.WriteLine("The number needs to be between 2.5 and 6.2");
                    }
                }

            }
            else
            {
                Console.WriteLine("something else?");
            }
            return MoterSize;
        }



        public double SetKmPrLiter
            {
                set { SetKmPrLiter = value; }
                get { return SetKmPrLiter; }
            }

        public string SetEnergyClass(double kmPrLiter, string fuel)
            {
                if (SetYear < 2010)
                {
                    if (Fuel == "Diezel")
                    {
                        if (kmPrLiter >= 23)
                        {
                            return ("energyClass is A");
                        }
                        
                        if (18 <= kmPrLiter)
                        {
                            if (kmPrLiter <= 22)
                            {
                                return ("energyClass is B");
                            }
                        }

                        if (13 <= kmPrLiter)
                        {
                            if (kmPrLiter <= 17)
                            {
                                return ("energyClass is C");
                            }
                        }

                        if (kmPrLiter <= 12)
                        {
                            return ("energyClass is D");
                        }
                    }

                    if (Fuel == "Benzin")
                    {
                        if (18 <= kmPrLiter)
                        {
                            return ("energyClass is A");
                        }
                        
                        if (14 <= kmPrLiter)
                        {
                            if (kmPrLiter <= 17)
                            {
                                return ("energyClass is B");
                            }
                        }

                        if (10 <= kmPrLiter)
                        {
                            if (kmPrLiter <= 13)
                            {
                                return ("energyClass is C");
                            }
                        }

                        if (kmPrLiter <= 10)
                        {
                            return ("energyClass is D");
                        }
                    }
                }

            if (SetYear > 2010)
            {
                if (Fuel == "Benzin")
                    {
                        if (kmPrLiter >= 25)
                        {
                            return ("energyClass is A");
                        }
                        
                        if (20 <= kmPrLiter)
                        {
                            if (kmPrLiter <= 24)
                            {
                                return ("energyClass is B");
                            }
                        }

                        if (15 <= kmPrLiter)
                        {
                            if (kmPrLiter <= 23)
                            {
                                return ("energyClass is C");
                            }
                        }

                        if (kmPrLiter <= 15)
                        {
                            return ("energyClass is D");
                        }
                    }

                if (Fuel == "Benzin")
                    {
                        if (20 <= kmPrLiter)
                        {
                            return ("energyClass is A");
                        }
                        
                        if (16 <= kmPrLiter)
                        {
                            if (kmPrLiter <= 19)
                            {
                                return ("energyClass is B");
                            }
                        }

                        if (12 <= kmPrLiter)
                        {
                            if (kmPrLiter <= 15)
                            {
                                return ("energyClass is C");
                            }
                        }

                        if (kmPrLiter <= 12)
                        {
                            return ("energyClass is D");
                        }
                    }
               }
            return EnergyClass;
            }

        public string NewToString()
        {
            return base.ToString() + "details" + Name.ToString() + Year.ToString() + Km.ToString() + RegNum.ToString() +
                   NewPrice.ToString() + PullHook.ToString() + Fuel.ToString() + MoterSize.ToString() +
                   EnergyClass.ToString();
        }
    }
 }

