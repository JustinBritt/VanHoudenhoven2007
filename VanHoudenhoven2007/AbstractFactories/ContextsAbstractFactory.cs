namespace VanHoudenhoven2007.AbstractFactories
{
    using VanHoudenhoven2007.Factories.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.Factories.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalFrequencies;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        public ContextsAbstractFactory()
        {
        }

        public ISurgicalDurationInputContextFactory CreateSurgicalDurationInputContextFactory()
        {
            ISurgicalDurationInputContextFactory factory = null;

            try
            {
                factory = new SurgicalDurationInputContextFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgicalDurationOutputContextFactory CreateSurgicalDurationOutputContextFactory()
        {
            ISurgicalDurationOutputContextFactory factory = null;

            try
            {
                factory = new SurgicalDurationOutputContextFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgicalFrequencyInputContextFactory CreateSurgicalFrequencyInputContextFactory()
        {
            ISurgicalFrequencyInputContextFactory factory = null;

            try
            {
                factory = new SurgicalFrequencyInputContextFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgicalFrequencyOutputContextFactory CreateSurgicalFrequencyOutputContextFactory()
        {
            ISurgicalFrequencyOutputContextFactory factory = null;

            try
            {
                factory = new SurgicalFrequencyOutputContextFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}