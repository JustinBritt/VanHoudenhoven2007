namespace VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    public interface ISurgicalFrequencyInputContext
    {
        PositiveInt Category { get; }

        CodeableConcept Specialty { get; }
    }
}