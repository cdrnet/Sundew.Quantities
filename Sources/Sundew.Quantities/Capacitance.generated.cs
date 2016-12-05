﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Capacitance.generated.cs" company="Hukano">
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
    public partial struct Capacitance : IQuantity<Capacitance, CapacitanceUnitSelector>
    {
        private readonly double value;

        public Capacitance(double value, SelectUnit<CapacitanceUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new CapacitanceUnitSelector())))
        {
        }

        public Capacitance(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Capacitance(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Capacitance(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Capacitance operator +(Capacitance quantity)
        {
            return quantity;
        }

        public static Capacitance operator -(Capacitance quantity)
        {
            return new Capacitance(-quantity.value, quantity.Unit);
        }

        public static Capacitance operator ++(Capacitance quantity)
        {
            return new Capacitance(quantity.value + 1, quantity.Unit);
        }

        public static Capacitance operator --(Capacitance quantity)
        {
            return new Capacitance(quantity.value - 1, quantity.Unit);
        }

        public static Capacitance operator +(Capacitance lhs, double rhs)
        {
            return new Capacitance(lhs.value + rhs, lhs.Unit);
        }

        public static Capacitance operator -(Capacitance lhs, double rhs)
        {
            return new Capacitance(lhs.value - rhs, lhs.Unit);
        }

        public static Capacitance operator *(Capacitance lhs, double rhs)
        {
            return new Capacitance(lhs.value * rhs, lhs.Unit);
        }

        public static Capacitance operator /(Capacitance lhs, double rhs)
        {
            return new Capacitance(lhs.value / rhs, lhs.Unit);
        }

        public static Capacitance operator +(Capacitance lhs, Capacitance rhs)
        {
            return new Capacitance(QuantityOperations.Add(lhs, rhs));
        }

        public static Capacitance operator -(Capacitance lhs, Capacitance rhs)
        {
            return new Capacitance(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Capacitance lhs, Capacitance rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Capacitance lhs, Capacitance rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Capacitance lhs, Capacitance rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Capacitance lhs, Capacitance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Capacitance lhs, Capacitance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Capacitance lhs, Capacitance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Capacitance lhs, Capacitance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Capacitance> Interval(double min, double max, SelectUnit<CapacitanceUnitSelector> unitSelector)
        {
            return new Interval<Capacitance>(min, max, unitSelector(new CapacitanceUnitSelector()));
        }

        public Squared<Capacitance> Squared()
        {
            return new Squared<Capacitance>(this);
        }

        public Cubed<Capacitance> Cubed()
        {
            return new Cubed<Capacitance>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Capacitance ToUnit(IUnit unit)
        {
            return new Capacitance(this.ToDouble(unit), unit);
        }

        public Capacitance ToUnit(SelectUnit<CapacitanceUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new CapacitanceUnitSelector())));
        }

        public double ToDouble(SelectUnit<CapacitanceUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new CapacitanceUnitSelector())));
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

        public bool Equals(Capacitance quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Capacitance>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Capacitance quantity)
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

        public Capacitance CreateQuantity(double value, IUnit unit)
        {
            return new Capacitance(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        CapacitanceUnitSelector IQuantity<Capacitance, CapacitanceUnitSelector>.CreateUnitSelector()
        {
            return new CapacitanceUnitSelector();
        }
    }
}