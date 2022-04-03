namespace VanHoudenhoven2007.Factories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class DurationFactory : IDurationFactory
    {
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public DurationFactory()
        {
        }

        public Duration Create()
        {
            Duration duration;

            try
            {
                duration = new Duration();
            }
            finally
            {
            }

            return duration;
        }

        public Duration Create(
            string unit,
            decimal value)
        {
            return this.Create(
                unitsofmeasure,
                unit,
                value);
        }

        public Duration Create(
            string system,
            string unit,
            decimal value)
        {
            Duration duration = null;

            try
            {
                duration = new Duration()
                {
                    System = system,
                    Unit = unit,
                    Value = value
                };
            }
            finally
            {
            }

            return duration;
        }
    }
}