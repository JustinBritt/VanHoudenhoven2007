namespace VanHoudenhoven2007.Records.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record UrologySurgicalFrequency : IUrologySurgicalFrequency
    {
        public UrologySurgicalFrequency(
            INullableValueFactory nullableValueFactory)
        {
            this.Category1Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.03m);

            this.Category2Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.05m);

            this.Category3Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.30m);

            this.Category4Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.15m);

            this.Category5Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.17m);

            this.Category6Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.21m);

            this.Category7Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.08m);

            this.Category8Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0m);
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