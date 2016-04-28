﻿namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;

    /// <summary>
    /// Contains metohds for creating <see cref="Error{TErrorInfo}"/>.
    /// </summary>
    public static class Error
    {
        /// <summary>
        /// Creates and <see cref="Error{TErrorInfo}"/> from the specified error information.
        /// </summary>
        /// <typeparam name="TErrorInfo">The type of the error information.</typeparam>
        /// <param name="errorInfo">The error information.</param>
        /// <param name="lexeme">The lexeme.</param>
        /// <param name="innerError">The inner error.</param>
        /// <returns>A <see cref="Error{TErrorInfo}"/>.</returns>
        public static Error<TErrorInfo> From<TErrorInfo>(TErrorInfo errorInfo, Lexeme lexeme, IError innerError = null)
        {
            return new Error<TErrorInfo>(errorInfo, lexeme, innerError);
        }
    }
}