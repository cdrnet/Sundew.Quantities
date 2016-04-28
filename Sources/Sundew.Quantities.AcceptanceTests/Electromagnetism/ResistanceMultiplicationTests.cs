﻿namespace Sundew.Quantities.AcceptanceTests.Electromagnetism
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;
    using Sundew.Quantities.Electromagnetism;

    using Xunit;

    public class ResistanceMultiplicationTests
    {
        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(4, 0, 0)]
        public void Resistance_Multiplication_Then_ResultIsExpected(double lhs, double rhs, double expected)
        {
            var resistance = new Resistance(lhs, units => units.Milli.Ohms);
            var eletricCurrent = new ElectricCurrent(rhs, units => units.Milli.Amperes);

            var result = resistance * eletricCurrent;

            result.Should().Be(expected, "μV");
        }
    }
}