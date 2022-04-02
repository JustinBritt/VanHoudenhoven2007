namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class TraumaSurgicalFrequencyFactory : ITraumaSurgicalFrequencyFactory
    {
        public TraumaSurgicalFrequencyFactory()
        {
        }

        public ISurgicalFrequency Create(
            INullableValueFactory nullableValueFactory)
        {
            ITraumaSurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new TraumaSurgicalFrequency(
                    nullableValueFactory);
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}