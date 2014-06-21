using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class Car : Vehicels
    {
        protected Car(string name, int year, double km, string regNum, double newPrice, bool pullHook, string fuel,
            double moterSize, string energyClass, int amountSeats, double lenght, double hight, double width) : base(name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass)
        {
            AmountSeats = amountSeats; 
            Length = lenght;
            Hight = hight;
            Width = width;
        }

       
        public int AmountSeats
        {
            set{ AmountSeats = value; }
            get{ return AmountSeats; }
        }

        public double Length
        {
            set{ Length = value; }
            get{ return Length; }
        }

        public double Hight
        {
            set{ Hight = value; }
            get{ return Hight; }
        }

        public double Width
        {
            set{ Width = value; }
            get{ return Width; }
        }

        public string CardType
        {
            set{ CardType = "B"; }
            get{ return CardType; }
        }

        public string SetNewEnergyClass
        {
            set
            {
                value = SetEnergyClass(SetKmPrLiter, Fuel);
                EnergyClass = value;
            }
        }
        public double SetNewMorterSize
        {
            set
            {
                value = SetMotorSize(MoterSize);
                MoterSize = value;
            }
            get { return MoterSize; }
        }

    }
}
