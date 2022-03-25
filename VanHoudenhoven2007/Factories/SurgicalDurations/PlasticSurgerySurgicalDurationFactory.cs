namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class PlasticSurgerySurgicalDurationFactory : IPlasticSurgerySurgicalDurationFactory
    {
        public PlasticSurgerySurgicalDurationFactory()
        {
        }

        public IPlasticSurgerySurgicalDuration Create()
        {
            IPlasticSurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new PlasticSurgerySurgicalDuration();
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}