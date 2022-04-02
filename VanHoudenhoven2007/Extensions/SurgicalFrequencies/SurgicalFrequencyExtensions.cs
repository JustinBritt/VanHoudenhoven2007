namespace VanHoudenhoven2007.Extensions.SurgicalFrequencies
{
    using Hl7.Fhir.Model;

    using VanHoudenhoven2007.Interfaces.SurgicalFrequencies;

    public static class SurgicalFrequencyExtensions
    {
        public static DataType GetValue(
            this ISurgicalFrequency surgicalFrequency,
            PositiveInt category)
        {
            return category.Value switch
            {
                1 => surgicalFrequency.Category1Frequency,

                2 => surgicalFrequency.Category2Frequency,

                3 => surgicalFrequency.Category3Frequency,

                4 => surgicalFrequency.Category4Frequency,

                5 => surgicalFrequency.Category5Frequency,

                6 => surgicalFrequency.Category6Frequency,

                7 => surgicalFrequency.Category7Frequency,

                8 => surgicalFrequency.Category8Frequency,

                _ => null
            };
        }
    }
}