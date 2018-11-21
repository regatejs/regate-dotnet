using System;
using System.Net;

namespace Regate
{
    public static partial class RegateTimePicker
    {
        
        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, TimeSpan? value) : this(name)
            {
                Value = value;
            }

            public string Name { get; }
            public TimeSpan? Value { get; }
            public bool IsRequired { get; set; }
        }
    }

}
