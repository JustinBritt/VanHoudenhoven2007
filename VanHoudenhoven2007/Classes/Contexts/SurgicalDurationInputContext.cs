﻿namespace VanHoudenhoven2007.Classes.Contexts
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.Contexts;

    internal sealed class SurgicalDurationInputContext : ISurgicalDurationInputContext
    {
        public SurgicalDurationInputContext(
            PositiveInt category,
            CodeableConcept specialty,
            Code statistic)
        {
            this.Category = category;

            this.Specialty = specialty;

            this.Statistic = statistic;
        }

        public PositiveInt Category { get; }

        public CodeableConcept Specialty { get; }

        public Code Statistic { get; }
    }
}