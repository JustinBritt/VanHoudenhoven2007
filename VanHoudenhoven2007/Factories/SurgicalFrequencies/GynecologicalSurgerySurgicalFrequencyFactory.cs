namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class GynecologicalSurgerySurgicalFrequencyFactory : IGynecologicalSurgerySurgicalFrequencyFactory
    {
        public GynecologicalSurgerySurgicalFrequencyFactory()
        {
        }

        public IGynecologicalSurgerySurgicalFrequency Create()
        {
            IGynecologicalSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new GynecologicalSurgerySurgicalFrequency();
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}