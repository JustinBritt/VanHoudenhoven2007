namespace VanHoudenhoven2007.Classes.Exports
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.AbstractFactories;
    using VanHoudenhoven2007.Interfaces.Exports;
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesAbstractFactories;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed class Export : IExport
    {
        public Export()
        {
        }

        // TODO: Finish
        public void GetSurgicalDuration(
            PositiveInt category,
            CodeableConcept specialty,
            Code statistic)
        {
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDurationFactory durationFactory = abstractFactory.CreateDependenciesAbstractFactory().CreateDurationFactory();

            ISurgicalDuration surgicalDuration = specialty.Text switch
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
        }
    }
}