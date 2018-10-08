using System;
using System.Collections.Generic;
using System.Net;

namespace Regate
{
    public static partial class RegateDropdown
    {
        
        private class Props
        {
            public Props(string name, List<KeyValuePair<int, string>> options)
            {
                Name = name;
                Options = options;
            }

            public Props(string name, List<KeyValuePair<int, string>> options, int? value) : this(name, options)
            {
                Value = value;
            }

            public Props(string name, List<KeyValuePair<int, string>> options, bool isRequired) : this(name, options)
            {
                IsRequired = isRequired;
            }


            public Props(string name, List<KeyValuePair<int, string>> options, int? value, bool isRequired) : this(name, options, value)
            {
                IsRequired = isRequired;
            }

            public string Name { get; }
            public int? Value { get; }
            public bool IsRequired { get; }
            public List<KeyValuePair<int, string>> Options { get; set; }
        }
    }

}
