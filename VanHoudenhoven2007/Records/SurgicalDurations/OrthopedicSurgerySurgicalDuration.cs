namespace VanHoudenhoven2007.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed record OrthopedicSurgerySurgicalDuration : IOrthopedicSurgerySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public OrthopedicSurgerySurgicalDuration(
            IDurationFactory durationFactory)
        {
            this.Category1Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 107m);

            this.Category2Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 61m);

            this.Category3Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 83m);

            this.Category4Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 109m);

            this.Category5Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 160m);

            this.Category6Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 199m);

            this.Category7Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 291m);

            this.Category8Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 0m);

            this.Category1StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 58m);

            this.Category2StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 23m);

            this.Category3StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 30m);

            this.Category4StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 38m);

            this.Category5StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 43m);

            this.Category6StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 45m);

            this.Category7StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 102m);

            this.Category8StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 0m);
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