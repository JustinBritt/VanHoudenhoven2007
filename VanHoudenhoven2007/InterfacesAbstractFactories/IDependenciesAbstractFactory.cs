namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IDependenciesAbstractFactory
    {
        ICodeableConceptFactory CreateCodeableConceptFactory();

        IDurationFactory CreateDurationFactory();

        INullableValueFactory CreateNullableValueFactory();
    }
}