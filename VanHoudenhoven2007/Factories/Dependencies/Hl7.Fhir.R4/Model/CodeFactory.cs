﻿namespace VanHoudenhoven2007.Factories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    using VanHoudenhoven2007.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class CodeFactory : ICodeFactory
    {
        public CodeFactory()
        {
        }

        public Code Create(
            string value)
        {
            Code code = null;

            try
            {
                code = new Code(
                    value);
            }
            finally
            {
            }

            return code;
        }
    }
}