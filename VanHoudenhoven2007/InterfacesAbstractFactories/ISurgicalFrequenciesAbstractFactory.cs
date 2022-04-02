namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;

    public interface ISurgicalFrequenciesAbstractFactory
    {
        IEarNoseThroatSurgerySurgicalFrequencyFactory CreateEarNoseThroatSurgerySurgicalFrequencyFactory();

        IGeneralSurgerySurgicalFrequencyFactory CreateGeneralSurgerySurgicalFrequencyFactory();

        IGynecologicalSurgerySurgicalFrequencyFactory CreateGynecologicalSurgerySurgicalFrequencyFactory();

        INeurosurgerySurgicalFrequencyFactory CreateNeurosurgerySurgicalFrequencyFactory();

        IOphthalmologySurgicalFrequencyFactory CreateOphthalmologySurgicalFrequencyFactory();

        IOralSurgerySurgicalFrequencyFactory CreateOralSurgerySurgicalFrequencyFactory();

        IOrthopedicSurgerySurgicalFrequencyFactory CreateOrthopedicSurgerySurgicalFrequencyFactory();

        IPlasticSurgerySurgicalFrequencyFactory CreatePlasticSurgerySurgicalFrequencyFactory();

        ISurgicalFrequencyFactory CreateSurgicalFrequencyFactory(
            CodeableConcept specialty);

        ITraumaSurgicalFrequencyFactory CreateTraumaSurgicalFrequencyFactory();

        IUrologySurgicalFrequencyFactory CreateUrologySurgicalFrequencyFactory();
    }
}