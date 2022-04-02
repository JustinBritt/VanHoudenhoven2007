namespace VanHoudenhoven2007.Factories.Exports.SurgicalFrequencies
{
    using VanHoudenhoven2007.Classes.Exports.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Exports.SurgicalFrequencies;

    internal sealed class SurgicalFrequencyExportFactory : ISurgicalFrequencyExportFactory
    {
        public SurgicalFrequencyExportFactory()
        {
        }

        public ISurgicalFrequencyExport Create()
        {
            ISurgicalFrequencyExport export = null;

            try
            {
                export = new SurgicalFrequencyExport();
            }
            finally
            {
            }

            return export;
        }
    }
}