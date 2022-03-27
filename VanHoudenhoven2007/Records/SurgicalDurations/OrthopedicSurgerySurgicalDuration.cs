﻿namespace VanHoudenhoven2007.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record OrthopedicSurgerySurgicalDuration : IOrthopedicSurgerySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public OrthopedicSurgerySurgicalDuration(
            IDurationFactory durationFactory)
        {
            this.Category1Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)107,
                Unit = minutes
            };

            this.Category2Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)61,
                Unit = minutes
            };

            this.Category3Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)83,
                Unit = minutes
            };

            this.Category4Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)109,
                Unit = minutes
            };

            this.Category5Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)160,
                Unit = minutes
            };

            this.Category6Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)199,
                Unit = minutes
            };

            this.Category7Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)291,
                Unit = minutes
            };

            this.Category8Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)0,
                Unit = minutes
            };

            this.Category1StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)58,
                Unit = minutes
            };

            this.Category2StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)23,
                Unit = minutes
            };

            this.Category3StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)30,
                Unit = minutes
            };

            this.Category4StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)38,
                Unit = minutes
            };

            this.Category5StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)43,
                Unit = minutes
            };

            this.Category6StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)45,
                Unit = minutes
            };

            this.Category7StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)102,
                Unit = minutes
            };

            this.Category8StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)0,
                Unit = minutes
            };
        }

        public Duration Category1Mean { get; }

        public Duration Category2Mean { get; }

        public Duration Category3Mean { get; }

        public Duration Category4Mean { get; }

        public Duration Category5Mean { get; }

        public Duration Category6Mean { get; }

        public Duration Category7Mean { get; }

        public Duration Category8Mean { get; }

        public Duration Category1StandardDeviation { get; }

        public Duration Category2StandardDeviation { get; }

        public Duration Category3StandardDeviation { get; }

        public Duration Category4StandardDeviation { get; }

        public Duration Category5StandardDeviation { get; }

        public Duration Category6StandardDeviation { get; }

        public Duration Category7StandardDeviation { get; }

        public Duration Category8StandardDeviation { get; }
    }
}