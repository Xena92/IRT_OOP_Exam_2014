﻿//Alex

using System;

namespace CarAuctionSystem
{
    /// <summary>
    ///     A general class for cars
    /// </summary>
    public abstract class Car : Vehicle, ISeatable
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Car" /> class.
        /// </summary>
        /// <param name="name">The name of the vehicle.</param>
        /// <param name="newPrice">The price of a new model of the vehicle.</param>
        /// <param name="motorSize">Size of the motor in liters.</param>
        /// <param name="regNumber">The registration number of the vehicle.</param>
        /// <param name="year">The year the vehicle was made.</param>
        /// <param name="km">The kilometer the vehicle has driven.</param>
        /// <param name="hitch">Set to <c>true</c> if the car has a hitch.</param>
        /// <param name="kmPrLiter">The km pr liter of the car.</param>
        /// <param name="fuelType">Type of the fuel used by the vehicle.</param>
        /// <param name="numberOfSeats">The number of seats.</param>
        /// <param name="dimention">The dimention of the trunk.</param>
        protected Car(string name, decimal newPrice, double motorSize, string regNumber, uint year, uint km, bool hitch,
            double kmPrLiter, FuelType fuelType, uint numberOfSeats, Dimention dimention)
            : base(name, newPrice, motorSize, regNumber, year, km, hitch, kmPrLiter, fuelType)
        {
            NumberOfSeats = numberOfSeats;
            Dimention = dimention;
        }

        /// <summary>
        ///     Gets the size of the motor in liters.
        /// </summary>
        /// <value>
        ///     The size of the motor.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">
        ///     value;Invalid size. Motors for autocampers can only be between 2.4
        ///     and 6.2 liters.
        /// </exception>
        public override double MotorSize
        {
            get { return motorSize; }
            protected set
            {
                if (value < 0.7 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("value",
                        "Invalid size. Motors for autocampers can only be between 2.4 and 6.2 liters.");
                }
                motorSize = value;
            }
        }

        /// <summary>
        ///     Gets the dimention.
        /// </summary>
        /// <value>
        ///     The dimention.
        /// </value>
        public Dimention Dimention { get; private set; }

        /// <summary>
        ///     Gets the type of the licence needed to drive this vehicle.
        /// </summary>
        /// <value>
        ///     The type of the licence.
        /// </value>
        public override LicenceType LicenceType
        {
            get { return LicenceType.B; }
        }

        /// <summary>
        ///     Gets the number of seats in a vehicle.
        /// </summary>
        /// <value>
        ///     The number of seats.
        /// </value>
        public virtual uint NumberOfSeats { get; protected set; }

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return base.ToString() + string.Format("\n Seats:\t\t {0} ", NumberOfSeats);
        }
    }
}