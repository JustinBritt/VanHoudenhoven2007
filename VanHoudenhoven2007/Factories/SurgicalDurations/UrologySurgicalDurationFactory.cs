namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class UrologySurgicalDurationFactory : IUrologySurgicalDurationFactory
    {
        public UrologySurgicalDurationFactory()
        {
        }

        public IUrologySurgicalDuration Create()
        {
            IUrologySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new UrologySurgicalDuration();
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}