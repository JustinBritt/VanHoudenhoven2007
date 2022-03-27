namespace VanHoudenhoven2007.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record TraumaSurgicalDuration : ITraumaSurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public TraumaSurgicalDuration(
            IDurationFactory durationFactory)
        {
            this.Category1Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 100m);

            this.Category2Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 62m);

            this.Category3Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 81m);

            this.Category4Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 122m);

            this.Category5Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 176m);

            this.Category6Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 0m);

            this.Category7Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 0m);

            this.Category8Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 0m);

            this.Category1StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 68m);

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
                value: 92m);

            this.Category6StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 0m);

            this.Category7StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 0m);

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