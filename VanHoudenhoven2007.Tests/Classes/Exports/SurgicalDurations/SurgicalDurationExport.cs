namespace VanHoudenhoven2007.Tests.Classes.Exports.SurgicalDurations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

        ISurgicalDurationExportTestBuilder WithAverage();

        ISurgicalDurationExportTestBuilder WithCategory(
            int category);

        ISurgicalDurationExportTestBuilder WithEarNoseThroatSurgery();

        ISurgicalDurationExportTestBuilder WithGeneralSurgery();

        ISurgicalDurationExportTestBuilder WithGynecologicalSurgery();

        ISurgicalDurationExportTestBuilder WithNeurosurgery();

        ISurgicalDurationExportTestBuilder WithOphthalmology();

        ISurgicalDurationExportTestBuilder WithOralSurgery();

        ISurgicalDurationExportTestBuilder WithOrthopedicSurgery();

        ISurgicalDurationExportTestBuilder WithPlasticSurgery();

        ISurgicalDurationExportTestBuilder WithStdDev();

        ISurgicalDurationExportTestBuilder WithTrauma();

        ISurgicalDurationExportTestBuilder WithUrology();
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

        public ISurgicalDurationExportTestBuilder WithEarNoseThroatSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithGeneralSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGeneralSurgery();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithGynecologicalSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGynecologicalSurgery();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithNeurosurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateNeurosurgery();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithOphthalmology()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOphthalmology();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithOralSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOralSurgery();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithOrthopedicSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOrthopedicSurgery();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithPlasticSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreatePlasticSurgery();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithStdDev()
        {
            this.Statistic = this.DependenciesAbstractFactory.CreateValueFactory().CreateStdDev();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithTrauma()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateTrauma();

            return this;
        }

        public ISurgicalDurationExportTestBuilder WithUrology()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateUrology();

            return this;
        }
    }

    [TestClass]
    public sealed class SurgicalDurationExport
    {
        private const string minutes = "min";

        private const string skew = "skew";

        private static IEnumerable<object[]> EarNoseThroatSurgeryAverageData => 
            new [] 
            {
                new object[] { 1, 102m, minutes },
                new object[] { 2, 40m, minutes },
                new object[] { 3, 65m, minutes },
                new object[] { 4, 102m, minutes },
                new object[] { 5, 127m, minutes },
                new object[] { 6, 182m, minutes },
                new object[] { 7, 254m, minutes },
                new object[] { 8, 549m, minutes },
            };

        private static IEnumerable<object[]> EarNoseThroatSurgeryStdDevData =>
            new[]
            {
                new object[] { 1, 125m, minutes },
                new object[] { 2, 17m, minutes },
                new object[] { 3, 24m, minutes },
                new object[] { 4, 35m, minutes },
                new object[] { 5, 32m, minutes },
                new object[] { 6, 65m, minutes },
                new object[] { 7, 75m, minutes },
                new object[] { 8, 203m, minutes },
            };

        private static IEnumerable<object[]> GeneralSurgeryAverageData =>
            new[]
            {
                new object[] { 1, 150m, minutes },
                new object[] { 2, 67m, minutes },
                new object[] { 3, 100m, minutes },
                new object[] { 4, 135m, minutes },
                new object[] { 5, 171m, minutes },
                new object[] { 6, 213m, minutes },
                new object[] { 7, 262m, minutes },
                new object[] { 8, 351m, minutes },
            };

        private static IEnumerable<object[]> GeneralSurgeryStdDevData =>
            new[]
            {
                new object[] { 1, 89m, minutes },
                new object[] { 2, 31m, minutes },
                new object[] { 3, 44m, minutes },
                new object[] { 4, 52m, minutes },
                new object[] { 5, 63m, minutes },
                new object[] { 6, 89m, minutes },
                new object[] { 7, 87m, minutes },
                new object[] { 8, 124m, minutes },
            };

        private static IEnumerable<object[]> GynecologicalSurgeryAverageData =>
            new[]
            {
                new object[] { 1, 80m, minutes },
                new object[] { 2, 52m, minutes },
                new object[] { 3, 73m, minutes },
                new object[] { 4, 98m, minutes },
                new object[] { 5, 125m, minutes },
                new object[] { 6, 156m, minutes },
                new object[] { 7, 213m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> GynecologicalSurgeryStdDevData =>
            new[]
            {
                new object[] { 1, 65m, minutes },
                new object[] { 2, 19m, minutes },
                new object[] { 3, 33m, minutes },
                new object[] { 4, 32m, minutes },
                new object[] { 5, 43m, minutes },
                new object[] { 6, 41m, minutes },
                new object[] { 7, 82m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> NeurosurgeryAverageData =>
            new[]
            {
                new object[] { 1, 192m, minutes },
                new object[] { 2, 113m, minutes },
                new object[] { 3, 171m, minutes },
                new object[] { 4, 255m, minutes },
                new object[] { 5, 324m, minutes },
                new object[] { 6, 492m, minutes },
                new object[] { 7, 0m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> NeurosurgeryStdDevData =>
            new[]
            {
                new object[] { 1, 165m, minutes },
                new object[] { 2, 41m, minutes },
                new object[] { 3, 62m, minutes },
                new object[] { 4, 62m, minutes },
                new object[] { 5, 73m, minutes },
                new object[] { 6, 177m, minutes },
                new object[] { 7, 0m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> OphthalmologyAverageData =>
            new[]
            {
                new object[] { 1, 83m, minutes },
                new object[] { 2, 46m, minutes },
                new object[] { 3, 60m, minutes },
                new object[] { 4, 95m, minutes },
                new object[] { 5, 127m, minutes },
                new object[] { 6, 0m, minutes },
                new object[] { 7, 0m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> OphthalmologyStdDevData => 
            new [] 
            {
                new object[] { 1, 46m, minutes },
                new object[] { 2, 14m, minutes },
                new object[] { 3, 22m, minutes },
                new object[] { 4, 30m, minutes },
                new object[] { 5, 34m, minutes },
                new object[] { 6, 0m, minutes },
                new object[] { 7, 0m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> OrthopedicSurgeryAverageData =>
            new[]
            {
                new object[] { 1, 107m, minutes },
                new object[] { 2, 61m, minutes },
                new object[] { 3, 83m, minutes },
                new object[] { 4, 109m, minutes },
                new object[] { 5, 160m, minutes },
                new object[] { 6, 199m, minutes },
                new object[] { 7, 291m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> OrthopedicSurgeryStdDevData =>
            new[]
            {
                new object[] { 1, 58m, minutes },
                new object[] { 2, 23m, minutes },
                new object[] { 3, 30m, minutes },
                new object[] { 4, 38m, minutes },
                new object[] { 5, 43m, minutes },
                new object[] { 6, 45m, minutes },
                new object[] { 7, 102m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> PlasticSurgeryAverageData =>
            new[]
            {
                new object[] { 1, 119m, minutes },
                new object[] { 2, 63m, minutes },
                new object[] { 3, 82m, minutes },
                new object[] { 4, 112m, minutes },
                new object[] { 5, 139m, minutes },
                new object[] { 6, 187m, minutes },
                new object[] { 7, 432m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> PlasticSurgeryStdDevData =>
            new[]
            {
                new object[] { 1, 107m, minutes },
                new object[] { 2, 22m, minutes },
                new object[] { 3, 28m, minutes },
                new object[] { 4, 36m, minutes },
                new object[] { 5, 39m, minutes },
                new object[] { 6, 57m, minutes },
                new object[] { 7, 181m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> TraumaAverageData =>
            new[]
            {
                new object[] { 1, 100m, minutes },
                new object[] { 2, 62m, minutes },
                new object[] { 3, 81m, minutes },
                new object[] { 4, 122m, minutes },
                new object[] { 5, 176m, minutes },
                new object[] { 6, 0m, minutes },
                new object[] { 7, 0m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> TraumaStdDevData =>
            new[]
            {
                new object[] { 1, 68m, minutes },
                new object[] { 2, 23m, minutes },
                new object[] { 3, 30m, minutes },
                new object[] { 4, 38m, minutes },
                new object[] { 5, 92m, minutes },
                new object[] { 6, 0m, minutes },
                new object[] { 7, 0m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> UrologyAverageData =>
            new[]
            {
                new object[] { 1, 121m, minutes },
                new object[] { 2, 59m, minutes },
                new object[] { 3, 74m, minutes },
                new object[] { 4, 102m, minutes },
                new object[] { 5, 152m, minutes },
                new object[] { 6, 230m, minutes },
                new object[] { 7, 385m, minutes },
                new object[] { 8, 0m, minutes },
            };

        private static IEnumerable<object[]> UrologyStdDevData =>
            new[]
            {
                new object[] { 1, 68m, minutes },
                new object[] { 2, 30m, minutes },
                new object[] { 3, 26m, minutes },
                new object[] { 4, 49m, minutes },
                new object[] { 5, 49m, minutes },
                new object[] { 6, 68m, minutes },
                new object[] { 7, 123m, minutes },
                new object[] { 8, 0m, minutes },
            };

        [TestMethod]
        [DynamicData(nameof(EarNoseThroatSurgeryAverageData))]
        public void EarNoseThroatSurgeryAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithEarNoseThroatSurgery()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(EarNoseThroatSurgeryStdDevData))]
        public void EarNoseThroatSurgeryStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithEarNoseThroatSurgery()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(GeneralSurgeryAverageData))]
        public void GeneralSurgeryAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithGeneralSurgery()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(GeneralSurgeryStdDevData))]
        public void GeneralSurgeryStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithGeneralSurgery()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(GynecologicalSurgeryAverageData))]
        public void GynecologicalSurgeryAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithGynecologicalSurgery()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(GynecologicalSurgeryStdDevData))]
        public void GynecologicalSurgeryStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithGynecologicalSurgery()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(NeurosurgeryAverageData))]
        public void NeurosurgeryAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithNeurosurgery()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(NeurosurgeryStdDevData))]
        public void NeurosurgeryStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithNeurosurgery()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(OphthalmologyAverageData))]
        public void OphthalmologyAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithOphthalmology()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(OphthalmologyStdDevData))]
        public void OphthalmologyStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithOphthalmology()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(OrthopedicSurgeryAverageData))]
        public void OrthopedicSurgeryAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithOrthopedicSurgery()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(OrthopedicSurgeryStdDevData))]
        public void OrthopedicSurgeryStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithOrthopedicSurgery()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(PlasticSurgeryAverageData))]
        public void PlasticSurgeryAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithPlasticSurgery()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(PlasticSurgeryStdDevData))]
        public void PlasticSurgeryStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithPlasticSurgery()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(TraumaAverageData))]
        public void TraumaAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithTrauma()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(TraumaStdDevData))]
        public void TraumaStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithTrauma()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(UrologyAverageData))]
        public void UrologyAverage(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithUrology()
                .WithAverage()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        [DynamicData(nameof(UrologyStdDevData))]
        public void UrologyStdDev(
            int category,
            decimal value,
            string unit)
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            // Act
            builder
                .WithCategory(
                    category: category)
                .WithUrology()
                .WithStdDev()
                .Build();

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
        }
    }
}