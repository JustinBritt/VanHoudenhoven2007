namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class OrthopedicSurgerySurgicalDurationFactory : IOrthopedicSurgerySurgicalDurationFactory
    {
        public OrthopedicSurgerySurgicalDurationFactory()
        {
        }

        public IOrthopedicSurgerySurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IOrthopedicSurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new OrthopedicSurgerySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}