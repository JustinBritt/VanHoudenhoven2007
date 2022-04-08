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

        [TestMethod]
        public void NeurosurgeryAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 192m;
            data[2] = 113m;
            data[3] = 171m;
            data[4] = 255m;
            data[5] = 324m;
            data[6] = 492m;
            data[7] = 0m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithNeurosurgery()
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
        public void NeurosurgeryStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 165m;
            data[2] = 41m;
            data[3] = 62m;
            data[4] = 62m;
            data[5] = 73m;
            data[6] = 177m;
            data[7] = 0m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithNeurosurgery()
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
        public void OphthalmologyAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 83m;
            data[2] = 46m;
            data[3] = 60m;
            data[4] = 95m;
            data[5] = 127m;
            data[6] = 0m;
            data[7] = 0m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithOphthalmology()
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
        public void OphthalmologyStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 46m;
            data[2] = 14m;
            data[3] = 22m;
            data[4] = 30m;
            data[5] = 34m;
            data[6] = 0m;
            data[7] = 0m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithOphthalmology()
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
        public void OrthopedicSurgeryAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 107m;
            data[2] = 61m;
            data[3] = 83m;
            data[4] = 109m;
            data[5] = 160m;
            data[6] = 199m;
            data[7] = 291m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithOrthopedicSurgery()
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
        public void OrthopedicSurgeryStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 58m;
            data[2] = 23m;
            data[3] = 30m;
            data[4] = 38m;
            data[5] = 43m;
            data[6] = 45m;
            data[7] = 102m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithOrthopedicSurgery()
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
        public void PlasticSurgeryAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 119m;
            data[2] = 63m;
            data[3] = 82m;
            data[4] = 112m;
            data[5] = 139m;
            data[6] = 187m;
            data[7] = 432m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithPlasticSurgery()
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
        public void PlasticSurgeryStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 107m;
            data[2] = 22m;
            data[3] = 28m;
            data[4] = 36m;
            data[5] = 39m;
            data[6] = 57m;
            data[7] = 181m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithPlasticSurgery()
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
        public void TraumaAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 100m;
            data[2] = 62m;
            data[3] = 81m;
            data[4] = 122m;
            data[5] = 176m;
            data[6] = 0m;
            data[7] = 0m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithTrauma()
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
        public void TraumaStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 68m;
            data[2] = 23m;
            data[3] = 30m;
            data[4] = 38m;
            data[5] = 92m;
            data[6] = 0m;
            data[7] = 0m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithTrauma()
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
        public void UrologyAverage()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 121m;
            data[2] = 59m;
            data[3] = 74m;
            data[4] = 102m;
            data[5] = 152m;
            data[6] = 230m;
            data[7] = 385m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithUrology()
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
        public void UrologyStdDev()
        {
            // Arrange
            ISurgicalDurationExportTestBuilder builder = new SurgicalDurationExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 68m;
            data[2] = 30m;
            data[3] = 26m;
            data[4] = 49m;
            data[5] = 49m;
            data[6] = 68m;
            data[7] = 123m;
            data[8] = 0m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithUrology()
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