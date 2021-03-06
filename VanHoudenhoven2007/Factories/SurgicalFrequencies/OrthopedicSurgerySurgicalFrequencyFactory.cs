namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class OrthopedicSurgerySurgicalFrequencyFactory : IOrthopedicSurgerySurgicalFrequencyFactory
    {
        public OrthopedicSurgerySurgicalFrequencyFactory()
        {
        }

        public ISurgicalFrequency Create(
            INullableValueFactory nullableValueFactory)
        {
            IOrthopedicSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new OrthopedicSurgerySurgicalFrequency(
                    nullableValueFactory);
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}