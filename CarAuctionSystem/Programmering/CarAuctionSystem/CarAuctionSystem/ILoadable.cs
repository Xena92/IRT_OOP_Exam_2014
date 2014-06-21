﻿namespace CarAuctionSystem
{
    /// <summary>
    ///     Interface for vehicles which can carry some form of load
    /// </summary>
    public interface ILoadable
    {
        /// <summary>
        ///     Gets the maximum payload.
        /// </summary>
        /// <value>
        ///     The maximum payload in kg.
        /// </value>
        uint Payload { get; }
    }
}