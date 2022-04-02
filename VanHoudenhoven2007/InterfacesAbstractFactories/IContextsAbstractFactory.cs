namespace VanHoudenhoven2007.InterfacesAbstractFactories
{
    using VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Contexts.SurgicalFrequencies;

    public interface IContextsAbstractFactory
    {
        ISurgicalDurationInputContextFactory CreateSurgicalDurationInputContextFactory();

        ISurgicalDurationOutputContextFactory CreateSurgicalDurationOutputContextFactory();

        ISurgicalFrequencyInputContextFactory CreateSurgicalFrequencyInputContextFactory();

        ISurgicalFrequencyOutputContextFactory CreateSurgicalFrequencyOutputContextFactory();
    }
}