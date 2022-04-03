namespace VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    public interface ICodeableConceptFactory
    {
        CodeableConcept Create(
            string code,
            string system,
            string text = null);

        CodeableConcept CreateEarNoseThroatSurgery();

        CodeableConcept CreateGeneralSurgery();

        CodeableConcept CreateGynecologicalSurgery();

        CodeableConcept CreateNeurosurgery();

        CodeableConcept CreateOphthalmicSurgery();

        CodeableConcept CreateOphthalmology();

        CodeableConcept CreateOralSurgery();

        CodeableConcept CreateOrthopedicSurgery();

        CodeableConcept CreatePlasticSurgery();

        CodeableConcept CreateTrauma();

        CodeableConcept CreateUrology();
    }
}