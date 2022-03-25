namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class EarNoseThroatSurgerySurgicalFrequencyFactory : IEarNoseThroatSurgerySurgicalFrequencyFactory
    {
        public EarNoseThroatSurgerySurgicalFrequencyFactory()
        {
        }

        public IEarNoseThroatSurgerySurgicalFrequency Create()
        {
            IEarNoseThroatSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new EarNoseThroatSurgerySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}