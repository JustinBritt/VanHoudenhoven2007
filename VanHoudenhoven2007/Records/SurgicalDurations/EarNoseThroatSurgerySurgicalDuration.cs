namespace VanHoudenhoven2007.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record EarNoseThroatSurgerySurgicalDuration : IEarNoseThroatSurgerySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public EarNoseThroatSurgerySurgicalDuration(
            IDurationFactory durationFactory)
        {
            this.Category1Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 102m);

            this.Category2Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)40,
                Unit = minutes
            };

            this.Category3Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)65,
                Unit = minutes
            };

            this.Category4Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)102,
                Unit = minutes
            };

            this.Category5Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)127,
                Unit = minutes
            };

            this.Category6Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)182,
                Unit = minutes
            };

            this.Category7Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)254,
                Unit = minutes
            };

            this.Category8Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)549,
                Unit = minutes
            };

            this.Category1StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)125,
                Unit = minutes
            };

            this.Category2StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)17,
                Unit = minutes
            };

            this.Category3StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)24,
                Unit = minutes
            };

            this.Category4StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)35,
                Unit = minutes
            };

            this.Category5StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)32,
                Unit = minutes
            };

            this.Category6StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)65,
                Unit = minutes
            };

            this.Category7StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)75,
                Unit = minutes
            };

            this.Category8StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)203,
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