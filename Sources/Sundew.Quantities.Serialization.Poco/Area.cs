// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Area.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Core;
using Sundew.Quantities.Representations;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Area"/> as a serializable type.
    /// </summary>
    public sealed class Area : SerializableQuantity<Quantities.Area>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        public Area()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Area(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instance to a quantity.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Area"/>.</returns>
        public override Quantities.Area ToQuantity()
        {
            return new Quantities.Area(this.Value, this.GetUnit());
        }
    }
}