﻿using System;

namespace CarAuctionSystem
{
    /// <summary>
    ///     Private car class that constains relavant information about this kind of vehicle
    /// </summary>
    public class PrivateCar : Car
    {
        private uint _numberOfSeats;

        /// <summary>
        ///     Initializes a new instance of the <see cref="PrivateCar" /> class.
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
        /// <param name="isofix">Wether or not the car has isofix.</param>
        public PrivateCar(string name, decimal newPrice, double motorSize, string regNumber, uint year, uint km,
            bool hitch, double kmPrLiter, FuelType fuelType, uint numberOfSeats, Dimention dimention, bool isofix)
            : base(name, newPrice, motorSize, regNumber, year, km, hitch, kmPrLiter, fuelType, numberOfSeats, dimention)
        {
            Isofix = isofix;
        }

        /// <summary>
        ///     Gets or sets the number of seats int the car.
        /// </summary>
        /// <remarks>
        ///     The number of seat is set to be between 2 and 7 seats and is constrained to these values
        /// </remarks>
        /// <value>
        ///     The number of seats.
        /// </value>
        public override uint NumberOfSeats
        {
            get { return _numberOfSeats; }
            protected set
            {
                value = Math.Max(2, value);
                value = Math.Min(7, value);
                _numberOfSeats = value;
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="PrivateCar" /> is isofix.
        /// </summary>
        /// <value>
        ///     <c>true</c> if isofix; otherwise, <c>false</c>.
        /// </value>
        public bool Isofix { get; set; }

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return base.ToString() + String.Format("\n IsoFix:\t {0}", Isofix);
        }
    }
}