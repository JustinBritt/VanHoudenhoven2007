namespace VanHoudenhoven2007.Records.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed record TraumaSurgicalFrequency : ITraumaSurgicalFrequency
    {
        public TraumaSurgicalFrequency(
            INullableValueFactory nullableValueFactory)
        {
            this.Category1Frequency = nullableValueFactory.Create<decimal>(
                0.07m);

            this.Category2Frequency = nullableValueFactory.Create<decimal>(
                0.22m);

            this.Category3Frequency = nullableValueFactory.Create<decimal>(
                0.32m);

            this.Category4Frequency = nullableValueFactory.Create<decimal>(
                0.20m);

            this.Category5Frequency = nullableValueFactory.Create<decimal>(
                0.19m);

            this.Category6Frequency = nullableValueFactory.Create<decimal>(
                0m);

            this.Category7Frequency = nullableValueFactory.Create<decimal>(
                0m);

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