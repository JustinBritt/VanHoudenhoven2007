namespace VanHoudenhoven2007.Classes.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;

    internal sealed class SurgicalDurationInputContext : ISurgicalDurationInputContext
    {
        public SurgicalDurationInputContext(
            INullableValue<int> category,
            CodeableConcept specialty,
            IValue<string> statistic)
        {
            this.Category = category;

            this.Specialty = specialty;

            this.Statistic = statistic;
        }

        public INullableValue<int> Category { get; }

        public CodeableConcept Specialty { get; }

        public IValue<string> Statistic { get; }
    }
}