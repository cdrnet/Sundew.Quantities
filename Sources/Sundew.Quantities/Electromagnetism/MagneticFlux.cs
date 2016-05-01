﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MagneticFlux.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Electromagnetism
{
    using Sundew.Quantities.Electromagnetism.UnitSelection;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Represents a magnetic flux quantity.
    /// </summary>
    public sealed partial class MagneticFlux : Quantity<MagneticFlux, MagneticFluxUnitSelector>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux" /> class.
        /// </summary>
        /// <param name="magneticFlux">The magneticFlux.</param>
        /// <param name="magneticFluxUnitSelector">The MagneticFlux unit selector.</param>
        public MagneticFlux(double magneticFlux, SelectUnit<MagneticFluxUnitSelector> magneticFluxUnitSelector)
            : base(magneticFlux, magneticFluxUnitSelector(new MagneticFluxUnitSelector()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux" /> class.
        /// </summary>
        /// <param name="quantity">The quantity operation result.</param>
        public MagneticFlux(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux" /> class.
        /// </summary>
        /// <param name="magneticFlux">The magneticFlux.</param>
        /// <param name="unit">The unit.</param>
        public MagneticFlux(double magneticFlux, IUnit unit)
            : base(magneticFlux, unit)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFlux" /> class.
        /// </summary>
        /// <param name="magneticFlux">The magneticFlux.</param>
        public MagneticFlux(double magneticFlux)
            : this(magneticFlux, x => x.BaseUnit)
        {
        }

        /// <summary>
        /// Gets this instance as a <see cref="MagneticFlux"/>.
        /// </summary>
        /// <value>
        /// This instance.
        /// </value>
        protected override MagneticFlux Self => this;

        /// <summary>
        /// Increments the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The incremented result.</returns>
        public static MagneticFlux operator ++(MagneticFlux lhs)
        {
            return lhs.CreateQuantity(lhs.Value + 1, lhs.Unit);
        }

        /// <summary>
        /// Decrements the specified LHS with 1.
        /// </summary>
        /// <param name="lhs">The LHS.</param>
        /// <returns>The decremented result.</returns>
        public static MagneticFlux operator --(MagneticFlux lhs)
        {
            return lhs.CreateQuantity(lhs.Value - 1, lhs.Unit);
        }

        /// <summary>
        /// Creates the magnetic flux quantity.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        /// <returns>A new <see cref="MagneticFlux"/>.</returns>
        public override MagneticFlux CreateQuantity(double value, IUnit unit)
        {
            return new MagneticFlux(value, unit);
        }

        /// <summary>
        /// Creates the electric current unit selector.
        /// </summary>
        /// <returns>A new <see cref="MagneticFluxUnitSelector"/>.</returns>
        public override MagneticFluxUnitSelector CreateUnitSelector()
        {
            return new MagneticFluxUnitSelector();
        }

        /// <summary>
        /// Creates a interval based on the specified min, max and unit.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="unitSelector">The unit selector.</param>
        /// <returns>The new interval.</returns>
        public static Interval<MagneticFlux> Interval(
            double min,
            double max,
            SelectUnit<MagneticFluxUnitSelector> unitSelector)
        {
            return new Interval<MagneticFlux>(min, max, unitSelector(new MagneticFluxUnitSelector()));
        }
    }
}