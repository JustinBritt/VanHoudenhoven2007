namespace VanHoudenhoven2007.Classes.Exports.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Extensions.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public sealed class SurgicalFrequencyExport : ISurgicalFrequencyExport
    {
        public SurgicalFrequencyExport()
        {
        }

        public INullableValue<decimal> GetSurgicalFrequency(
            IAbstractFactory abstractFactory,
            ISurgicalFrequencyInputContext surgicalFrequencyInputContext)
        {
            return abstractFactory.CreateSurgicalFrequenciesAbstractFactory()
                .CreateSurgicalFrequencyFactory(
                    surgicalFrequencyInputContext.Specialty)
                .Create(
                    abstractFactory.CreateDependenciesAbstractFactory().CreateNullableValueFactory())
                .GetValue(
                    surgicalFrequencyInputContext.Category);
        }
    }
}