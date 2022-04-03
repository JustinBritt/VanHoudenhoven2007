namespace VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    public interface IValueFactory
    {
        IValue<string> Create(
            string value);

        IValue<string> CreateAverage();

        IValue<string> CreateStdDev();
    }
}