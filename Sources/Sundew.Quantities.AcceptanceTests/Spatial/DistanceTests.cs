﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DistanceTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spatial
{
    using FluentAssertions;

    using Sundew.Quantities.Spatial;
    using Sundew.Quantities.UnitTests;

    using Xunit;

    public class DistanceTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(55080508, 34.225440924998)]
        [InlineData(15508, 0.00963622444921658)]
        public void Distance_ToUnit_When_ConvertingFromMilliMeterToMile_Then_ResultShouldBeAsExpected(
            double length,
            double expected)
        {
            var testee = new Distance(length, x => x.Milli.Meters);

            var result = testee.ToUnit(x => x.Miles);

            result.Value.Should().BeApproximately(expected, TestHelper.DefaultAssertPrecision);
        }
    }
}