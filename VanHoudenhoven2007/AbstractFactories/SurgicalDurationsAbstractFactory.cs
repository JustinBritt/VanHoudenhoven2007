namespace VanHoudenhoven2007.AbstractFactories
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Factories.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;

    internal sealed class SurgicalDurationsAbstractFactory : ISurgicalDurationsAbstractFactory
    {
        // Codes
        private const string EarNoseThroatSurgery = "394604002";
        private const string GeneralSurgery = "394609007";
        private const string GynecologicalSurgery = "394586005";
        private const string Neurosurgery = "394610002";
        private const string OphthalmicSurgery = "422191005";
        private const string Ophthalmology = "394594003";
        private const string OralSurgery = "394605001";
        private const string OrthopedicSurgery = "24241000087106";
        private const string PlasticSurgery = "394611003";
        private const string Trauma = "394801008";
        private const string Urology = "394612005";

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

        public ISurgicalDurationFactory CreateSurgicalDurationFactory(
            CodeableConcept specialty)
        {
            ISurgicalDurationFactory factory  = null;

            try
            {
                factory = specialty.Coding[0].Code switch
                {
                    // EarNoseThroatSurgery
                    "394604002" => this.CreateEarNoseThroatSurgerySurgicalDurationFactory(),

                    // GeneralSurgery
                    "394609007" => this.CreateGeneralSurgerySurgicalDurationFactory(),

                    // GynecologicalSurgery
                    "394586005" => this.CreateGynecologicalSurgerySurgicalDurationFactory(),

                    // Neurosurgery
                    "394610002" => this.CreateNeurosurgerySurgicalDurationFactory(),

                    // Ophthalmology
                    "422191005" or "394594003" => this.CreateOphthalmologySurgicalDurationFactory(),

                    // OralSurgery
                    "394605001" => this.CreateOralSurgerySurgicalDurationFactory(),

                    // OrthopedicSurgery
                    "24241000087106" => this.CreateOrthopedicSurgerySurgicalDurationFactory(),

                    // PlasticSurgery
                    "394611003" => this.CreatePlasticSurgerySurgicalDurationFactory(),

                    // Trauma
                    "394801008" => this.CreateTraumaSurgicalDurationFactory(),

                    // Urology
                    "394612005" => this.CreateUrologySurgicalDurationFactory(),

                    _ => null
                };
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