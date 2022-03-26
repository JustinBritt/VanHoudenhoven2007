namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    public interface IAbstractFactory
    {
        IDependenciesAbstractFactory CreateDependenciesAbstractFactory();

        ISurgicalDurationsAbstractFactory CreateSurgicalDurationsAbstractFactory();

        ISurgicalFrequenciesAbstractFactory CreateSurgicalFrequenciesAbstractFactory();
    }
}