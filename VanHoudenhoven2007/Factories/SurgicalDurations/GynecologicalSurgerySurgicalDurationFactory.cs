namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class GynecologicalSurgerySurgicalDurationFactory : IGynecologicalSurgerySurgicalDurationFactory
    {
        public GynecologicalSurgerySurgicalDurationFactory()
        {
        }

        public IGynecologicalSurgerySurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IGynecologicalSurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new GynecologicalSurgerySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}