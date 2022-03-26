namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
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

        ITraumaSurgicalFrequencyFactory CreateTraumaSurgicalFrequencyFactory();

        IUrologySurgicalFrequencyFactory CreateUrologySurgicalFrequencyFactory();
    }
}