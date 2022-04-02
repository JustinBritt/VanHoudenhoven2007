namespace VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgicalFrequencyFactory
    {
        ISurgicalFrequency Create(
            INullableValueFactory nullableValueFactory);
    }
}