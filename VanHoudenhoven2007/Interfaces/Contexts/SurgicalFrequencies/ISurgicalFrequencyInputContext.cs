namespace VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    public interface ISurgicalFrequencyInputContext
    {
        INullableValue<int> Category { get; }

        CodeableConcept Specialty { get; }
    }
}