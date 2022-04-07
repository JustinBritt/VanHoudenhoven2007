namespace VanHoudenhoven2007.Tests.Classes.Exports.SurgicalDurations
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VanHoudenhoven2007.AbstractFactories;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalDurations;

    public interface ISurgicalDurationExportTestBuilder
    {
        ISurgicalDurationInputContext SurgicalDurationInputContext { get; }

        ISurgicalDurationExport SurgicalDurationExport { get; }

        ISurgicalDurationOutputContext SurgicalDurationOutputContext { get; }

        void Build();

        void WithAverage();

        void WithCategory(
            int category);

        void WithEarNoseThroat();
    }

    public sealed class SurgicalDurationExportTestBuilder : ISurgicalDurationExportTestBuilder
    {
        public SurgicalDurationExportTestBuilder()
        {
            this.AbstractFactory = VanHoudenhoven2007.AbstractFactories.AbstractFactory.Create();

            this.DependenciesAbstractFactory = this.AbstractFactory.CreateDependenciesAbstractFactory();
        }

        public IAbstractFactory AbstractFactory { get; }

        public Hl7.Fhir.Model.INullableValue<int> Category { get; private set; }

        public IDependenciesAbstractFactory DependenciesAbstractFactory { get; }

        public Hl7.Fhir.Model.CodeableConcept Specialty { get; private set; }

        public Hl7.Fhir.Model.IValue<string> Statistic { get; private set; }

        public ISurgicalDurationInputContext SurgicalDurationInputContext { get; private set; }

        public ISurgicalDurationExport SurgicalDurationExport { get; private set; }

        public ISurgicalDurationOutputContext SurgicalDurationOutputContext { get; private set; }

        public void Build(
            Hl7.Fhir.Model.INullableValue<int> category,
            Hl7.Fhir.Model.CodeableConcept specialty,
            Hl7.Fhir.Model.IValue<string> statistic)
        {
            this.SurgicalDurationInputContext = this.AbstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                category: category,
                specialty: specialty,
                statistic: statistic);

            this.SurgicalDurationExport = this.AbstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            this.SurgicalDurationOutputContext = this.SurgicalDurationExport.GetSurgicalDuration(
                this.AbstractFactory,
                this.SurgicalDurationInputContext);
        }

        public void Build()
        {
            this.Build(
                category: this.Category,
                specialty: this.Specialty,
                statistic: this.Statistic);
        }

        public void WithAverage()
        {
            this.Statistic = this.DependenciesAbstractFactory.CreateValueFactory().CreateAverage();
        }

        public void WithCategory(
            int category)
        {
            this.Category = this.DependenciesAbstractFactory.CreateNullableValueFactory().Create<int>(category);
        }

        public void WithEarNoseThroat()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery();
        }
    }

    [TestClass]
    public sealed class SurgicalDurationExport
    {
        private const string minutes = "min";

        private const string skew = "skew";

        [TestMethod]
        public void Category1EarNoseThroatSurgeryAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder.WithCategory(
                category: 1);
            builder.WithEarNoseThroat();
            builder.WithAverage();
            builder.Build();

            // Assert
            Assert.AreEqual(
                expected: 102m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category2EarNoseThroatSurgeryAverage()
        {
            // Arrange
            SurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder.WithCategory(
                category: 2);
            builder.WithEarNoseThroat();
            builder.WithAverage();
            builder.Build();

            // Assert
            Assert.AreEqual(
                expected: 40m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category3EarNoseThroatSurgeryAverage()
        {
            // Arrange
            SurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder.WithCategory(
                category: 3);
            builder.WithEarNoseThroat();
            builder.WithAverage();
            builder.Build();

            // Assert
            Assert.AreEqual(
                expected: 65m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }
    }
}