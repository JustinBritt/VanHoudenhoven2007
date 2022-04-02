namespace VanHoudenhoven2007.AbstractFactories
{
    using VanHoudenhoven2007.InterfacesAbstractFactories;

    public sealed class AbstractFactory : IAbstractFactory
    {
        public AbstractFactory()
        {
        }

        public static IAbstractFactory Create()
        {
            return new AbstractFactory();
        }

        public IContextsAbstractFactory CreateContextsAbstractFactory()
        {
            IContextsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ContextsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IDependenciesAbstractFactory CreateDependenciesAbstractFactory()
        {
            IDependenciesAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new DependenciesAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public ISurgicalDurationsAbstractFactory CreateSurgicalDurationsAbstractFactory()
        {
            ISurgicalDurationsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new SurgicalDurationsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public ISurgicalFrequenciesAbstractFactory CreateSurgicalFrequenciesAbstractFactory()
        {
            ISurgicalFrequenciesAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new SurgicalFrequenciesAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }
    }
}