namespace VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    public interface ISurgicalFrequencyOutputContext
    {
        INullableValue<decimal> Frequency { get; }
    }
}