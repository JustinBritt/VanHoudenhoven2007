namespace VanHoudenhoven2007.AbstractFactories
{
    using VanHoudenhoven2007.Factories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class DependenciesAbstractFactory : IDependenciesAbstractFactory
    {
        public DependenciesAbstractFactory()
        {
        }

        public ICodeableConceptFactory CreateCodeableConceptFactory()
        {
            ICodeableConceptFactory factory = null;

            try
            {
                factory = new CodeableConceptFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IDurationFactory CreateDurationFactory()
        {
            IDurationFactory factory = null;

            try
            {
                factory = new DurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public INullableValueFactory CreateNullableValueFactory()
        {
            INullableValueFactory factory = null;

            try
            {
                factory = new NullableValueFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IValueFactory CreateValueFactory()
        {
            IValueFactory factory = null;

            try
            {
                factory = new ValueFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}