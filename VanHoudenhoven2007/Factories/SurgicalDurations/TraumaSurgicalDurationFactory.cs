namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class TraumaSurgicalDurationFactory : ITraumaSurgicalDurationFactory
    {
        public TraumaSurgicalDurationFactory()
        {
        }

        public ITraumaSurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            ITraumaSurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new TraumaSurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}