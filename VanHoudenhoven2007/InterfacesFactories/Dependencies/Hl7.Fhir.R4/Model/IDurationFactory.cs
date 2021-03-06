namespace VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    public interface IDurationFactory
    {
        Duration Create();

        Duration Create(
            string unit,
            decimal value);

        Duration Create(
            string system,
            string unit,
            decimal value);
    }
}