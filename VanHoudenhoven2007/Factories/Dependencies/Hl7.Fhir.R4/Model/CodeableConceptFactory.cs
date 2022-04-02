﻿namespace VanHoudenhoven2007.Factories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class CodeableConceptFactory : ICodeableConceptFactory
    {
        private const string EarNoseThroat = "394604002";

        private const string SNOMEDCT = "http://snomed.info/sct";

        public CodeableConceptFactory()
        {
        }

        public CodeableConcept Create(
            string code,
            string system,
            string text = null)
        {
            CodeableConcept codeableConcept;

            try
            {
                codeableConcept = new CodeableConcept(
                    system: system,
                    code: code,
                    text: text);
            }
            finally
            {
            }

            return codeableConcept;
        }

        public CodeableConcept CreateEarNoseThroat()
        {
            return this.Create(
                code: EarNoseThroat,
                system: SNOMEDCT);
        }
    }
}