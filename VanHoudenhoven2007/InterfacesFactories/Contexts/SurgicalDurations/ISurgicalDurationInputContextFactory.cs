namespace VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;

    public interface ISurgicalDurationInputContextFactory
    {
        ISurgicalDurationInputContext Create(
            INullableValue<int> category,
            CodeableConcept specialty,
            Code statistic);
    }
}