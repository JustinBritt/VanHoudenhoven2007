﻿namespace VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    public interface INullableValueFactory
    {
        INullableValue<T> Create<T>(
            T? value)
            where T : struct;
    }
}