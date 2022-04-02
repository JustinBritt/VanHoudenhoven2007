namespace VanHoudenhoven2007.Interfaces.Exports.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public interface ISurgicalDurationExport
    {
        ISurgicalDurationOutputContext GetSurgicalDuration(
            IAbstractFactory abstractFactory,
            ISurgicalDurationInputContext surgicalDurationInputContext);
    }
}