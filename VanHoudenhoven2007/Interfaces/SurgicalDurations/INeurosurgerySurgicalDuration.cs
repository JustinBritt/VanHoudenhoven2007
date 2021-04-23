namespace VanHoudenhoven2007.Interfaces.SurgicalDurations
{
    using Hl7.Fhir.Model;

    public interface INeurosurgerySurgicalDuration
    {
        Duration Category1Mean { get; }

        Duration Category2Mean { get; }

        Duration Category3Mean { get; }

        Duration Category4Mean { get; }

        Duration Category5Mean { get; }

        Duration Category6Mean { get; }

        Duration Category7Mean { get; }

        Duration Category8Mean { get; }

        Duration Category1StandardDeviation { get; }

        Duration Category2StandardDeviation { get; }

        Duration Category3StandardDeviation { get; }

        Duration Category4StandardDeviation { get; }

        Duration Category5StandardDeviation { get; }

        Duration Category6StandardDeviation { get; }

        Duration Category7StandardDeviation { get; }

        Duration Category8StandardDeviation { get; }
    }
}