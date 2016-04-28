﻿namespace Sundew.Quantities.Engine.Representations.Hierarchical.Units
{
    using System;

    /// <summary>
    /// The <see cref="UnitFormat"/> defines how a unit should be formatted for to string operations.
    /// </summary>
    [Flags]
    public enum UnitFormat
    {
        /// <summary>
        /// The unit notation will be formatted by a to the notation property.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Surround in brackets, means that the unit will be surrounded in square brackets when formatted. E.g. [kg].
        /// </summary>
        SurroundInBrackets = 1,
    }
}