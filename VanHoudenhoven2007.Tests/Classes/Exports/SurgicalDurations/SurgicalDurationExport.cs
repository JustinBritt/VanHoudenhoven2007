namespace VanHoudenhoven2007.Tests.Classes.Exports.SurgicalDurations
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VanHoudenhoven2007.AbstractFactories;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.Interfaces.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.Interfaces.Exports.SurgicalDurations;

    [TestClass]
    public sealed class SurgicalDurationExport
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

        private const string average = "average";
        private const string stddev = "std-dev";
        private const string minutes = "min";

        private const string skew = "skew";

        private static IEnumerable<object[]> Table2Data =>
            new[]
            {
                new object[] { EarNoseThroatSurgery, 1, 102m, minutes, average },
                new object[] { EarNoseThroatSurgery, 2, 40m, minutes, average },
                new object[] { EarNoseThroatSurgery, 3, 65m, minutes, average },
                new object[] { EarNoseThroatSurgery, 4, 102m, minutes, average },
                new object[] { EarNoseThroatSurgery, 5, 127m, minutes, average },
                new object[] { EarNoseThroatSurgery, 6, 182m, minutes, average },
                new object[] { EarNoseThroatSurgery, 7, 254m, minutes, average },
                new object[] { EarNoseThroatSurgery, 8, 549m, minutes, average },

                new object[] { EarNoseThroatSurgery, 1, 125m, minutes, stddev },
                new object[] { EarNoseThroatSurgery, 2, 17m, minutes, stddev },
                new object[] { EarNoseThroatSurgery, 3, 24m, minutes, stddev },
                new object[] { EarNoseThroatSurgery, 4, 35m, minutes, stddev },
                new object[] { EarNoseThroatSurgery, 5, 32m, minutes, stddev },
                new object[] { EarNoseThroatSurgery, 6, 65m, minutes, stddev },
                new object[] { EarNoseThroatSurgery, 7, 75m, minutes, stddev },
                new object[] { EarNoseThroatSurgery, 8, 203m, minutes, stddev },

                new object[] { GeneralSurgery, 1, 150m, minutes, average },
                new object[] { GeneralSurgery, 2, 67m, minutes, average },
                new object[] { GeneralSurgery, 3, 100m, minutes, average },
                new object[] { GeneralSurgery, 4, 135m, minutes, average },
                new object[] { GeneralSurgery, 5, 171m, minutes, average },
                new object[] { GeneralSurgery, 6, 213m, minutes, average },
                new object[] { GeneralSurgery, 7, 262m, minutes, average },
                new object[] { GeneralSurgery, 8, 351m, minutes, average },

                new object[] { GeneralSurgery, 1, 89m, minutes, stddev },
                new object[] { GeneralSurgery, 2, 31m, minutes, stddev },
                new object[] { GeneralSurgery, 3, 44m, minutes, stddev },
                new object[] { GeneralSurgery, 4, 52m, minutes, stddev },
                new object[] { GeneralSurgery, 5, 63m, minutes, stddev },
                new object[] { GeneralSurgery, 6, 89m, minutes, stddev },
                new object[] { GeneralSurgery, 7, 87m, minutes, stddev },
                new object[] { GeneralSurgery, 8, 124m, minutes, stddev },

                new object[] { GynecologicalSurgery, 1, 80m, minutes, average },
                new object[] { GynecologicalSurgery, 2, 52m, minutes, average },
                new object[] { GynecologicalSurgery, 3, 73m, minutes, average },
                new object[] { GynecologicalSurgery, 4, 98m, minutes, average },
                new object[] { GynecologicalSurgery, 5, 125m, minutes, average },
                new object[] { GynecologicalSurgery, 6, 156m, minutes, average },
                new object[] { GynecologicalSurgery, 7, 213m, minutes, average },
                new object[] { GynecologicalSurgery, 8, 0m, minutes, average },

                new object[] { GynecologicalSurgery, 1, 65m, minutes, stddev },
                new object[] { GynecologicalSurgery, 2, 19m, minutes, stddev },
                new object[] { GynecologicalSurgery, 3, 33m, minutes, stddev },
                new object[] { GynecologicalSurgery, 4, 32m, minutes, stddev },
                new object[] { GynecologicalSurgery, 5, 43m, minutes, stddev },
                new object[] { GynecologicalSurgery, 6, 41m, minutes, stddev },
                new object[] { GynecologicalSurgery, 7, 82m, minutes, stddev },
                new object[] { GynecologicalSurgery, 8, 0m, minutes, stddev },

                new object[] { Neurosurgery, 1, 192m, minutes, average },
                new object[] { Neurosurgery, 2, 113m, minutes, average },
                new object[] { Neurosurgery, 3, 171m, minutes, average },
                new object[] { Neurosurgery, 4, 255m, minutes, average },
                new object[] { Neurosurgery, 5, 324m, minutes, average },
                new object[] { Neurosurgery, 6, 492m, minutes, average },
                new object[] { Neurosurgery, 7, 0m, minutes, average },
                new object[] { Neurosurgery, 8, 0m, minutes, average },

                new object[] { Neurosurgery, 1, 165m, minutes, stddev },
                new object[] { Neurosurgery, 2, 41m, minutes, stddev },
                new object[] { Neurosurgery, 3, 62m, minutes, stddev },
                new object[] { Neurosurgery, 4, 62m, minutes, stddev },
                new object[] { Neurosurgery, 5, 73m, minutes, stddev },
                new object[] { Neurosurgery, 6, 177m, minutes, stddev },
                new object[] { Neurosurgery, 7, 0m, minutes, stddev },
                new object[] { Neurosurgery, 8, 0m, minutes, stddev },

                new object[] { Ophthalmology, 1, 83m, minutes, average },
                new object[] { Ophthalmology, 2, 46m, minutes, average },
                new object[] { Ophthalmology, 3, 60m, minutes, average },
                new object[] { Ophthalmology, 4, 95m, minutes, average },
                new object[] { Ophthalmology, 5, 127m, minutes, average },
                new object[] { Ophthalmology, 6, 0m, minutes, average },
                new object[] { Ophthalmology, 7, 0m, minutes, average },
                new object[] { Ophthalmology, 8, 0m, minutes, average },

                new object[] { Ophthalmology, 1, 46m, minutes, stddev },
                new object[] { Ophthalmology, 2, 14m, minutes, stddev },
                new object[] { Ophthalmology, 3, 22m, minutes, stddev },
                new object[] { Ophthalmology, 4, 30m, minutes, stddev },
                new object[] { Ophthalmology, 5, 34m, minutes, stddev },
                new object[] { Ophthalmology, 6, 0m, minutes, stddev },
                new object[] { Ophthalmology, 7, 0m, minutes, stddev },
                new object[] { Ophthalmology, 8, 0m, minutes, stddev },

                new object[] { OralSurgery, 1, 97m, minutes, average },
                new object[] { OralSurgery, 2, 87m, minutes, average },
                new object[] { OralSurgery, 3, 130m, minutes, average },
                new object[] { OralSurgery, 4, 238m, minutes, average },
                new object[] { OralSurgery, 5, 0m, minutes, average },
                new object[] { OralSurgery, 6, 0m, minutes, average },
                new object[] { OralSurgery, 7, 0m, minutes, average },
                new object[] { OralSurgery, 8, 0m, minutes, average },

                new object[] { OralSurgery, 1, 37m, minutes, stddev },
                new object[] { OralSurgery, 2, 29m, minutes, stddev },
                new object[] { OralSurgery, 3, 43m, minutes, stddev },
                new object[] { OralSurgery, 4, 87m, minutes, stddev },
                new object[] { OralSurgery, 5, 0m, minutes, stddev },
                new object[] { OralSurgery, 6, 0m, minutes, stddev },
                new object[] { OralSurgery, 7, 0m, minutes, stddev },
                new object[] { OralSurgery, 8, 0m, minutes, stddev },

                new object[] { OrthopedicSurgery, 1, 107m, minutes, average },
                new object[] { OrthopedicSurgery, 2, 61m, minutes, average },
                new object[] { OrthopedicSurgery, 3, 83m, minutes, average },
                new object[] { OrthopedicSurgery, 4, 109m, minutes, average },
                new object[] { OrthopedicSurgery, 5, 160m, minutes, average },
                new object[] { OrthopedicSurgery, 6, 199m, minutes, average },
                new object[] { OrthopedicSurgery, 7, 291m, minutes, average },
                new object[] { OrthopedicSurgery, 8, 0m, minutes, average },

                new object[] { OrthopedicSurgery, 1, 58m, minutes, stddev },
                new object[] { OrthopedicSurgery, 2, 23m, minutes, stddev },
                new object[] { OrthopedicSurgery, 3, 30m, minutes, stddev },
                new object[] { OrthopedicSurgery, 4, 38m, minutes, stddev },
                new object[] { OrthopedicSurgery, 5, 43m, minutes, stddev },
                new object[] { OrthopedicSurgery, 6, 45m, minutes, stddev },
                new object[] { OrthopedicSurgery, 7, 102m, minutes, stddev },
                new object[] { OrthopedicSurgery, 8, 0m, minutes, stddev },

                new object[] { PlasticSurgery, 1, 119m, minutes, average },
                new object[] { PlasticSurgery, 2, 63m, minutes, average },
                new object[] { PlasticSurgery, 3, 82m, minutes, average },
                new object[] { PlasticSurgery, 4, 112m, minutes, average },
                new object[] { PlasticSurgery, 5, 139m, minutes, average },
                new object[] { PlasticSurgery, 6, 187m, minutes, average },
                new object[] { PlasticSurgery, 7, 432m, minutes, average },
                new object[] { PlasticSurgery, 8, 0m, minutes, average },

                new object[] { PlasticSurgery, 1, 107m, minutes, stddev },
                new object[] { PlasticSurgery, 2, 22m, minutes, stddev },
                new object[] { PlasticSurgery, 3, 28m, minutes, stddev },
                new object[] { PlasticSurgery, 4, 36m, minutes, stddev },
                new object[] { PlasticSurgery, 5, 39m, minutes, stddev },
                new object[] { PlasticSurgery, 6, 57m, minutes, stddev },
                new object[] { PlasticSurgery, 7, 181m, minutes, stddev },
                new object[] { PlasticSurgery, 8, 0m, minutes, stddev },

                new object[] { Trauma, 1, 100m, minutes, average },
                new object[] { Trauma, 2, 62m, minutes, average },
                new object[] { Trauma, 3, 81m, minutes, average },
                new object[] { Trauma, 4, 122m, minutes, average },
                new object[] { Trauma, 5, 176m, minutes, average },
                new object[] { Trauma, 6, 0m, minutes, average },
                new object[] { Trauma, 7, 0m, minutes, average },
                new object[] { Trauma, 8, 0m, minutes, average },

                new object[] { Trauma, 1, 68m, minutes, stddev },
                new object[] { Trauma, 2, 23m, minutes, stddev },
                new object[] { Trauma, 3, 30m, minutes, stddev },
                new object[] { Trauma, 4, 38m, minutes, stddev },
                new object[] { Trauma, 5, 92m, minutes, stddev },
                new object[] { Trauma, 6, 0m, minutes, stddev },
                new object[] { Trauma, 7, 0m, minutes, stddev },
                new object[] { Trauma, 8, 0m, minutes, stddev },

                new object[] { Urology, 1, 121m, minutes, average },
                new object[] { Urology, 2, 59m, minutes, average },
                new object[] { Urology, 3, 74m, minutes, average },
                new object[] { Urology, 4, 102m, minutes, average },
                new object[] { Urology, 5, 152m, minutes, average },
                new object[] { Urology, 6, 230m, minutes, average },
                new object[] { Urology, 7, 385m, minutes, average },
                new object[] { Urology, 8, 0m, minutes, average },

                new object[] { Urology, 1, 68m, minutes, stddev },
                new object[] { Urology, 2, 30m, minutes, stddev },
                new object[] { Urology, 3, 26m, minutes, stddev },
                new object[] { Urology, 4, 49m, minutes, stddev },
                new object[] { Urology, 5, 49m, minutes, stddev },
                new object[] { Urology, 6, 68m, minutes, stddev },
                new object[] { Urology, 7, 123m, minutes, stddev },
                new object[] { Urology, 8, 0m, minutes, stddev },
            };

        [TestMethod]
        [DynamicData(nameof(Table2Data))]
        public void Table2(
            string specialty,
            int category,
            decimal value,
            string unit,
            string statistic)
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IContextsAbstractFactory contextsAbstractFactory = abstractFactory.CreateContextsAbstractFactory();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IExportsAbstractFactory exportsAbstractFactory = abstractFactory.CreateExportsAbstractFactory();
            
            ISurgicalDurationInputContext surgicalDurationInputContext = contextsAbstractFactory.CreateSurgicalDurationInputContextFactory().Create(
                category: dependenciesAbstractFactory.CreateNullableValueFactory().Create<int>(category),
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().Create(specialty, SNOMEDCT, null),
                statistic: dependenciesAbstractFactory.CreateValueFactory().Create(statistic));

            ISurgicalDurationExport surgicalDurationExport = exportsAbstractFactory.CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }
    }
}