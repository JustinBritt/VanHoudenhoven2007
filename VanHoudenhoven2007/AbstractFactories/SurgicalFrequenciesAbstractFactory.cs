﻿namespace VanHoudenhoven2007.AbstractFactories
{
    using Hl7.Fhir.Model;

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

        public ISurgicalFrequencyFactory CreateSurgicalFrequencyFactory(
            CodeableConcept specialty)
        {
            ISurgicalFrequencyFactory factory = null;

            try
            {
                factory = specialty.Text switch
                {
                    // EarNoseThroatSurgery
                    "394604002" => this.CreateEarNoseThroatSurgerySurgicalFrequencyFactory(),

                    // GeneralSurgery
                    "394609007" => this.CreateGeneralSurgerySurgicalFrequencyFactory(),

                    // GynecologicalSurgery
                    "394586005" => this.CreateGynecologicalSurgerySurgicalFrequencyFactory(),

                    // Neurosurgery
                    "394610002" => this.CreateNeurosurgerySurgicalFrequencyFactory(),

                    // Ophthalmology
                    "422191005" or "394594003" => this.CreateOphthalmologySurgicalFrequencyFactory(),

                    // OralSurgery
                    "394605001" => this.CreateOralSurgerySurgicalFrequencyFactory(),

                    // OrthopedicSurgery
                    "24241000087106" => this.CreateOrthopedicSurgerySurgicalFrequencyFactory(),

                    // PlasticSurgery
                    "394611003" => this.CreatePlasticSurgerySurgicalFrequencyFactory(),

                    // Trauma
                    "394801008" => this.CreateTraumaSurgicalFrequencyFactory(),

                    // Urology
                    "394612005" => this.CreateUrologySurgicalFrequencyFactory(),

                    _ => null
                };
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