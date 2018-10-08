using System;
using System.Net;

namespace Regate
{
    public static partial class RegateDropdown
    {
        
        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, int? value) : this(name)
            {
                Value = value;
            }

            public Props(string name, bool isRequired) : this(name)
            {
                IsRequired = isRequired;
            }

            public Props(string name, int? value, bool isRequired) : this(name, value)
            {
                IsRequired = isRequired;
            }

            public string Name { get; }
            public int? Value { get; }
            public bool IsRequired { get; }
        }
    }

}
