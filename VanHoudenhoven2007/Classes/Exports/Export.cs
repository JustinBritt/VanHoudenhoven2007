namespace VanHoudenhoven2007.Classes.Exports
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Extensions.SurgicalDurations;
    using VanHoudenhoven2007.Extensions.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.Interfaces.Exports;
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public sealed class Export : IExport
    {
        public Export()
        {
        }

        public DataType GetSurgicalDuration(
            IAbstractFactory abstractFactory,
            PositiveInt category,
            CodeableConcept specialty,
            Code statistic)
        {
            return abstractFactory.CreateSurgicalDurationsAbstractFactory()
                .CreateSurgicalDurationFactory(
                    specialty)
                .Create(
                    abstractFactory.CreateDependenciesAbstractFactory().CreateDurationFactory())
                .GetValue(
                    category,
                    statistic);
        }

        public DataType GetSurgicalFrequency(
            IAbstractFactory abstractFactory,
            PositiveInt category,
            CodeableConcept specialty)
        {
            return abstractFactory.CreateSurgicalFrequenciesAbstractFactory()
                .CreateSurgicalFrequencyFactory(
                    specialty)
                .Create(
                    abstractFactory.CreateDependenciesAbstractFactory().CreateNullableValueFactory())
                .GetValue(
                    category);
        }
    }
}