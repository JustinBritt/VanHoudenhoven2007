namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class NeurosurgerySurgicalDurationFactory : INeurosurgerySurgicalDurationFactory
    {
        public NeurosurgerySurgicalDurationFactory()
        {
        }

        public INeurosurgerySurgicalDuration Create()
        {
            INeurosurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new NeurosurgerySurgicalDuration();
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}