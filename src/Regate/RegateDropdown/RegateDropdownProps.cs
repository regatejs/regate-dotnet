using System;
using System.Collections.Generic;
using System.Net;

namespace Regate
{
    public static partial class RegateDropdown
    {
        
        private class Props
        {
            public Props()
            {
            }

            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, int? value) : this(name)
            {
                Value = value;
            }

            public string Name { get; }
            public int? Value { get; }
            public bool IsRequired { get; set; }
            public List<KeyValuePair<int, string>> Options { get; set; }
        }
    }

}
