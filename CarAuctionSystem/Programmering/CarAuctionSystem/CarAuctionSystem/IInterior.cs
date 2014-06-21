namespace CarAuctionSystem
{
    /// <summary>
    ///     Interface for vehicles with interiors such as seats beds and toilets
    /// </summary>
    public interface IInterior : ISeatable
    {
        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="IInterior" /> has a toilet.
        /// </summary>
        /// <value>
        ///     <c>true</c> if a toilet is present; otherwise, <c>false</c>.
        /// </value>
        bool Toilet { get; set; }

        /// <summary>
        ///     Gets the number of beds.
        /// </summary>
        /// <value>
        ///     The number of beds.
        /// </value>
        uint NumberOfBeds { get; }
    }
}