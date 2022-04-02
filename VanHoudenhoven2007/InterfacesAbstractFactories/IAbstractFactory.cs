namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    public interface IAbstractFactory
    {
        IContextsAbstractFactory CreateContextsAbstractFactory();

        IDependenciesAbstractFactory CreateDependenciesAbstractFactory();

        IExportsAbstractFactory CreateExportsAbstractFactory();

        ISurgicalDurationsAbstractFactory CreateSurgicalDurationsAbstractFactory();

        ISurgicalFrequenciesAbstractFactory CreateSurgicalFrequenciesAbstractFactory();
    }
}