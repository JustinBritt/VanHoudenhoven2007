namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class GeneralSurgerySurgicalDurationFactory : IGeneralSurgerySurgicalDurationFactory
    {
        public GeneralSurgerySurgicalDurationFactory()
        {
        }

        public IGeneralSurgerySurgicalDuration Create()
        {
            IGeneralSurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new GeneralSurgerySurgicalDuration();
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}