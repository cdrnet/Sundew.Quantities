﻿namespace Sundew.Quantities.Spacetime
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Periodics;

    /// <summary>
    /// Represents a quantity of acceleration.
    /// </summary>
    public partial class Acceleration
    {
        /// <summary>
        /// Multiplies the specified LHS and RHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>The product of the specified LHS and RHS.</returns>
        public static Velocity operator *(Acceleration lhs, Time rhs)
        {
            return new Velocity(QuantityOperations.Multiply(lhs, rhs));
        }
    }
}