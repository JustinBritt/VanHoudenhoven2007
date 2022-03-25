namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class OphthalmologySurgicalDurationFactory : IOphthalmologySurgicalDurationFactory
    {
        public OphthalmologySurgicalDurationFactory()
        {
        }

        public IOphthalmologySurgicalDuration Create()
        {
            IOphthalmologySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new OphthalmologySurgicalDuration();
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}