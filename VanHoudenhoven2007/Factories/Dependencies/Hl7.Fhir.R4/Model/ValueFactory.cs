namespace VanHoudenhoven2007.Factories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ValueFactory : IValueFactory
    {
        public ValueFactory()
        {
        }

        public IValue<string> Create(
            string value)
        {
            IValue<string> instance = null;

            try
            {
                instance = new FhirString(
                    value);
            }
            finally
            {
            }

            return instance;
        }
    }
}