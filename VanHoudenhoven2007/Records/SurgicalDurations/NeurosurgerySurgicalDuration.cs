namespace VanHoudenhoven2007.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record NeurosurgerySurgicalDuration : INeurosurgerySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public NeurosurgerySurgicalDuration(
            IDurationFactory durationFactory)
        {
            this.Category1Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)192,
                Unit = minutes
            };

            this.Category2Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)113,
                Unit = minutes
            };

            this.Category3Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)171,
                Unit = minutes
            };

            this.Category4Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)255,
                Unit = minutes
            };

            this.Category5Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)324,
                Unit = minutes
            };

            this.Category6Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)492,
                Unit = minutes
            };

            this.Category7Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)0,
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
                Value = (decimal)165,
                Unit = minutes
            };

            this.Category2StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)41,
                Unit = minutes
            };

            this.Category3StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)62,
                Unit = minutes
            };

            this.Category4StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)62,
                Unit = minutes
            };

            this.Category5StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)73,
                Unit = minutes
            };

            this.Category6StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)177,
                Unit = minutes
            };

            this.Category7StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)0,
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