namespace VanHoudenhoven2007.AbstractFactories
{
    using VanHoudenhoven2007.Factories.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalFrequencies;

    internal sealed class SurgicalFrequenciesAbstractFactory : ISurgicalFrequenciesAbstractFactory
    {
        public SurgicalFrequenciesAbstractFactory()
        {
        }

        public IEarNoseThroatSurgerySurgicalFrequencyFactory CreateEarNoseThroatSurgerySurgicalFrequencyFactory()
        {
            IEarNoseThroatSurgerySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new EarNoseThroatSurgerySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGeneralSurgerySurgicalFrequencyFactory CreateGeneralSurgerySurgicalFrequencyFactory()
        {
            IGeneralSurgerySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new GeneralSurgerySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGynecologicalSurgerySurgicalFrequencyFactory CreateGynecologicalSurgerySurgicalFrequencyFactory()
        {
            IGynecologicalSurgerySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new GynecologicalSurgerySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public INeurosurgerySurgicalFrequencyFactory CreateNeurosurgerySurgicalFrequencyFactory()
        {
            INeurosurgerySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new NeurosurgerySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOphthalmologySurgicalFrequencyFactory CreateOphthalmologySurgicalFrequencyFactory()
        {
            IOphthalmologySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new OphthalmologySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOralSurgerySurgicalFrequencyFactory CreateOralSurgerySurgicalFrequencyFactory()
        {
            IOralSurgerySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new OralSurgerySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOrthopedicSurgerySurgicalFrequencyFactory CreateOrthopedicSurgerySurgicalFrequencyFactory()
        {
            IOrthopedicSurgerySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new OrthopedicSurgerySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IPlasticSurgerySurgicalFrequencyFactory CreatePlasticSurgerySurgicalFrequencyFactory()
        {
            IPlasticSurgerySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new PlasticSurgerySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ITraumaSurgicalFrequencyFactory CreateTraumaSurgicalFrequencyFactory()
        {
            ITraumaSurgicalFrequencyFactory factory = null;

            try
            {
                factory = new TraumaSurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IUrologySurgicalFrequencyFactory CreateUrologySurgicalFrequencyFactory()
        {
            IUrologySurgicalFrequencyFactory factory = null;

            try
            {
                factory = new UrologySurgicalFrequencyFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}