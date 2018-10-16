using System;
using System.Collections.Generic;
using System.Net;

namespace Regate
{
    public static partial class RegateTextMulti
    {
        
        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, List<string> value) : this(name)
            {
                Value = value;
            }

            public string Name { get; }
            public List<string> Value { get; }
            public bool IsRequired { get; set; }
        }
    }

}
