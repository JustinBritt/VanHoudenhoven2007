namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class EarNoseThroatSurgerySurgicalDurationFactory : IEarNoseThroatSurgerySurgicalDurationFactory
    {
        public EarNoseThroatSurgerySurgicalDurationFactory()
        {
        }

        public IEarNoseThroatSurgerySurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IEarNoseThroatSurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new EarNoseThroatSurgerySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}