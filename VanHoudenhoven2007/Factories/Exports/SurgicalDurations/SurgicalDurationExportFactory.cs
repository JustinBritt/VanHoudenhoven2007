namespace VanHoudenhoven2007.Factories.Exports.SurgicalDurations
{
    using VanHoudenhoven2007.Classes.Exports.SurgicalDurations;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Exports.SurgicalDurations;

    internal sealed class SurgicalDurationExportFactory : ISurgicalDurationExportFactory
    {
        public SurgicalDurationExportFactory()
        {
        }

        public ISurgicalDurationExport Create()
        {
            ISurgicalDurationExport export = null;

            try
            {
                export = new SurgicalDurationExport();
            }
            finally
            {
            }

            return export;
        }
    }
}