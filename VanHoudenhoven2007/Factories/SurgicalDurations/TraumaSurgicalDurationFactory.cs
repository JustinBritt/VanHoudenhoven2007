namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class TraumaSurgicalDurationFactory : ITraumaSurgicalDurationFactory
    {
        public TraumaSurgicalDurationFactory()
        {
        }

        public ITraumaSurgicalDuration Create()
        {
            ITraumaSurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new TraumaSurgicalDuration();
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}