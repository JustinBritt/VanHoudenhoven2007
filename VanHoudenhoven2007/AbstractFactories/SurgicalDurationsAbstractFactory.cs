namespace VanHoudenhoven2007.AbstractFactories
{
    using VanHoudenhoven2007.Factories.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;

    internal sealed class SurgicalDurationsAbstractFactory : ISurgicalDurationsAbstractFactory
    {
        public SurgicalDurationsAbstractFactory()
        {
        }

        public IEarNoseThroatSurgerySurgicalDurationFactory CreateEarNoseThroatSurgerySurgicalDurationFactory()
        {
            IEarNoseThroatSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new EarNoseThroatSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGeneralSurgerySurgicalDurationFactory CreateGeneralSurgerySurgicalDurationFactory()
        {
            IGeneralSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new GeneralSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGynecologicalSurgerySurgicalDurationFactory CreateGynecologicalSurgerySurgicalDurationFactory()
        {
            IGynecologicalSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new GynecologicalSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public INeurosurgerySurgicalDurationFactory CreateNeurosurgerySurgicalDurationFactory()
        {
            INeurosurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new NeurosurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOphthalmologySurgicalDurationFactory CreateOphthalmologySurgicalDurationFactory()
        {
            IOphthalmologySurgicalDurationFactory factory = null;

            try
            {
                factory = new OphthalmologySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOralSurgerySurgicalDurationFactory CreateOralSurgerySurgicalDurationFactory()
        {
            IOralSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new OralSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOrthopedicSurgerySurgicalDurationFactory CreateOrthopedicSurgerySurgicalDurationFactory()
        {
            IOrthopedicSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new OrthopedicSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IPlasticSurgerySurgicalDurationFactory CreatePlasticSurgerySurgicalDurationFactory()
        {
            IPlasticSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new PlasticSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ITraumaSurgicalDurationFactory CreateTraumaSurgicalDurationFactory()
        {
            ITraumaSurgicalDurationFactory factory = null;

            try
            {
                factory = new TraumaSurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IUrologySurgicalDurationFactory CreateUrologySurgicalDurationFactory()
        {
            IUrologySurgicalDurationFactory factory = null;

            try
            {
                factory = new UrologySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}