namespace VanHoudenhoven2007.Extensions.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalDurations;

    public static class SurgicalDurationExtensions
    {
        public static Duration GetValue(
            this ISurgicalDuration surgicalDuration,
            PositiveInt category,
            Code statistic)
        {
            return statistic.Value switch
            {
                "average" => category.Value switch
                {
                    1 => surgicalDuration.Category1Mean,

                    2 => surgicalDuration.Category2Mean,

                    3 => surgicalDuration.Category3Mean,

                    4 => surgicalDuration.Category4Mean,

                    5 => surgicalDuration.Category5Mean,

                    6 => surgicalDuration.Category6Mean,

                    7 => surgicalDuration.Category7Mean,

                    8 => surgicalDuration.Category8Mean,

                    _ => null
                },

                "std-dev" => category.Value switch
                {
                    1 => surgicalDuration.Category1StandardDeviation,

                    2 => surgicalDuration.Category2StandardDeviation,

                    3 => surgicalDuration.Category3StandardDeviation,

                    4 => surgicalDuration.Category4StandardDeviation,

                    5 => surgicalDuration.Category5StandardDeviation,

                    6 => surgicalDuration.Category6StandardDeviation,

                    7 => surgicalDuration.Category7StandardDeviation,

                    8 => surgicalDuration.Category8StandardDeviation,

                    _ => null
                },

                _ => null
            };
        }
    }
}