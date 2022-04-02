namespace VanHoudenhoven2007.Factories.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Classes.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalDurations;

    internal sealed class SurgicalDurationOutputContextFactory : ISurgicalDurationOutputContextFactory
    {
        public SurgicalDurationOutputContextFactory()
        {
        }

        public ISurgicalDurationOutputContext Create(
            Duration duration)
        {
            ISurgicalDurationOutputContext context = null;

            try
            {
                context = new SurgicalDurationOutputContext(
                    duration);
            }
            finally
            {
            }

            return context;
        }
    }
}