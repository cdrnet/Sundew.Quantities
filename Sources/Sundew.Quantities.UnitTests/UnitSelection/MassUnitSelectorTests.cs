﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MassUnitSelectorTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using FluentAssertions;
using Sundew.Quantities.Core;
using Sundew.Quantities.Representations.Units;
using Sundew.Quantities.UnitSelection;
using Sundew.Quantities.UnitSelectors;
using Xunit;

namespace Sundew.Quantities.UnitTests.UnitSelection
{
    public class MassUnitSelectorTests
    {
        private readonly MassUnitSelector testee = new MassUnitSelector();

        [Fact]
        public void KiloGramBuildUnit_Then_ResultShouldBePrefixedBaseUnit()
        {
            var result = UnitBuilder.BuildUnit(this.testee.KiloGrams);

            result.Should().BeOfType<PrefixedBaseUnit>();
        }

        [Fact]
        public void KiloGramUnitNotation_When_UsingPrefixSelector_Then_ResultShouldBePrefixedBaseUnit()
        {
            var result = UnitBuilder.BuildUnit(this.testee.Kilo.Grams).BaseUnit;

            result.Should().Be(UnitDefinitions.KiloGram);
        }
    }
}