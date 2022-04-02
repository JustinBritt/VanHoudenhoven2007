namespace VanHoudenhoven2007.Factories.Contexts.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Classes.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalFrequencies;

    internal sealed class SurgicalFrequencyInputContextFactory : ISurgicalFrequencyInputContextFactory
    {
        public SurgicalFrequencyInputContextFactory()
        {
        }

        public ISurgicalFrequencyInputContext Create(
            PositiveInt category,
            CodeableConcept specialty)
        {
            ISurgicalFrequencyInputContext context = null;

            try
            {
                context = new SurgicalFrequencyInputContext(
                    category,
                    specialty);
            }
            finally
            {
            }

            return context;
        }
    }
}