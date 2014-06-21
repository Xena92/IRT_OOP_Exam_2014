using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class PrivateCar : Car
    {
        protected double kmPrLiter;

        public PrivateCar(string name, int year, double km, string regNum, double newPrice, bool pullHook, string fuel,
        double moterSize, string energyClass, int amountSeats, double lenght, double hight, double width, bool isofix) 
        : base (name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass, amountSeats, lenght, hight, width)
        {
            ISOfix = isofix;
        }

        public bool ISOfix
        {
            set;
            get;
        }
        public string NewEnergyClass
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