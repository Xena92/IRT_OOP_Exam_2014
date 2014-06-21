using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class WorkCar : Car
    {

        public WorkCar(string name, int year, double km, string regNum, double newPrice, bool pullHook, string fuel,
        double moterSize, string energyClass, int amountSeats, double lenght, double hight, double width, int cargoCapacity,
        bool safetieHanger, string NewCardType)
        : base(name, year, km, regNum, newPrice, pullHook, fuel, moterSize, energyClass, amountSeats, lenght, hight, width)
        {
            CargoCapacity = cargoCapacity;
            SafetieHanger = safetieHanger;
        }

        public void vehicel(int cargoCapacity, bool saftieHanger)
        {
            
        }

        public int CargoCapacity
        {
            set;
            get;
        }

        public bool SafetieHanger
        {
            set;
            get;
        }
        public string SetCardType
        {
            set { CardType = "BE"; }
            get { return CardType; }
        }
        public string SetNewEnergyClass
        {
            set
            {
                value = SetEnergyClass();
                EnergyClass = value;
            }
        }
        public double SetNewMorterSize
        {
            set
            {
                value = SetMotorSize(value);
                MoterSize = value;
            }
            get { return MoterSize; }
        }
    }
}
