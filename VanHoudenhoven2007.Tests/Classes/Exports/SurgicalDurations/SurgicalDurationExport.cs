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

        ISurgicalDurationExportTestBuilder Build();

        ISurgicalDurationExportTestBuilder WithAverage();

        ISurgicalDurationExportTestBuilder WithCategory(
            int category);

        ISurgicalDurationExportTestBuilder WithEarNoseThroat();
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

        public ISurgicalDurationExportTestBuilder Build()
        {
            this.Build(
                category: this.Category,
                specialty: this.Specialty,
                statistic: this.Statistic);

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithAverage()
        {
            this.Statistic = this.DependenciesAbstractFactory.CreateValueFactory().CreateAverage();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithCategory(
            int category)
        {
            this.Category = this.DependenciesAbstractFactory.CreateNullableValueFactory().Create<int>(category);

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithEarNoseThroat()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery();

            return this;
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
            builder
                 .WithCategory(
                     category: 1)
                 .WithEarNoseThroat()
                 .WithAverage()
                 .Build();

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
            builder
                .WithCategory(
                    category: 2)
                .WithEarNoseThroat()
                .WithAverage()
                .Build();
            
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
            builder
                .WithCategory(
                    category: 3)
                .WithEarNoseThroat()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: 65m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category4EarNoseThroatSurgeryAverage()
        {
            // Arrange
            SurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: 4)
                .WithEarNoseThroat()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: 102m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category5EarNoseThroatSurgeryAverage()
        {
            // Arrange
            SurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: 5)
                .WithEarNoseThroat()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: 127m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category6EarNoseThroatSurgeryAverage()
        {
            // Arrange
            SurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: 6)
                .WithEarNoseThroat()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: 182m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category7EarNoseThroatSurgeryAverage()
        {
            // Arrange
            SurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: 7)
                .WithEarNoseThroat()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: 254m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category8EarNoseThroatSurgeryAverage()
        {
            // Arrange
            SurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: 8)
                .WithEarNoseThroat()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: 549m,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }
    }
}