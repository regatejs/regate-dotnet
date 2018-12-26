using System;
using System.Net;

namespace Regate
{
    public static partial class RegateSwitch
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
        }
    }

}
