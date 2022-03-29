namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class GeneralSurgerySurgicalFrequencyFactory : IGeneralSurgerySurgicalFrequencyFactory
    {
        public GeneralSurgerySurgicalFrequencyFactory()
        {
        }

        public IGeneralSurgerySurgicalFrequency Create(
            INullableValueFactory nullableValueFactory)
        {
            IGeneralSurgerySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new GeneralSurgerySurgicalFrequency(
                    nullableValueFactory);
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}