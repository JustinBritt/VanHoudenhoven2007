namespace VanHoudenhoven2007.Classes.Exports.SurgicalFrequencies
{
    using VanHoudenhoven2007.Extensions.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public sealed class SurgicalFrequencyExport : ISurgicalFrequencyExport
    {
        public SurgicalFrequencyExport()
        {
        }

        public ISurgicalFrequencyOutputContext GetSurgicalFrequency(
            IAbstractFactory abstractFactory,
            ISurgicalFrequencyInputContext surgicalFrequencyInputContext)
        {
            return abstractFactory.CreateContextsAbstractFactory().CreateSurgicalFrequencyOutputContextFactory().Create(
                abstractFactory.CreateSurgicalFrequenciesAbstractFactory()
                .CreateSurgicalFrequencyFactory(
                    surgicalFrequencyInputContext.Specialty)
                .Create(
                    abstractFactory.CreateDependenciesAbstractFactory().CreateNullableValueFactory())
                .GetValue(
                    surgicalFrequencyInputContext.Category));
        }
    }
}