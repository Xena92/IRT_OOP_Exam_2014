using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class Truck : Vehicels
    {
        protected string CardType;
        protected double CargoCapacity;
        protected double Hight;
        protected double Weight;
        protected double Lenght;
        protected double MoterSize;


        public void Vehicel(string CardType, double CargoCapacity, double Hight, double Weight, double Lenght,
            string MoterSize)
        {
            this.CardType = CardType;
            this.CargoCapacity = CargoCapacity;
            this.Hight = Hight;
            this.Weight = Weight;
            this.Lenght = Lenght;

        }

        public string SetcardType()
        {
            if (PullHook)
            {
                this.CardType = "CE";
                return this.CardType;
            }
            else
            {
                this.CardType = "C";
                return this.CardType;
            }

      }
        public double SetcargoCapacity
        {
            set { CargoCapacity = value; }
            get { return CargoCapacity;  }
        }

        public double SetHight
        {
            set { Hight = value; }
            get { return Hight;  }
        }

        public double SetWeight
        {
            set { Weight = value; }
            get { return Weight;  }
        }

        public double SetLenght
        {
            set { Lenght = value; }
            get { return Lenght;  }
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

