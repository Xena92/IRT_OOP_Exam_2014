using System;

namespace CarAuctionSystem
{
    /// <summary>
    ///     Exception for invalid registrations numbers
    /// </summary>
    public class InvalidRegNumberException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="InvalidRegNumberException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InvalidRegNumberException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="InvalidRegNumberException" /> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        ///     The exception that is the cause of the current exception, or a null reference (Nothing in
        ///     Visual Basic) if no inner exception is specified.
        /// </param>
        public InvalidRegNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}