namespace VanHoudenhoven2007.Interfaces.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces;

    public interface ISurgicalFrequency : ISurgicalData
    {
        FhirDecimal Category1Frequency { get; }

        FhirDecimal Category2Frequency { get; }

        FhirDecimal Category3Frequency { get; }

        FhirDecimal Category4Frequency { get; }

        FhirDecimal Category5Frequency { get; }

        FhirDecimal Category6Frequency { get; }

        FhirDecimal Category7Frequency { get; }

        FhirDecimal Category8Frequency { get; }
    }
}