namespace VanHoudenhoven2007.Interfaces.Exports.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public interface ISurgicalFrequencyExport
    {
        INullableValue<decimal> GetSurgicalFrequency(
            IAbstractFactory abstractFactory,
            ISurgicalFrequencyInputContext surgicalFrequencyInputContext);
    }
}