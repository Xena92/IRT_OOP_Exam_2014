using System;
using System.Collections.Generic;

namespace CarAuctionSystem
{
    /// <summary>
    ///     Base class for any person or company who wishes to trade
    /// </summary>
    public abstract class Trader : IEquatable<Trader>
    {
        private readonly Dictionary<Vehicle, decimal> _expectedPayments;


        /// <summary>
        ///     The balance fo the trader
        /// </summary>
        protected decimal balance;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Trader" /> class.
        /// </summary>
        /// <param name="balance">The balance of the trader.</param>
        /// <param name="zip">The zip code of the location of the trader.</param>
        protected Trader(decimal balance, uint zip)
        {
            ZipCode = zip;
            this.balance = balance;
            _expectedPayments = new Dictionary<Vehicle, decimal>();
        }

        /// <summary>
        ///     Gets the zip code.
        /// </summary>
        /// <value>
        ///     The zip code.
        /// </value>
        public uint ZipCode { get; private set; }

        /// <summary>
        ///     Gets the balance.
        /// </summary>
        /// <value>
        ///     The balance.
        /// </value>
        public virtual decimal Balance
        {
            get { return balance; }
        }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public virtual bool Equals(Trader other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ZipCode == other.ZipCode;
        }

        /// <summary>
        ///     Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Trader) obj);
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        ///     A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return (int) ZipCode;
        }

        /// <summary>
        ///     Notifies the <see cref="Trader" /> about a offer.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void NotifyAboutOffer(object sender, EventArgs e)
        {
            var eventArgs = e as OfferEventArgs;

            _expectedPayments[eventArgs.Vehicle] = eventArgs.Price - eventArgs.Fees;

            Console.WriteLine("Bid on auction {0}. The price is now on {1} DKK.",
                eventArgs.AuctionNumber, eventArgs.Price);
        }

        /// <summary>
        ///     Executes a payment.
        /// </summary>
        /// <remarks>
        ///     Only planned payments are allowed to be executed.
        ///     This works for both selling and buying, the money amount just has to reflect that.
        /// </remarks>
        /// <param name="money">The money in the payment.</param>
        /// <param name="product">The product.</param>
        /// <returns>returns <c>true</c> if the execution was sucessful; otherwise false</returns>
        public bool ExecutePayment(decimal money, Vehicle product)
        {
            decimal payment;
            _expectedPayments.TryGetValue(product, out payment);

            if (payment != money)
                return false;

            balance += money;
            _expectedPayments.Remove(product);
            return true;
        }

        /// <summary>
        ///     Notifies the <see cref="Trader" /> when their offer is overridden.
        /// </summary>
        /// <param name="vehicle">The vehicle that the trader is trying to buy.</param>
        public void NotifyOfferOverridden(Vehicle vehicle)
        {
            _expectedPayments.Remove(vehicle);
        }

        /// <summary>
        ///     Notifies the <see cref="Trader" /> when their offer is accepted.
        /// </summary>
        /// <remarks>
        ///     This doesn't meant that other bidders may not bid.
        /// </remarks>
        /// <param name="vehicle">The vehicle that is being sold.</param>
        /// <param name="offer">The accepted offer.</param>
        public void NotifyOfferAccepted(Vehicle vehicle, decimal offer)
        {
            _expectedPayments[vehicle] = -offer;
        }

        /// <summary>
        ///     Implements the operator ==.
        /// </summary>
        /// <param name="trader1">The lefthand side trader.</param>
        /// <param name="trader2">The righthand side trader.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator ==(Trader trader1, Trader trader2)
        {
            return trader1.Equals(trader2);
        }

        /// <summary>
        ///     Implements the operator !=.
        /// </summary>
        /// <param name="trader1">The lefthand side trader.</param>
        /// <param name="trader2">The righthand side trader.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator !=(Trader trader1, Trader trader2)
        {
            return !(trader1 == trader2);
        }
    }
}