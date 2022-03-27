namespace VanHoudenhoven2007.InterfacesFactories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IGynecologicalSurgerySurgicalDurationFactory
    {
        IGynecologicalSurgerySurgicalDuration Create(
            IDurationFactory durationFactory);
    }
}