namespace VanHoudenhoven2007.Classes.Contexts.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;

    internal sealed class SurgicalFrequencyOutputContext : ISurgicalFrequencyOutputContext
    {
        public SurgicalFrequencyOutputContext(
            INullableValue<decimal> frequency)
        {
            this.Frequency = frequency;
        }

        public INullableValue<decimal> Frequency { get; }
    }
}