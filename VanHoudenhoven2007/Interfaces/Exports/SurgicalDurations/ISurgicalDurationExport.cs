namespace VanHoudenhoven2007.Interfaces.Exports.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public interface ISurgicalDurationExport
    {
        DataType GetSurgicalDuration(
            IAbstractFactory abstractFactory,
            ISurgicalDurationInputContext surgicalDurationInputContext);
    }
}