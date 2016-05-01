﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ConvertToUnitOperation.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Convert to unit operation for <see cref="IQuantity"/> instance.
    /// </summary>
    public class ConvertToUnitOperation : IQuantityAndUnitOperation
    {
        /// <summary>
        /// Executes the operation.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>
        /// The resulting value.
        /// </returns>
        public double Execute(IQuantity lhs, IUnit rhs)
        {
            var valueUnit = lhs.Unit;
            var value = lhs.Value;
            if (!UnitHelper.AreUnitsEqual(valueUnit, rhs))
            {
                value = rhs.FromBase(valueUnit.ToBase(value));
            }

            return value;
        }
    }
}