namespace VanHoudenhoven2007.Factories.Contexts.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Classes.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalFrequencies;

    internal sealed class SurgicalFrequencyOutputContextFactory : ISurgicalFrequencyOutputContextFactory
    {
        public SurgicalFrequencyOutputContextFactory()
        {
        }

        public ISurgicalFrequencyOutputContext Create(
            INullableValue<decimal> frequency)
        {
            ISurgicalFrequencyOutputContext context = null;

            try
            {
                context = new SurgicalFrequencyOutputContext(
                    frequency);
            }
            finally
            {
            }

            return context;
        }
    }
}