namespace VanHoudenhoven2007.Factories.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Classes.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalDurations;

    internal sealed class SurgicalDurationInputContextFactory : ISurgicalDurationInputContextFactory
    {
        public SurgicalDurationInputContextFactory()
        {
        }

        public ISurgicalDurationInputContext Create(
            INullableValue<int> category,
            CodeableConcept specialty,
            IValue<string> statistic)
        {
            ISurgicalDurationInputContext context = null;

            try
            {
                context = new SurgicalDurationInputContext(
                    category,
                    specialty,
                    statistic);
            }
            finally
            {
            }

            return context;
        }
    }
}