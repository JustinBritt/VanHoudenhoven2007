namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class UrologySurgicalFrequencyFactory : IUrologySurgicalFrequencyFactory
    {
        public UrologySurgicalFrequencyFactory()
        {
        }

        public IUrologySurgicalFrequency Create()
        {
            IUrologySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new UrologySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}