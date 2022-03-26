namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class OphthalmologySurgicalFrequencyFactory : IOphthalmologySurgicalFrequencyFactory
    {
        public OphthalmologySurgicalFrequencyFactory()
        {
        }

        public IOphthalmologySurgicalFrequency Create()
        {
            IOphthalmologySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new OphthalmologySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}