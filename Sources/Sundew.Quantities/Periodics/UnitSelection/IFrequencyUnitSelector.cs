﻿namespace Sundew.Quantities.Periodics.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Interface for <see cref="Frequency"/> unit selector.
    /// </summary>
    public interface IFrequencyUnitSelector : ITimeUnitSelector
    {
        /// <summary>
        /// Gets the one.
        /// </summary>
        /// <value>
        /// The one <see cref="Expression"/>.
        /// </value>
        Expression One { get; }

        /// <summary>
        /// Gets the hertz.
        /// </summary>
        /// <value>
        /// The hertz <see cref="Expression"/>.
        /// </value>
        Expression Hertz { get; }
    }
}