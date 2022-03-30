namespace VanHoudenhoven2007.Records.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record GynecologicalSurgerySurgicalFrequency : IGynecologicalSurgerySurgicalFrequency
    {
        public GynecologicalSurgerySurgicalFrequency(
            INullableValueFactory nullableValueFactory)
        {
            this.Category1Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.02m);

            this.Category2Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.14m);

            this.Category3Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.19m);

            this.Category4Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.25m);

            this.Category5Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.32m);

            this.Category6Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.02m);

            this.Category7Frequency = (FhirDecimal)nullableValueFactory.Create<decimal>(
                0.06m);

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