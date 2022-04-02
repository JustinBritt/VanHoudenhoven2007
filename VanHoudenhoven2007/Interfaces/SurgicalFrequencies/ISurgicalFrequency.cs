namespace VanHoudenhoven2007.Interfaces.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    public interface ISurgicalFrequency
    {
        INullableValue<decimal> Category1Frequency { get; }

        INullableValue<decimal> Category2Frequency { get; }

        INullableValue<decimal> Category3Frequency { get; }

        INullableValue<decimal> Category4Frequency { get; }

        INullableValue<decimal> Category5Frequency { get; }

        INullableValue<decimal> Category6Frequency { get; }

        INullableValue<decimal> Category7Frequency { get; }

        INullableValue<decimal> Category8Frequency { get; }
    }
}