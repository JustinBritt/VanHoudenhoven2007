namespace VanHoudenhoven2007.Interfaces.Exports.SurgicalFrequencies
{
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public interface ISurgicalFrequencyExport
    {
        ISurgicalFrequencyOutputContext GetSurgicalFrequency(
            IAbstractFactory abstractFactory,
            ISurgicalFrequencyInputContext surgicalFrequencyInputContext);
    }
}