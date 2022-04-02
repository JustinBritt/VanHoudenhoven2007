namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class OralSurgerySurgicalFrequencyFactory : IOralSurgerySurgicalFrequencyFactory
    {
        public OralSurgerySurgicalFrequencyFactory()
        {
        }

        public ISurgicalFrequency Create(
            INullableValueFactory nullableValueFactory)
        {
            IOralSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new OralSurgerySurgicalFrequency(
                    nullableValueFactory);
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}