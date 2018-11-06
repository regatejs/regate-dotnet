using System;
using System.Net;

namespace Regate
{
    public static partial class InteractiveBoolean
    {
        
        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, bool? value) : this(name)
            {
                Value = value;
            }

            public string Name { get; }
            public bool? Value { get; }
            public string ApiUrl { get; set; }
            public bool IsNullable { get; set; }
        }
    }

}
