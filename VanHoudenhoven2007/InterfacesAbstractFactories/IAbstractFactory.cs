namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    public interface IAbstractFactory
    {
        IContextsAbstractFactory CreateContextsAbstractFactory();

        IDependenciesAbstractFactory CreateDependenciesAbstractFactory();

        ISurgicalDurationsAbstractFactory CreateSurgicalDurationsAbstractFactory();

        ISurgicalFrequenciesAbstractFactory CreateSurgicalFrequenciesAbstractFactory();
    }
}