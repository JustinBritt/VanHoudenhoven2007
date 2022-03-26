namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class OrthopedicSurgerySurgicalFrequencyFactory : IOrthopedicSurgerySurgicalFrequencyFactory
    {
        public OrthopedicSurgerySurgicalFrequencyFactory()
        {
        }

        public IOrthopedicSurgerySurgicalFrequency Create()
        {
            IOrthopedicSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new OrthopedicSurgerySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}