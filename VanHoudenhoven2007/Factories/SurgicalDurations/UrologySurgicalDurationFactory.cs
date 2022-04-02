﻿namespace VanHoudenhoven2007.Factories.SurgicalDurations
{
    using VanHoudenhoven2007.Interfaces.SurgicalDurations;
    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanHoudenhoven2007.InterfacesFactories.SurgicalDurations;
    using VanHoudenhoven2007.Records.SurgicalDurations;

    internal sealed class UrologySurgicalDurationFactory : IUrologySurgicalDurationFactory
    {
        public UrologySurgicalDurationFactory()
        {
        }

        public ISurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IUrologySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new UrologySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}