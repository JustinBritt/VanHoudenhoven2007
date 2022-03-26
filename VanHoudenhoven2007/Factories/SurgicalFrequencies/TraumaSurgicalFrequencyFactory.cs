namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class TraumaSurgicalFrequencyFactory : ITraumaSurgicalFrequencyFactory
    {
        public TraumaSurgicalFrequencyFactory()
        {
        }

        public ITraumaSurgicalFrequency Create()
        {
            ITraumaSurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new TraumaSurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}