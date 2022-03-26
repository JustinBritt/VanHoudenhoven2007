namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class PlasticSurgerySurgicalFrequencyFactory : IPlasticSurgerySurgicalFrequencyFactory
    {
        public PlasticSurgerySurgicalFrequencyFactory()
        {
        }

        public IPlasticSurgerySurgicalFrequency Create()
        {
            IPlasticSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new PlasticSurgerySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}