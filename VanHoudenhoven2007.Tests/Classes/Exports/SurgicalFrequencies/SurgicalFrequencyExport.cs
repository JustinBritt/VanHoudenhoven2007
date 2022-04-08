namespace VanHoudenhoven2007.Tests.Classes.Exports.SurgicalFrequencies
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VanHoudenhoven2007.AbstractFactories;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalFrequencies;

    public interface ISurgicalFrequencyExportTestBuilder
    {
        ISurgicalFrequencyInputContext SurgicalFrequencyInputContext { get; }

        ISurgicalFrequencyExport SurgicalFrequencyExport { get; }

        ISurgicalFrequencyOutputContext SurgicalFrequencyOutputContext { get; }

        void Build();

        ISurgicalFrequencyExportTestBuilder WithCategory(
            int category);

        ISurgicalFrequencyExportTestBuilder WithEarNoseThroatSurgery();

        ISurgicalFrequencyExportTestBuilder WithGeneralSurgery();

        ISurgicalFrequencyExportTestBuilder WithGynecologicalSurgery();

        ISurgicalFrequencyExportTestBuilder WithNeurosurgery();

        ISurgicalFrequencyExportTestBuilder WithOphthalmology();

        ISurgicalFrequencyExportTestBuilder WithOrthopedicSurgery();

        ISurgicalFrequencyExportTestBuilder WithPlasticSurgery();

        ISurgicalFrequencyExportTestBuilder WithTrauma();

        ISurgicalFrequencyExportTestBuilder WithUrology();
    }

    public sealed class SurgicalFrequencyExportTestBuilder : ISurgicalFrequencyExportTestBuilder
    {
        public SurgicalFrequencyExportTestBuilder()
        {
            this.AbstractFactory = VanHoudenhoven2007.AbstractFactories.AbstractFactory.Create();

            this.DependenciesAbstractFactory = this.AbstractFactory.CreateDependenciesAbstractFactory();
        }

        public IAbstractFactory AbstractFactory { get; }

        public Hl7.Fhir.Model.INullableValue<int> Category { get; private set; }

        public IDependenciesAbstractFactory DependenciesAbstractFactory { get; }

        public Hl7.Fhir.Model.CodeableConcept Specialty { get; private set; }

        public ISurgicalFrequencyInputContext SurgicalFrequencyInputContext { get; private set; }

        public ISurgicalFrequencyExport SurgicalFrequencyExport { get; private set; }

        public ISurgicalFrequencyOutputContext SurgicalFrequencyOutputContext { get; private set; }

        public void Build(
            Hl7.Fhir.Model.INullableValue<int> category,
            Hl7.Fhir.Model.CodeableConcept specialty)
        {
            this.SurgicalFrequencyInputContext = this.AbstractFactory.CreateContextsAbstractFactory().CreateSurgicalFrequencyInputContextFactory().Create(
                category: category,
                specialty: specialty);

            this.SurgicalFrequencyExport = this.AbstractFactory.CreateExportsAbstractFactory().CreateSurgicalFrequencyExportFactory().Create();

            this.SurgicalFrequencyOutputContext = this.SurgicalFrequencyExport.GetSurgicalFrequency(
                this.AbstractFactory,
                this.SurgicalFrequencyInputContext);
        }

        public void Build()
        {
            this.Build(
                category: this.Category,
                specialty: this.Specialty);
        }

        public ISurgicalFrequencyExportTestBuilder WithCategory(
            int category)
        {
            this.Category = this.DependenciesAbstractFactory.CreateNullableValueFactory().Create<int>(category);

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithEarNoseThroatSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery();

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithGeneralSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGeneralSurgery();

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithGynecologicalSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGynecologicalSurgery();

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithNeurosurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateNeurosurgery();

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithOphthalmology()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOphthalmology();

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithOrthopedicSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOrthopedicSurgery();

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithPlasticSurgery()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreatePlasticSurgery();

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithTrauma()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateTrauma();

            return this;
        }

        public ISurgicalFrequencyExportTestBuilder WithUrology()
        {
            this.Specialty = this.DependenciesAbstractFactory.CreateCodeableConceptFactory().CreateUrology();

            return this;
        }
    }

    [TestClass]
    public sealed class SurgicalFrequencyExport
    {
        private const string minutes = "min";

        [TestMethod]
        public void EarNoseThroatSurgery()
        {
            // Arrange
            ISurgicalFrequencyExportTestBuilder builder = new SurgicalFrequencyExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 0.04m;
            data[2] = 0.33m;
            data[3] = 0.19m;
            data[4] = 0.12m;
            data[5] = 0.14m;
            data[6] = 0.08m;
            data[7] = 0.05m;
            data[8] = 0.06m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithEarNoseThroatSurgery()
                     .Build();

                // Assert
                Assert.AreEqual(
                    expected: data[i],
                    actual: builder.SurgicalFrequencyOutputContext.Frequency.Value.Value);
            }
        }

        [TestMethod]
        public void GeneralSurgery()
        {
            // Arrange
            ISurgicalFrequencyExportTestBuilder builder = new SurgicalFrequencyExportTestBuilder();

            int numberCategories = 8;

            Span<decimal> data = (Span<decimal>)Array.CreateInstance(typeof(decimal), numberCategories + 1);
            data[1] = 0.08m;
            data[2] = 0.03m;
            data[3] = 0.12m;
            data[4] = 0.19m;
            data[5] = 0.20m;
            data[6] = 0.03m;
            data[7] = 0.25m;
            data[8] = 0.09m;

            for (int i = 1; i <= numberCategories; i = i + 1)
            {
                // Act
                builder
                     .WithCategory(
                         category: i)
                     .WithGeneralSurgery()
                     .Build();

                // Assert
                Assert.AreEqual(
                    expected: data[i],
                    actual: builder.SurgicalFrequencyOutputContext.Frequency.Value.Value);
            }
        }
    }
}