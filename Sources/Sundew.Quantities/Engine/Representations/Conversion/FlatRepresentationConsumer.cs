﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatRepresentationConsumer.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Conversion
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;

    /// <summary>
    /// Allows consuming <see cref="IFlatIdentifierRepresentation"/>s once when converting then back into <see cref="Expression"/>s.
    /// </summary>
    public sealed class FlatRepresentationConsumer
    {
        private readonly Dictionary<string, IFlatIdentifierRepresentation> flatIdentifierRepresentations;

        private readonly HashSet<string> usedExpressions;

        internal FlatRepresentationConsumer(
            Dictionary<string, IFlatIdentifierRepresentation> flatIdentifierRepresentations)
        {
            this.flatIdentifierRepresentations = flatIdentifierRepresentations;
            this.usedExpressions = new HashSet<string>();
        }

        /// <summary>
        /// Gets the resulting expression.
        /// </summary>
        /// <param name="unitExpression">The unit expression.</param>
        /// <param name="reduceByBaseUnit">If set to <c>true</c> reduction will be done using base units.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public Expression GetResultingExpression(UnitExpression unitExpression, bool reduceByBaseUnit)
        {
            var unitNotation = reduceByBaseUnit ? unitExpression.Unit.BaseUnit.Notation : unitExpression.Unit.Notation;
            return this.GetResultingExpression(unitNotation);
        }

        /// <summary>
        /// Gets the resulting expression.
        /// </summary>
        /// <param name="constantExpression">The constant expression.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public Expression GetResultingExpression(ConstantExpression constantExpression)
        {
            return this.GetResultingExpression(FlatRepresentationBuilder.Constant);
        }

        /// <summary>
        /// Gets the resulting expression.
        /// </summary>
        /// <param name="variableExpression">The variable expression.</param>
        /// <returns>An <see cref="Expression"/>.</returns>
        public Expression GetResultingExpression(VariableExpression variableExpression)
        {
            return this.GetResultingExpression(variableExpression.VariableName);
        }

        private Expression GetResultingExpression(string identifier)
        {
            IFlatIdentifierRepresentation flatIdentifierRepresentation;
            if (this.flatIdentifierRepresentations.TryGetValue(identifier, out flatIdentifierRepresentation)
                && !this.usedExpressions.Contains(identifier))
            {
                this.usedExpressions.Add(identifier);
                return flatIdentifierRepresentation.ToResultingExpression();
            }

            return null;
        }
    }
}