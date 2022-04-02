namespace VanHoudenhoven2007.Classes.Exports
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.AbstractFactories;
    using VanHoudenhoven2007.Enums;
    using VanHoudenhoven2007.Interfaces.Exports;
    using VanHoudenhoven2007.Interfaces;
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed class Export : IExport
    {
        public Export()
        {
        }

        public DataType GetSurgicalDuration(
            PositiveInt category,
            CodeableConcept specialty,
            Code statistic)
        {
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            ISurgicalDurationsAbstractFactory surgicalDurationsAbstractFactory = abstractFactory.CreateSurgicalDurationsAbstractFactory();

            IDurationFactory durationFactory = abstractFactory.CreateDependenciesAbstractFactory().CreateDurationFactory();

            ISurgicalDuration surgicalData = surgicalDurationsAbstractFactory.CreateSurgicalDurationFactory(specialty).Create(durationFactory);

            return statistic.Value switch
            {
                "average" => category.Value switch
                {
                  1 => surgicalData.Category1Mean,

                  2 => surgicalData.Category2Mean,

                  3 => surgicalData.Category3Mean,

                  4 => surgicalData.Category4Mean,
                  
                  5 => surgicalData.Category5Mean,

                  6 => surgicalData.Category6Mean,

                  7 => surgicalData.Category7Mean,

                  8 => surgicalData.Category8Mean,

                  _ => null
                },

                "std-dev" => category.Value switch
                {
                    1 => surgicalData.Category1StandardDeviation,

                    2 => surgicalData.Category2StandardDeviation,

                    3 => surgicalData.Category3StandardDeviation,

                    4 => surgicalData.Category4StandardDeviation,

                    5 => surgicalData.Category5StandardDeviation,

                    6 => surgicalData.Category6StandardDeviation,

                    7 => surgicalData.Category7StandardDeviation,

                    8 => surgicalData.Category8StandardDeviation,

                    _ => null
                },

                _ => null
            };
        }
    }
}