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