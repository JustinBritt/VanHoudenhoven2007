namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class NeurosurgerySurgicalFrequencyFactory : INeurosurgerySurgicalFrequencyFactory
    {
        public NeurosurgerySurgicalFrequencyFactory()
        {
        }

        public INeurosurgerySurgicalFrequency Create()
        {
            INeurosurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new NeurosurgerySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}