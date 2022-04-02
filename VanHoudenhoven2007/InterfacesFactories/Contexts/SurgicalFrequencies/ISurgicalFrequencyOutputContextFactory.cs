namespace VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;

    public interface ISurgicalFrequencyOutputContextFactory
    {
        ISurgicalFrequencyOutputContext Create(
            INullableValue<decimal> frequency);
    }
}