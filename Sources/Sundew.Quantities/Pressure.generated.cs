﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pressure.generated.cs" company="Hukano">
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
    public partial struct Pressure : IQuantity<Pressure, PressureUnitSelector>
    {
        private readonly double value;

        public Pressure(double value, SelectUnit<PressureUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new PressureUnitSelector())))
        {
        }

        public Pressure(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Pressure(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Pressure(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Pressure operator +(Pressure quantity)
        {
            return quantity;
        }

        public static Pressure operator -(Pressure quantity)
        {
            return new Pressure(-quantity.value, quantity.Unit);
        }

        public static Pressure operator ++(Pressure quantity)
        {
            return new Pressure(quantity.value + 1, quantity.Unit);
        }

        public static Pressure operator --(Pressure quantity)
        {
            return new Pressure(quantity.value - 1, quantity.Unit);
        }

        public static Pressure operator +(Pressure lhs, double rhs)
        {
            return new Pressure(lhs.value + rhs, lhs.Unit);
        }

        public static Pressure operator -(Pressure lhs, double rhs)
        {
            return new Pressure(lhs.value - rhs, lhs.Unit);
        }

        public static Pressure operator *(Pressure lhs, double rhs)
        {
            return new Pressure(lhs.value * rhs, lhs.Unit);
        }

        public static Pressure operator /(Pressure lhs, double rhs)
        {
            return new Pressure(lhs.value / rhs, lhs.Unit);
        }

        public static Pressure operator +(Pressure lhs, Pressure rhs)
        {
            return new Pressure(QuantityOperations.Add(lhs, rhs));
        }

        public static Pressure operator -(Pressure lhs, Pressure rhs)
        {
            return new Pressure(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Pressure lhs, Pressure rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Pressure lhs, Pressure rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Pressure lhs, Pressure rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Pressure lhs, Pressure rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Pressure lhs, Pressure rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Pressure lhs, Pressure rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Pressure lhs, Pressure rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Pressure> Interval(double min, double max, SelectUnit<PressureUnitSelector> unitSelector)
        {
            return new Interval<Pressure>(min, max, unitSelector(new PressureUnitSelector()));
        }

        public Squared<Pressure> Squared()
        {
            return new Squared<Pressure>(this);
        }

        public Cubed<Pressure> Cubed()
        {
            return new Cubed<Pressure>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Pressure ToUnit(IUnit unit)
        {
            return new Pressure(this.ToDouble(unit), unit);
        }

        public Pressure ToUnit(SelectUnit<PressureUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new PressureUnitSelector())));
        }

        public double ToDouble(SelectUnit<PressureUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new PressureUnitSelector())));
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

        public bool Equals(Pressure quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Pressure>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Pressure quantity)
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

        public Pressure CreateQuantity(double value, IUnit unit)
        {
            return new Pressure(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        PressureUnitSelector IQuantity<Pressure, PressureUnitSelector>.CreateUnitSelector()
        {
            return new PressureUnitSelector();
        }
    }
}