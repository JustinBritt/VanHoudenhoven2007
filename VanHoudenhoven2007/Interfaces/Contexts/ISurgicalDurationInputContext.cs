namespace VanHoudenhoven2007.Interfaces.Contexts
{
    using Hl7.Fhir.Model;

    public interface ISurgicalDurationInputContext
    {
        PositiveInt Category { get; }

        CodeableConcept Specialty { get; }

        Code Statistic { get; }
    }
}