namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class UrologySurgicalFrequencyFactory : IUrologySurgicalFrequencyFactory
    {
        public UrologySurgicalFrequencyFactory()
        {
        }

        public IUrologySurgicalFrequency Create(
            INullableValueFactory nullableValueFactory)
        {
            IUrologySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new UrologySurgicalFrequency(
                    nullableValueFactory);
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}