﻿namespace VanHoudenhoven2007.Records.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record PlasticSurgerySurgicalFrequency : IPlasticSurgerySurgicalFrequency
    {
        public PlasticSurgerySurgicalFrequency(
            INullableValueFactory nullableValueFactory)
        {
            this.Category1Frequency = new FhirDecimal((decimal)0.05);

            this.Category2Frequency = new FhirDecimal((decimal)0.14);

            this.Category3Frequency = new FhirDecimal((decimal)0.17);

            this.Category4Frequency = new FhirDecimal((decimal)0.21);

            this.Category5Frequency = new FhirDecimal((decimal)0.22);

            this.Category6Frequency = new FhirDecimal((decimal)0.11);

            this.Category7Frequency = new FhirDecimal((decimal)0.10);

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