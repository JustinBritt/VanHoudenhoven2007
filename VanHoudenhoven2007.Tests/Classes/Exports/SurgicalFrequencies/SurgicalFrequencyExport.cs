namespace VanHoudenhoven2007.Tests.Classes.Exports.SurgicalFrequencies
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VanHoudenhoven2007.AbstractFactories;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalFrequencies;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalFrequencies;

    [TestClass]
    public sealed class SurgicalFrequencyExport
    {
        // Codes
        private const string EarNoseThroatSurgery = "394604002";
        private const string GeneralSurgery = "394609007";
        private const string GynecologicalSurgery = "394586005";
        private const string Neurosurgery = "394610002";
        private const string OphthalmicSurgery = "422191005";
        private const string Ophthalmology = "394594003";
        private const string OralSurgery = "394605001";
        private const string OrthopedicSurgery = "24241000087106";
        private const string PlasticSurgery = "394611003";
        private const string Trauma = "394801008";
        private const string Urology = "394612005";

        private const string SNOMEDCT = "http://snomed.info/sct";

        private static IEnumerable<object[]> Table2Data =>
            new[]
            {
                new object[] { EarNoseThroatSurgery, 1, 0.04m },
                new object[] { EarNoseThroatSurgery, 2, 0.33m },
                new object[] { EarNoseThroatSurgery, 3, 0.19m },
                new object[] { EarNoseThroatSurgery, 4, 0.12m },
                new object[] { EarNoseThroatSurgery, 5, 0.14m },
                new object[] { EarNoseThroatSurgery, 6, 0.08m },
                new object[] { EarNoseThroatSurgery, 7, 0.05m },
                new object[] { EarNoseThroatSurgery, 8, 0.06m },

                new object[] { GeneralSurgery, 1, 0.08m },
                new object[] { GeneralSurgery, 2, 0.03m },
                new object[] { GeneralSurgery, 3, 0.12m },
                new object[] { GeneralSurgery, 4, 0.19m },
                new object[] { GeneralSurgery, 5, 0.20m },
                new object[] { GeneralSurgery, 6, 0.03m },
                new object[] { GeneralSurgery, 7, 0.25m },
                new object[] { GeneralSurgery, 8, 0.09m },

                new object[] { GynecologicalSurgery, 1, 0.02m },
                new object[] { GynecologicalSurgery, 2, 0.14m },
                new object[] { GynecologicalSurgery, 3, 0.19m },
                new object[] { GynecologicalSurgery, 4, 0.25m },
                new object[] { GynecologicalSurgery, 5, 0.32m },
                new object[] { GynecologicalSurgery, 6, 0.02m },
                new object[] { GynecologicalSurgery, 7, 0.06m },
                new object[] { GynecologicalSurgery, 8, 0.00m },

                new object[] { Neurosurgery, 1, 0.08m },
                new object[] { Neurosurgery, 2, 0.17m },
                new object[] { Neurosurgery, 3, 0.14m },
                new object[] { Neurosurgery, 4, 0.28m },
                new object[] { Neurosurgery, 5, 0.12m },
                new object[] { Neurosurgery, 6, 0.21m },
                new object[] { Neurosurgery, 7, 0m },
                new object[] { Neurosurgery, 8, 0m },

                new object[] { Ophthalmology, 1, 0.01m },
                new object[] { Ophthalmology, 2, 0.35m },
                new object[] { Ophthalmology, 3, 0.42m },
                new object[] { Ophthalmology, 4, 0.17m },
                new object[] { Ophthalmology, 5, 0.05m },
                new object[] { Ophthalmology, 6, 0m },
                new object[] { Ophthalmology, 7, 0m },
                new object[] { Ophthalmology, 8, 0m },

                new object[] { OralSurgery, 1, 0.01m },
                new object[] { OralSurgery, 2, 0.44m },
                new object[] { OralSurgery, 3, 0.44m },
                new object[] { OralSurgery, 4, 0.11m },
                new object[] { OralSurgery, 5, 0m },
                new object[] { OralSurgery, 6, 0m },
                new object[] { OralSurgery, 7, 0m },
                new object[] { OralSurgery, 8, 0m },

                new object[] { OrthopedicSurgery, 1, 0.09m },
                new object[] { OrthopedicSurgery, 2, 0.10m },
                new object[] { OrthopedicSurgery, 3, 0.18m },
                new object[] { OrthopedicSurgery, 4, 0.21m },
                new object[] { OrthopedicSurgery, 5, 0.21m },
                new object[] { OrthopedicSurgery, 6, 0.16m },
                new object[] { OrthopedicSurgery, 7, 0.05m },
                new object[] { OrthopedicSurgery, 8, 0m },

                new object[] { PlasticSurgery, 1, 0.05m },
                new object[] { PlasticSurgery, 2, 0.14m },
                new object[] { PlasticSurgery, 3, 0.17m },
                new object[] { PlasticSurgery, 4, 0.21m },
                new object[] { PlasticSurgery, 5, 0.22m },
                new object[] { PlasticSurgery, 6, 0.11m },
                new object[] { PlasticSurgery, 7, 0.10m },
                new object[] { PlasticSurgery, 8, 0m },

                new object[] { Trauma, 1, 0.07m },
                new object[] { Trauma, 2, 0.22m },
                new object[] { Trauma, 3, 0.32m },
                new object[] { Trauma, 4, 0.20m },
                new object[] { Trauma, 5, 0.19m },
                new object[] { Trauma, 6, 0m },
                new object[] { Trauma, 7, 0m },
                new object[] { Trauma, 8, 0m },

                new object[] { Urology, 1, 0.03m },
                new object[] { Urology, 2, 0.05m },
                new object[] { Urology, 3, 0.30m },
                new object[] { Urology, 4, 0.15m },
                new object[] { Urology, 5, 0.17m },
                new object[] { Urology, 6, 0.21m },
                new object[] { Urology, 7, 0.08m },
                new object[] { Urology, 8, 0m },
            };

        [TestMethod]
        [DynamicData(nameof(Table2Data))]
        public void Table2(
            string specialty,
            int category,
            decimal value)
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IContextsAbstractFactory contextsAbstractFactory = abstractFactory.CreateContextsAbstractFactory();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IExportsAbstractFactory exportsAbstractFactory = abstractFactory.CreateExportsAbstractFactory();

            ISurgicalFrequencyInputContext surgicalFrequencyInputContext = contextsAbstractFactory.CreateSurgicalFrequencyInputContextFactory().Create(
                category: dependenciesAbstractFactory.CreateNullableValueFactory().Create<int>(category),
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().Create(specialty, SNOMEDCT, null));

            ISurgicalFrequencyExport surgicalFrequencyExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalFrequencyExportFactory().Create();

            // Act
            ISurgicalFrequencyOutputContext surgicalFrequencyOutputContext = surgicalFrequencyExport.GetSurgicalFrequency(
                abstractFactory,
                surgicalFrequencyInputContext);

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: surgicalFrequencyOutputContext.Frequency.Value.Value);
        }
    }
}