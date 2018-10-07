using System;
using System.Net;

namespace Regate
{
    public static partial class RegatePersianDateTimePicker
    {
        
        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, DateTime? value) : this(name)
            {
                Value = value;
            }

            public Props(string name, bool isRequired) : this(name)
            {
                IsRequired = isRequired;
            }

            public Props(string name, DateTime? value, bool isRequired) : this(name, value)
            {
                IsRequired = isRequired;
            }

            public string Name { get; }
            public DateTime? Value { get; }
            public bool IsRequired { get; }
        }
    }

}
