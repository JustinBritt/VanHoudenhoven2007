namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    public interface IAbstractFactory
    {
        ISurgicalDurationsAbstractFactory CreateSurgicalDurationsAbstractFactory();

        ISurgicalFrequenciesAbstractFactory CreateSurgicalFrequenciesAbstractFactory();
    }
}