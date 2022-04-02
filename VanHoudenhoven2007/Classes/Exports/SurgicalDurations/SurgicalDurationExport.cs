namespace VanHoudenhoven2007.Classes.Exports.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Extensions.SurgicalDurations;
    using VanHoudenhoven2007.Extensions.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public sealed class SurgicalDurationExport : ISurgicalDurationExport
    {
        public SurgicalDurationExport()
        {
        }

        public ISurgicalDurationOutputContext GetSurgicalDuration(
            IAbstractFactory abstractFactory,
            ISurgicalDurationInputContext surgicalDurationInputContext)
        {
            return abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationOutputContextFactory().Create(
                abstractFactory.CreateSurgicalDurationsAbstractFactory()
                .CreateSurgicalDurationFactory(
                    surgicalDurationInputContext.Specialty)
                .Create(
                    abstractFactory.CreateDependenciesAbstractFactory().CreateDurationFactory())
                .GetValue(
                    surgicalDurationInputContext.Category,
                    surgicalDurationInputContext.Statistic));
        }
    }
}