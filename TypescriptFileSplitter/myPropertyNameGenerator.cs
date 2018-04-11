using NJsonSchema;
using NJsonSchema.CodeGeneration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TypescriptFileSplitter
{
    public class myPropertyNameGenerator : IPropertyNameGenerator
    {
        public string Generate(JsonProperty property)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            return ConversionUtilities.ConvertToUpperCamelCase(property.Name,false);
        }
    }
}
