namespace VanHoudenhoven2007.Records.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed record OrthopedicSurgerySurgicalFrequency : IOrthopedicSurgerySurgicalFrequency
    {
        public OrthopedicSurgerySurgicalFrequency(
            INullableValueFactory nullableValueFactory)
        {
            this.Category1Frequency = nullableValueFactory.Create<decimal>(
                0.09m);

            this.Category2Frequency = nullableValueFactory.Create<decimal>(
                0.10m);

            this.Category3Frequency = nullableValueFactory.Create<decimal>(
                0.18m);

            this.Category4Frequency = nullableValueFactory.Create<decimal>(
                0.21m);

            this.Category5Frequency = nullableValueFactory.Create<decimal>(
                0.21m);

            this.Category6Frequency = nullableValueFactory.Create<decimal>(
                0.16m);

            this.Category7Frequency = nullableValueFactory.Create<decimal>(
                0.05m);

            this.Category8Frequency = nullableValueFactory.Create<decimal>(
                0m);
        }

        public INullableValue<decimal> Category1Frequency { get; }

        public INullableValue<decimal> Category2Frequency { get; }

        public INullableValue<decimal> Category3Frequency { get; }

        public INullableValue<decimal> Category4Frequency { get; }

        public INullableValue<decimal> Category5Frequency { get; }

        public INullableValue<decimal> Category6Frequency { get; }

        public INullableValue<decimal> Category7Frequency { get; }

        public INullableValue<decimal> Category8Frequency { get; }
    }
}