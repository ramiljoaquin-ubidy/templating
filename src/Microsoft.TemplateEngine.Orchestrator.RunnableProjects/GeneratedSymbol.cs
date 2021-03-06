using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Microsoft.TemplateEngine.Orchestrator.RunnableProjects
{
    public class GeneratedSymbol : ISymbolModel
    {
        // NOTE (scp 2016-09-16): Not used (i think). Only here to satisfy the interface
        public string Binding { get; set; }

        // NOTE (scp 2016-09-16): Not used (i think). Only here to satisfy the interface
        public string Replaces { get; set; }

        // Refers to the Type property value of a concrete IMacro
        public string Generator { get; set; }

        public IReadOnlyDictionary<string, JToken> Parameters { get; set; }

        public string Type { get; set; }

        public static ISymbolModel FromJObject(JObject jObject)
        {
            GeneratedSymbol sym = new GeneratedSymbol
            {
                Binding = jObject.ToString(nameof(Binding)),
                Generator = jObject.ToString(nameof(Generator)),
                Parameters = jObject.ToJTokenDictionary(StringComparer.Ordinal, nameof(Parameters)),
                Type = jObject.ToString(nameof(Type)),
                Replaces = jObject.ToString(nameof(Replaces))
            };

            return sym;
        }
    }
}