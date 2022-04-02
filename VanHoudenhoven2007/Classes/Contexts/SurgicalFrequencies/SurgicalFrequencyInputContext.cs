namespace VanHoudenhoven2007.Classes.Contexts.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;

    internal sealed class SurgicalFrequencyInputContext : ISurgicalFrequencyInputContext
    {
        public SurgicalFrequencyInputContext(
            PositiveInt category,
            CodeableConcept specialty)
        {
            this.Category = category;

            this.Specialty = specialty;
        }

        public PositiveInt Category { get; }

        public CodeableConcept Specialty { get; }
    }
}