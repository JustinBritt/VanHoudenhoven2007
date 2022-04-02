namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;

    public interface ISurgicalDurationsAbstractFactory
    {
        IEarNoseThroatSurgerySurgicalDurationFactory CreateEarNoseThroatSurgerySurgicalDurationFactory();

        IGeneralSurgerySurgicalDurationFactory CreateGeneralSurgerySurgicalDurationFactory();

        IGynecologicalSurgerySurgicalDurationFactory CreateGynecologicalSurgerySurgicalDurationFactory();

        INeurosurgerySurgicalDurationFactory CreateNeurosurgerySurgicalDurationFactory();

        IOphthalmologySurgicalDurationFactory CreateOphthalmologySurgicalDurationFactory();

        IOralSurgerySurgicalDurationFactory CreateOralSurgerySurgicalDurationFactory();

        IOrthopedicSurgerySurgicalDurationFactory CreateOrthopedicSurgerySurgicalDurationFactory();

        IPlasticSurgerySurgicalDurationFactory CreatePlasticSurgerySurgicalDurationFactory();

        ISurgicalDurationFactory CreateSurgicalDurationFactory(
            CodeableConcept specialty);

        ITraumaSurgicalDurationFactory CreateTraumaSurgicalDurationFactory();

        IUrologySurgicalDurationFactory CreateUrologySurgicalDurationFactory();
    }
}