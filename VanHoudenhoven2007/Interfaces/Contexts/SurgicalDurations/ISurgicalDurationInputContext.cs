namespace VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    public interface ISurgicalDurationInputContext
    {
        INullableValue<int> Category { get; }

        CodeableConcept Specialty { get; }

        Code Statistic { get; }
    }
}