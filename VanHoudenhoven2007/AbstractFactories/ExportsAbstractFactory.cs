namespace VanHoudenhoven2007.AbstractFactories
{
    using VanHoudenhoven2007.Factories.Exports.SurgicalDurations;
    using VanHoudenhoven2007.Factories.Exports.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.InterfacesFactories.Exports.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Exports.SurgicalFrequencies;

    internal sealed class ExportsAbstractFactory : IExportsAbstractFactory
    {
        public ExportsAbstractFactory()
        {
        }

        public ISurgicalDurationExportFactory CreateSurgicalDurationExportFactory()
        {
            ISurgicalDurationExportFactory factory = null;

            try
            {
                factory = new SurgicalDurationExportFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgicalFrequencyExportFactory CreateSurgicalFrequencyExportFactory()
        {
            ISurgicalFrequencyExportFactory factory = null;

            try
            {
                factory = new SurgicalFrequencyExportFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}