// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MagnitudeExpression.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Expressions
{
    using System;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;

    /// <summary>
    /// Represents order of magnitude operation of an expression and a constant.
    /// </summary>
    public sealed class MagnitudeExpression : Expression, IEquatable<MagnitudeExpression>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagnitudeExpression" /> class.
        /// </summary>
        /// <param name="lhs">The LHS <see cref="Expression"/>.</param>
        /// <param name="constantExpression">The constant expression.</param>
        public MagnitudeExpression(Expression lhs, ConstantExpression constantExpression)
        {
            this.Lhs = lhs;
            this.Rhs = constantExpression;
        }

        /// <summary>
        /// Gets the LHS.
        /// </summary>
        /// <value>
        /// The LHS <see cref="Expression"/>.
        /// </value>
        public Expression Lhs { get; }

        /// <summary>
        /// Gets the RHS.
        /// </summary>
        /// <value>
        /// The RHS <see cref="ConstantExpression"/>.
        /// </value>
        public ConstantExpression Rhs { get; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        ///     <c>true</c> if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(MagnitudeExpression other)
        {
            return Equals(this.Lhs, other.Lhs) && Equals(this.Rhs, other.Rhs);
        }

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter">The type of the parameter.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter">The parameter.</param>
        public override void Visit<TParameter, TResult>(
            IExpressionVisitor<TParameter, TResult> expressionVisitor,
            TParameter parameter)
        {
            expressionVisitor.Magnitude(this, parameter);
        }

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
        /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        public override void Visit<TParameter1, TParameter2, TResult>(
            IExpressionVisitor<TParameter1, TParameter2, TResult> expressionVisitor,
            TParameter1 parameter1,
            TParameter2 parameter2)
        {
            expressionVisitor.Magnitude(this, parameter1, parameter2);
        }

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
        /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
        /// <typeparam name="TParameter3">The type of the parameter3.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        public override void Visit<TParameter1, TParameter2, TParameter3, TResult>(
            IExpressionVisitor<TParameter1, TParameter2, TParameter3, TResult> expressionVisitor,
            TParameter1 parameter1,
            TParameter2 parameter2,
            TParameter3 parameter3)
        {
            expressionVisitor.Magnitude(this, parameter1, parameter2, parameter3);
        }

        /// <summary>
        /// Visits the specified expression visitor.
        /// </summary>
        /// <typeparam name="TParameter1">The type of the parameter1.</typeparam>
        /// <typeparam name="TParameter2">The type of the parameter2.</typeparam>
        /// <typeparam name="TParameter3">The type of the parameter3.</typeparam>
        /// <typeparam name="TParameter4">The type of the parameter4.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="expressionVisitor">The expression visitor.</param>
        /// <param name="parameter1">The parameter1.</param>
        /// <param name="parameter2">The parameter2.</param>
        /// <param name="parameter3">The parameter3.</param>
        /// <param name="parameter4">The parameter4.</param>
        public override void Visit<TParameter1, TParameter2, TParameter3, TParameter4, TResult>(
            IExpressionVisitor<TParameter1, TParameter2, TParameter3, TParameter4, TResult> expressionVisitor,
            TParameter1 parameter1,
            TParameter2 parameter2,
            TParameter3 parameter3,
            TParameter4 parameter4)
        {
            expressionVisitor.Magnitude(this, parameter1, parameter2, parameter3, parameter4);
        }
    }
}