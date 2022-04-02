﻿namespace VanHoudenhoven2007.Classes.Exports
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.AbstractFactories;
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

        public DataType GetSurgicalData(
            PositiveInt category,
            CodeableConcept specialty,
            Code statistic)
        {
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDurationFactory durationFactory = abstractFactory.CreateDependenciesAbstractFactory().CreateDurationFactory();

            ISurgicalData surgicalData = specialty.Text switch
            {
                // EarNoseThroatSurgery
                "394604002" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateEarNoseThroatSurgerySurgicalDurationFactory().Create(
                    durationFactory),

                // GeneralSurgery
                "394609007" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateGeneralSurgerySurgicalDurationFactory().Create(
                    durationFactory),

                // GynecologicalSurgery
                "394586005" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateGynecologicalSurgerySurgicalDurationFactory().Create(
                    durationFactory),

                // Neurosurgery
                "394610002" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateNeurosurgerySurgicalDurationFactory().Create(
                    durationFactory),

                // Ophthalmology
                "422191005" or "394594003" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateOphthalmologySurgicalDurationFactory().Create(
                    durationFactory),

                // OralSurgery
                "394605001" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateOralSurgerySurgicalDurationFactory().Create(
                    durationFactory),

                // OrthopedicSurgery
                "24241000087106" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateOrthopedicSurgerySurgicalDurationFactory().Create(
                    durationFactory),

                // PlasticSurgery
                "394611003" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreatePlasticSurgerySurgicalDurationFactory().Create(
                    durationFactory),

                // Trauma
                "394801008" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateTraumaSurgicalDurationFactory().Create(
                    durationFactory),

                // Urology
                "394612005" => abstractFactory.CreateSurgicalDurationsAbstractFactory().CreateUrologySurgicalDurationFactory().Create(
                    durationFactory),

                _ => null
            };

            return statistic.Value switch
            {
                "average" => category.Value switch
                {
                  1 => ((ISurgicalDuration)(surgicalData)).Category1Mean,

                  2 => ((ISurgicalDuration)(surgicalData)).Category2Mean,

                  3 => ((ISurgicalDuration)(surgicalData)).Category3Mean,

                  4 => ((ISurgicalDuration)(surgicalData)).Category4Mean,
                  
                  5 => ((ISurgicalDuration)(surgicalData)).Category5Mean,

                  6 => ((ISurgicalDuration)(surgicalData)).Category6Mean,

                  7 => ((ISurgicalDuration)(surgicalData)).Category7Mean,

                  8 => ((ISurgicalDuration)(surgicalData)).Category8Mean,

                  _ => null
                },

                "std-dev" => category.Value switch
                {
                    1 => ((ISurgicalDuration)(surgicalData)).Category1StandardDeviation,

                    2 => ((ISurgicalDuration)(surgicalData)).Category2StandardDeviation,

                    3 => ((ISurgicalDuration)(surgicalData)).Category3StandardDeviation,

                    4 => ((ISurgicalDuration)(surgicalData)).Category4StandardDeviation,

                    5 => ((ISurgicalDuration)(surgicalData)).Category5StandardDeviation,

                    6 => ((ISurgicalDuration)(surgicalData)).Category6StandardDeviation,

                    7 => ((ISurgicalDuration)(surgicalData)).Category7StandardDeviation,

                    8 => ((ISurgicalDuration)(surgicalData)).Category8StandardDeviation,

                    _ => null
                },

                _ => null
            };
        }
    }
}