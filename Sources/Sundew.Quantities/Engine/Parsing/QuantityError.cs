﻿namespace Sundew.Quantities.Engine.Parsing
{
    /// <summary>
    /// Enum for errors when parsing quantities.
    /// </summary>
    public enum QuantityError
    {
        /// <summary>
        /// The number not found.
        /// </summary>
        NumberNotFound,

        /// <summary>
        /// The unit not found.
        /// </summary>
        UnitNotFound,

        /// <summary>
        /// The end of data not found.
        /// </summary>
        EndOfDataNotFound
    }
}