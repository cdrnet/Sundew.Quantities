﻿namespace Sundew.Quantities.Formatters.MathML
{
    using System.Xml.Linq;

    /// <summary>
    /// Contains values related to MathML.
    /// </summary>
    public static class MathML
    {
        /// <summary>
        /// The MathML namespace
        /// </summary>
        public static readonly XNamespace Namespace = "http://www.w3.org/1998/Math/MathML";

        /// <summary>
        /// The namespace alias
        /// </summary>
        public static readonly XName NamespaceAlias = XNamespace.Xmlns + "mml";

        /// <summary>
        /// The math xname.
        /// </summary>
        public static readonly XName Math = Namespace + "math";

        /// <summary>
        /// The mo xname.
        /// </summary>
        public static readonly XName Mo = Namespace + "mo";

        /// <summary>
        /// The mrow xname.
        /// </summary>
        public static readonly XName Mrow = Namespace + "mrow";

        /// <summary>
        /// The mfrac xname.
        /// </summary>
        public static readonly XName Mfrac = Namespace + "mfrac";

        /// <summary>
        /// The msup xname.
        /// </summary>
        public static readonly XName Msup = Namespace + "msup";

        /// <summary>
        /// The mi xname.
        /// </summary>
        public static readonly XName Mi = Namespace + "mi";

        /// <summary>
        /// The mn xname.
        /// </summary>
        public static readonly XName Mn = Namespace + "mn";

        /// <summary>
        /// The math variant normal
        /// </summary>
        public static readonly XAttribute MathVariantNormal = new XAttribute("mathvariant", "normal");

        /// <summary>
        /// The class unit
        /// </summary>
        public static readonly XAttribute ClassUnit = new XAttribute("class", "MathML-Unit");

        /// <summary>
        /// The mfenced xname.
        /// </summary>
        public static XName Mfenced = Namespace + "mfenced";

        public static readonly XAttribute OpenLeftBracket = new XAttribute("open", "[");

        public static readonly XAttribute CloseRightBrack = new XAttribute("close", "]");

        /// <summary>
        /// The multiplication cross
        /// </summary>
        public const string MultiplicationCross = "×";

        /// <summary>
        /// The multiplication invisible
        /// </summary>
        public const string MultiplicationInvisible = "\x2062";

        /// <summary>
        /// The multiplication dot
        /// </summary>
        public const string MultiplicationDot = "·";

        /// <summary>
        /// The multiplication star
        /// </summary>
        public const string MultiplicationStar = "*";

        /// <summary>
        /// Gets the multiplication sign as a string.
        /// </summary>
        /// <param name="multiplicationSign">The multiplication sign.</param>
        /// <returns>The multiplication sign.</returns>
        public static string GetMultiplicationSign(MultiplicationSign multiplicationSign)
        {
            switch (multiplicationSign)
            {
                case MultiplicationSign.Dot:
                    return MultiplicationDot;
                case MultiplicationSign.Star:
                    return MultiplicationStar;
                case MultiplicationSign.Cross:
                    return MultiplicationCross;
                default:
                    return MultiplicationInvisible;
            }
        }
    }
}