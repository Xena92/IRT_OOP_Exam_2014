using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class Bus : Vehicels
    {
        protected string CardType;
        protected int AmountSeats;
        protected int AmountBeds;
        protected bool Toilet;
        protected double Hight;
        protected double Weight;
        protected double Lenght;
        protected double MoterSize;

        public void Vehicel(string CardType, int AmountSeats, int AmountBeds, bool Toilet, double Hight, double Weight,
            double Lenght, string MoterSize)
        {
            this.CardType = CardType;
            this.AmountSeats = AmountSeats;
            this.AmountBeds = AmountBeds;
            this.Toilet = Toilet;
            this.Hight = Hight;
            this.Weight = Weight;
            this.Lenght = Lenght;
        }

        public int SetAmountSeats
        {
            set { AmountSeats = value; }
            get { return AmountSeats; }
        }

        public int SetAmountBeds
        {
            set { AmountBeds = value; }
            get { return AmountBeds; }
        }

        public void SetToilet(bool toilet)
        {
            this.Toilet = toilet;
        }

        public bool SetToilet()
        {
            return Toilet;
        }

        public double SetHight
        {
            set { Hight = value; }
            get { return Hight; }
        }

        public double SetWeight
        {
            set { Weight = value; }
            get { return Weight; }
        }

        public double SetLength
        {
            set { Lenght = value; }
            get { return Lenght; }
        }

        public string SetCardType()
        {
            if (PullHook)
            {
                this.CardType = "DE";
                return CardType;
            }else
            {
                this.CardType = "D";
                return CardType;
            }
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
