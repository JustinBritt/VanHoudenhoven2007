namespace VanHoudenhoven2007.Records.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;

    public sealed record NeurosurgerySurgicalFrequency : INeurosurgerySurgicalFrequency
    {
        public NeurosurgerySurgicalFrequency()
        {
            this.Category1Frequency = new FhirDecimal((decimal)0.08);

            this.Category2Frequency = new FhirDecimal((decimal)0.17);

            this.Category3Frequency = new FhirDecimal((decimal)0.14);

            this.Category4Frequency = new FhirDecimal((decimal)0.28);

            this.Category5Frequency = new FhirDecimal((decimal)0.12);

            this.Category6Frequency = new FhirDecimal((decimal)0.21);

            this.Category7Frequency = new FhirDecimal((decimal)0);

            this.Category8Frequency = new FhirDecimal((decimal)0);
        }

        public FhirDecimal Category1Frequency { get; }

        public FhirDecimal Category2Frequency { get; }

        public FhirDecimal Category3Frequency { get; }

        public FhirDecimal Category4Frequency { get; }

        public FhirDecimal Category5Frequency { get; }

        public FhirDecimal Category6Frequency { get; }

        public FhirDecimal Category7Frequency { get; }

        public FhirDecimal Category8Frequency { get; }
    }
}