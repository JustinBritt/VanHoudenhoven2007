namespace VanHoudenhoven2007.Factories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;
    using VanHoudenhoven2007.Records.SurgicalFrequencies;

    internal sealed class OphthalmologySurgicalFrequencyFactory : IOphthalmologySurgicalFrequencyFactory
    {
        public OphthalmologySurgicalFrequencyFactory()
        {
        }

        public ISurgicalFrequency Create(
            INullableValueFactory nullableValueFactory)
        {
            IOphthalmologySurgicalFrequency surgicalFrequency = null;

            try
            {
                surgicalFrequency = new OphthalmologySurgicalFrequency(
                    nullableValueFactory);
            }
            finally
            {
            }

            return surgicalFrequency;
        }
    }
}