namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class OralSurgerySurgicalDurationFactory : IOralSurgerySurgicalDurationFactory
    {
        public OralSurgerySurgicalDurationFactory()
        {
        }

        public IOralSurgerySurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IOralSurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new OralSurgerySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}