using System;
using System.Net;

namespace Regate
{
    public static partial class RegateText
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

            public string Name { get; }
            public string Value { get; }
            public bool IsRequired { get; set; }
        }
    }

}
