﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Conductance.generated.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// <auto-generated />
namespace Sundew.Quantities
{
    using global::Sundew.Quantities.Core;
    using global::Sundew.Quantities.Representations.Expressions;
    using global::Sundew.Quantities.UnitSelection;
    using global::Sundew.Quantities.UnitSelectors;
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Globalization;

    [GeneratedCode("Sundew.Quantities.Generator", "1.0.0.0")]
    public partial struct Conductance : IQuantity<Conductance, ConductanceUnitSelector>
    {
        private readonly double value;

        public Conductance(double value, SelectUnit<ConductanceUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new ConductanceUnitSelector())))
        {
        }

        public Conductance(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Conductance(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Conductance(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Conductance operator +(Conductance quantity)
        {
            return quantity;
        }

        public static Conductance operator -(Conductance quantity)
        {
            return new Conductance(-quantity.value, quantity.Unit);
        }

        public static Conductance operator ++(Conductance quantity)
        {
            return new Conductance(quantity.value + 1, quantity.Unit);
        }

        public static Conductance operator --(Conductance quantity)
        {
            return new Conductance(quantity.value - 1, quantity.Unit);
        }

        public static Conductance operator +(Conductance lhs, double rhs)
        {
            return new Conductance(lhs.value + rhs, lhs.Unit);
        }

        public static Conductance operator -(Conductance lhs, double rhs)
        {
            return new Conductance(lhs.value - rhs, lhs.Unit);
        }

        public static Conductance operator *(Conductance lhs, double rhs)
        {
            return new Conductance(lhs.value * rhs, lhs.Unit);
        }

        public static Conductance operator /(Conductance lhs, double rhs)
        {
            return new Conductance(lhs.value / rhs, lhs.Unit);
        }

        public static Conductance operator +(Conductance lhs, Conductance rhs)
        {
            return new Conductance(QuantityOperations.Add(lhs, rhs));
        }

        public static Conductance operator -(Conductance lhs, Conductance rhs)
        {
            return new Conductance(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Conductance lhs, Conductance rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Conductance lhs, Conductance rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Conductance lhs, Conductance rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Conductance lhs, Conductance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Conductance lhs, Conductance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Conductance lhs, Conductance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Conductance lhs, Conductance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Conductance> Interval(double min, double max, SelectUnit<ConductanceUnitSelector> unitSelector)
        {
            return new Interval<Conductance>(min, max, unitSelector(new ConductanceUnitSelector()));
        }

        public Squared<Conductance> Squared()
        {
            return new Squared<Conductance>(this);
        }

        public Cubed<Conductance> Cubed()
        {
            return new Cubed<Conductance>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Conductance ToUnit(IUnit unit)
        {
            return new Conductance(this.ToDouble(unit), unit);
        }

        public Conductance ToUnit(SelectUnit<ConductanceUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new ConductanceUnitSelector())));
        }

        public double ToDouble(SelectUnit<ConductanceUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new ConductanceUnitSelector())));
        }

        public override int GetHashCode()
        {
            return QuantityHelper.GetHashCode(this);
        }

        public override bool Equals(object obj)
        {
            return QuantityHelper.AreEqual(this, obj);
        }

        public bool Equals(IQuantity quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public bool Equals(Conductance quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Conductance>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Conductance quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public override string ToString()
        {
            return this.ToString(CultureInfo.CurrentCulture);
        }

        public string ToString(UnitFormat unitFormat)
        {
            return this.ToString(unitFormat, null, CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(IFormatProvider formatProvider)
        {
            return this.ToString(null, formatProvider);
        }

        public string ToString(UnitFormat unitFormat, string format)
        {
            return this.ToString(unitFormat, format, CultureInfo.CurrentCulture);
        }

        public string ToString(UnitFormat unitFormat, IFormatProvider formatProvider)
        {
            return this.ToString(unitFormat, null, formatProvider);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return this.ToString(UnitFormat.Default, format, formatProvider);
        }

        public string ToString(UnitFormat unitFormat, string format, IFormatProvider formatProvider)
        {
            return QuantityHelper.ToString(
                this.Unit.FormatValue(this.value, format, formatProvider),
                UnitFormatHelper.GetNotation(this.Unit, unitFormat));
        }

        public Conductance CreateQuantity(double value, IUnit unit)
        {
            return new Conductance(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        ConductanceUnitSelector IQuantity<Conductance, ConductanceUnitSelector>.CreateUnitSelector()
        {
            return new ConductanceUnitSelector();
        }
    }
}