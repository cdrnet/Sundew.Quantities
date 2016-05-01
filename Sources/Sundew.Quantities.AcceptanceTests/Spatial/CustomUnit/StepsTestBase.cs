﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="StepsTestBase.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Spatial.CustomUnit
{
    using System;

    using Sundew.Quantities.Engine;
    using Sundew.Quantities.Engine.Units;

    public abstract class StepsTestBase : IDisposable
    {
        protected readonly FactoredUnit StepsUnit = new FactoredUnit(
            (1 / 53.4323198) / 1000,
            "steps",
            UnitDefinitions.Meter);

        protected StepsTestBase()
        {
            UnitSystem.InitializeWithDefaults(null, unitRegistry => unitRegistry.Register(this.StepsUnit));
        }

        public void Dispose()
        {
            UnitSystem.Reset();
        }
    }
}