﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IntervalTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests
{
    using FluentAssertions;

    using Sundew.Quantities.Spatial;

    using Xunit;

    public class IntervalTests
    {
        [Theory]
        [InlineData(2.9999, false)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, true)]
        [InlineData(5.000001, false)]
        public void Contains_Then_ResultShouldBeExpectedResult(double value, bool expectedResult)
        {
            var testee = Distance.Interval(3000, 5000, x => x.Milli.Meters);

            var result = testee.Contains(value.Meters());

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Center_Then_ResultShouldBeExpectedResult()
        {
            var testee = Distance.Interval(3000, 5000, x => x.Milli.Meters);

            var result = testee.Center;

            result.Should().Be(4000);
        }

        [Fact]
        public void Length_Then_ResultShouldBeExpectedResult()
        {
            var testee = Distance.Interval(3000, 5000, x => x.Milli.Meters);

            var result = testee.Length;

            result.Should().Be(2000);
        }

        [Fact]
        public void Radius_Then_ResultShouldBeExpectedResult()
        {
            var testee = Distance.Interval(3000, 5000, x => x.Milli.Meters);

            var result = testee.Radius;

            result.Should().Be(1000);
        }

        [Fact]
        public void ToString_Then_ResultShouldBeExpectedResult()
        {
            var testee = Distance.Interval(3000, 5000, x => x.Milli.Meters);

            var result = testee.ToString();

            result.Should().Be("Interval: 3000, 5000 [mm]");
        }
    }
}