namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    using VanHoudenhoven2007.InterfacesFactories.Exports.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Exports.SurgicalFrequencies;

    public interface IExportsAbstractFactory
    {
        ISurgicalDurationExportFactory CreateSurgicalDurationExportFactory();

        ISurgicalFrequencyExportFactory CreateSurgicalFrequencyExportFactory();
    }
}