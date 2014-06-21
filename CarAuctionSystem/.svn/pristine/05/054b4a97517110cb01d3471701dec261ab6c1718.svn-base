namespace CarAuctionSystem
{
    /// <summary>
    ///     A private person class that is able to trade
    /// </summary>
    public class PrivatePerson : Trader
    {
        /// <summary>
        ///     The CPR number
        /// </summary>
        public readonly string CPR;

        /// <summary>
        ///     Initializes a new instance of the <see cref="PrivatePerson" /> class.
        /// </summary>
        /// <param name="balance">The balance of the trader.</param>
        /// <param name="zip">The zip code.</param>
        /// <param name="cpr">The CPR number of the person.</param>
        public PrivatePerson(decimal balance, uint zip, string cpr) : base(balance, zip)
        {
            CPR = cpr;
        }

        /// <summary>
        ///     Gets the balance of the private person.
        /// </summary>
        /// <value>
        ///     The balance.
        /// </value>
        public override decimal Balance
        {
            get { return balance; }
        }

        /// <summary>
        ///     Indicates whether the current object is equal to another Trader.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public override bool Equals(Trader other)
        {
            if (!base.Equals(other))
                return false;
            if (other.GetType() != GetType())
                return false;
            return Equals(other as PrivatePerson);
        }

        /// <summary>
        ///     Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        ///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(PrivatePerson other)
        {
            return ZipCode == other.ZipCode && CPR == other.CPR;
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
            return Equals((PrivatePerson) obj);
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        ///     A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) ZipCode*397) ^ CPR.GetHashCode();
            }
        }

        /// <summary>
        ///     Implements the operator ==.
        /// </summary>
        /// <param name="person">The lefthand side operand.</param>
        /// <param name="trader">The righthand side operand.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator ==(PrivatePerson person, Trader trader)
        {
            return person != null && person.Equals(trader);
        }

        /// <summary>
        ///     Implements the operator !=.
        /// </summary>
        /// <param name="person">The lefthand side operand.</param>
        /// <param name="trader">The righthand side operand.</param>
        /// <returns>
        ///     The result of the operator.
        /// </returns>
        public static bool operator !=(PrivatePerson person, Trader trader)
        {
            return !(person == trader);
        }
    }
}