namespace VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    public interface ISurgicalDurationOutputContext
    {
        Duration Duration { get; }
    }
}