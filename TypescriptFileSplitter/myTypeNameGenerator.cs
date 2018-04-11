using NJsonSchema;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TypescriptFileSplitter
{
    public class myTypeNameGenerator : ITypeNameGenerator
    {
        public string Generate(JsonSchema4 schema, string typeNameHint, IEnumerable<string> reservedTypeNames)
        {
            DefaultTypeNameGenerator dng = new DefaultTypeNameGenerator();
            return dng.Generate(schema, typeNameHint, reservedTypeNames) + "ViewModel";
        }
    }
}
