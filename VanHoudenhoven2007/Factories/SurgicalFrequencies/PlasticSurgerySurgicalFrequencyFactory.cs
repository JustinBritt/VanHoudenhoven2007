namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class PlasticSurgerySurgicalFrequencyFactory : IPlasticSurgerySurgicalFrequencyFactory
    {
        public PlasticSurgerySurgicalFrequencyFactory()
        {
        }

        public IPlasticSurgerySurgicalFrequency Create(
            INullableValueFactory nullableValueFactory)
        {
            IPlasticSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new PlasticSurgerySurgicalFrequency(
                    nullableValueFactory);
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}