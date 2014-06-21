using System;

namespace CarAuctionSystem
{
    /// <summary>
    ///     Class that represents busses
    /// </summary>
    public class Bus : Vehicle, IInterior, IBigVehicle
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Bus" /> class.
        /// </summary>
        /// <param name="name">The name of the vehicle.</param>
        /// <param name="newPrice">The price of a new model of the vehicle.</param>
        /// <param name="motorSize">Size of the motor in liters.</param>
        /// <param name="regNumber">The registration number of the vehicle.</param>
        /// <param name="year">The year the vehicle was made.</param>
        /// <param name="km">The kilometer the vehicle has driven.</param>
        /// <param name="hitch">Set to <c>true</c> if the car has a hitch.</param>
        /// <param name="kmPrLiter">The km pr liter of the car.</param>
        /// <param name="height">The height of the bus in meters.</param>
        /// <param name="weight">The weight of the bus in kilos.</param>
        /// <param name="length">The length of the bus in meters.</param>
        /// <param name="numberOfSeats">The number of seats in the bus.</param>
        /// <param name="numberOfBeds">The number of beds in the bus.</param>
        /// <param name="toilet">Does the bus have a toilet?</param>
        public Bus(string name, decimal newPrice, double motorSize, string regNumber, uint year, uint km, bool hitch,
            double kmPrLiter, double height, double weight, double length, uint numberOfSeats,
            uint numberOfBeds, bool toilet)
            : base(name, newPrice, motorSize, regNumber, year, km, hitch, kmPrLiter, FuelType.Diesel)
        {
            Height = height;
            Weight = weight;
            Length = length;
            NumberOfSeats = numberOfSeats;
            NumberOfBeds = numberOfBeds;
            Toilet = toilet;
        }

        /// <summary>
        ///     Type D licences are required for busses and DE if there is a hitch attached
        /// </summary>
        /// <value>
        ///     The type of the licence.
        /// </value>
        public override sealed LicenceType LicenceType
        {
            get { return Hitch ? LicenceType.DE : LicenceType.D; }
        }

        /// <summary>
        ///     Height of the bus in meters
        /// </summary>
        /// <value>
        ///     The height of the vehicle.
        /// </value>
        public double Height { get; set; }

        /// <summary>
        ///     Weight of the bus in kilos
        /// </summary>
        /// <value>
        ///     The weight of the vehicle.
        /// </value>
        public double Weight { get; set; }

        /// <summary>
        ///     Length of the bus in meters
        /// </summary>
        /// <value>
        ///     The length of the vehicle.
        /// </value>
        public double Length { get; set; }

        /// <summary>
        ///     Boolean that represent weather or not there are toilets in the bus
        /// </summary>
        /// <value>
        ///     <c>true</c> if there is a toilet; otherwise, <c>false</c>.
        /// </value>
        public bool Toilet { get; set; }

        /// <summary>
        ///     Number of sleeping places in the bus
        /// </summary>
        /// <value>
        ///     The number of beds.
        /// </value>
        public uint NumberOfBeds { get; set; }

        /// <summary>
        ///     Number of seats in the bus
        /// </summary>
        /// <value>
        ///     The number of seats.
        /// </value>
        public uint NumberOfSeats { get; set; }

        /// <summary>
        ///     Returns string that represent the instance of the class
        ///     Adds information to the inherited
        ///     <c>ToString()</c> method and returns that instead
        /// </summary>
        /// <returns>
        ///     string of format <c>[BASETOSTING] seats: [NUMBEROFSEATS] beds: [NUMBEROFBEDS], [(no) toilet]</c>
        /// </returns>
        public override string ToString()
        {
            return base.ToString() +
                   String.Format("\n Weight:\t {2} kg\n" +
                                 " Seats:\t\t {0}\n" +
                                 " Beds:\t\t {1}",
                       NumberOfSeats,
                       NumberOfBeds,
                       Weight);
        }
    }
}