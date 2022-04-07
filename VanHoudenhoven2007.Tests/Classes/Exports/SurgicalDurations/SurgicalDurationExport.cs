namespace VanHoudenhoven2007.Tests.Classes.Exports.SurgicalDurations
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VanHoudenhoven2007.AbstractFactories;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalDurations;

    [TestClass]
    public sealed class SurgicalDurationExport
    {
        private const string minutes = "min";

        private const string skew = "skew";

        [TestMethod]
        public void Category1EarNoseThroatSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                category: dependenciesAbstractFactory.CreateNullableValueFactory().Create<int>(1),
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 102m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category2EarNoseThroatSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                category: dependenciesAbstractFactory.CreateNullableValueFactory().Create<int>(2),
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 40m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void Category3EarNoseThroatSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                category: dependenciesAbstractFactory.CreateNullableValueFactory().Create<int>(3),
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 65m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }
    }
}