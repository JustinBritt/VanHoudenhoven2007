namespace VanHoudenhoven2007.Factories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class CodeableConceptFactory : ICodeableConceptFactory
    {
        // Codes
        private const string EarNoseThroatSurgery = "394604002";
        private const string GeneralSurgery = "394609007";
        private const string GynecologicalSurgery = "394586005";
        private const string Neurosurgery = "394610002";
        private const string OphthalmicSurgery = "422191005";
        private const string Ophthalmology = "394594003";
        private const string OralSurgery = "394605001";
        private const string OrthopedicSurgery = "24241000087106";
        private const string PlasticSurgery = "394611003";
        private const string Trauma = "394801008";
        private const string Urology = "394612005";

        // System
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

        public CodeableConcept CreateEarNoseThroatSurgery()
        {
            return this.Create(
                code: EarNoseThroatSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateGeneralSurgery()
        {
            return this.Create(
                code: GeneralSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateGynecologicalSurgery()
        {
            return this.Create(
                code: GynecologicalSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateNeurosurgery()
        {
            return this.Create(
                code: Neurosurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateOphthalmicSurgery()
        {
            return this.Create(
                code: OphthalmicSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateOphthalmology()
        {
            return this.Create(
                code: Ophthalmology,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateOralSurgery()
        {
            return this.Create(
                code: OralSurgery,
                system: SNOMEDCT);
        }
    }
}