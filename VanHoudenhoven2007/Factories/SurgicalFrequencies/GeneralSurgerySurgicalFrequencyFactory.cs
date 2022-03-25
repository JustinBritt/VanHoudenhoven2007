namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class GeneralSurgerySurgicalFrequencyFactory : IGeneralSurgerySurgicalFrequencyFactory
    {
        public GeneralSurgerySurgicalFrequencyFactory()
        {
        }

        public IGeneralSurgerySurgicalFrequency Create()
        {
            IGeneralSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new GeneralSurgerySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}