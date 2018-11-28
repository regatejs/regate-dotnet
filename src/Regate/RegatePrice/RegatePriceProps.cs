using System;
using System.Net;

namespace Regate
{
    public static partial class RegatePrice
    {
        
        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, string value) : this(name)
            {
                Value = value;
            }

            public Props(string name, int? value) : this(name)
            {
                Value = RegatePriceHelpers.ConvertToString(value);
            }

            public Props(string name, float? value) : this(name)
            {
                Value = RegatePriceHelpers.ConvertToString(value);
            }

            public Props(string name, double? value) : this(name)
            {
                Value = RegatePriceHelpers.ConvertToString(value);
            }

            public Props(string name, decimal? value) : this(name)
            {
                Value = RegatePriceHelpers.ConvertToString(value);
            }

            public string Name { get; }
            public string Value { get; }
            public bool IsRequired { get; set; }
        }
    }

}
