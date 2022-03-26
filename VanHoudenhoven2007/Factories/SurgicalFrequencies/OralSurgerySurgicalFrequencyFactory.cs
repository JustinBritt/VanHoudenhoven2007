namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class OralSurgerySurgicalFrequencyFactory : IOralSurgerySurgicalFrequencyFactory
    {
        public OralSurgerySurgicalFrequencyFactory()
        {
        }

        public IOralSurgerySurgicalFrequency Create()
        {
            IOralSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new OralSurgerySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}