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

        ISurgicalDurationExportTestBuilder WithAverage();

        ISurgicalDurationExportTestBuilder WithCategory(
            int category);

        ISurgicalDurationExportTestBuilder WithEarNoseThroatSurgery();

        ISurgicalDurationExportTestBuilder WithGeneralSurgery();

        ISurgicalDurationExportTestBuilder WithGynecologicalSurgery();

        ISurgicalDurationExportTestBuilder WithNeurosurgery()

        ISurgicalDurationExportTestBuilder WithStdDev();
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

        public ISurgicalDurationExportTestBuilder WithStdDev()
        {
            this.Statistic = this.DependenciesAbstractFactory.CreateValueFactory().CreateStdDev();

            return this;
        }
    }

    [TestClass]
    public sealed class SurgicalDurationExport
    {
        private const string minutes = "min";

        private const string skew = "skew";

        [TestMethod]
        public void EarNoseThroatSurgeryAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 102m;
            data[2] = 40m;
            data[3] = 65m;
            data[4] = 102m;
            data[5] = 127m;
            data[6] = 182m;
            data[7] = 254m;
            data[8] = 549m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithEarNoseThroatSurgery()
                     .WithAverage()
                     .Build();

                // Assert
                Assert.AreEqual(
                    expected: data[i],
                    actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

                Assert.AreEqual(
                    expected: minutes,
                    actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
            }
        }

        [TestMethod]
        public void EarNoseThroatSurgeryStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 125m;
            data[2] = 17m;
            data[3] = 24m;
            data[4] = 35m;
            data[5] = 32m;
            data[6] = 65m;
            data[7] = 75m;
            data[8] = 203m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithEarNoseThroatSurgery()
                     .WithStdDev()
                     .Build();

                // Assert
                Assert.AreEqual(
                    expected: data[i],
                    actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

                Assert.AreEqual(
                    expected: minutes,
                    actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
            }
        }

        [TestMethod]
        public void GeneralSurgeryAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 150m;
            data[2] = 67m;
            data[3] = 100m;
            data[4] = 135m;
            data[5] = 171m;
            data[6] = 213m;
            data[7] = 262m;
            data[8] = 351m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithGeneralSurgery()
                     .WithAverage()
                     .Build();

                // Assert
                Assert.AreEqual(
                    expected: data[i],
                    actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

                Assert.AreEqual(
                    expected: minutes,
                    actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
            }
        }

        [TestMethod]
        public void GeneralSurgeryStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 89m;
            data[2] = 31m;
            data[3] = 44m;
            data[4] = 52m;
            data[5] = 63m;
            data[6] = 89m;
            data[7] = 87m;
            data[8] = 124m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithGeneralSurgery()
                     .WithStdDev()
                     .Build();

                // Assert
                Assert.AreEqual(
                    expected: data[i],
                    actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

                Assert.AreEqual(
                    expected: minutes,
                    actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
            }
        }

        [TestMethod]
        public void GynecologicalSurgeryAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 80m;
            data[2] = 52m;
            data[3] = 73m;
            data[4] = 98m;
            data[5] = 125m;
            data[6] = 156m;
            data[7] = 213m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithGynecologicalSurgery()
                     .WithAverage()
                     .Build();

                // Assert
                Assert.AreEqual(
                    expected: data[i],
                    actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

                Assert.AreEqual(
                    expected: minutes,
                    actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
            }
        }

        [TestMethod]
        public void GynecologicalSurgeryStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 65m;
            data[2] = 19m;
            data[3] = 33m;
            data[4] = 32m;
            data[5] = 43m;
            data[6] = 41m;
            data[7] = 82m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithGynecologicalSurgery()
                     .WithStdDev()
                     .Build();

                // Assert
                Assert.AreEqual(
                    expected: data[i],
                    actual: builder.SurgicalDurationOutputContext.Duration.Value.Value);

                Assert.AreEqual(
                    expected: minutes,
                    actual: builder.SurgicalDurationOutputContext.Duration.UnitElement.Value);
            }
        }
    }
}