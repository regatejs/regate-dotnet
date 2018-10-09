using System;
using System.Net;

namespace Regate
{
    public static partial class RegatePersianDateTimePicker
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

            public string Name { get; set; }
            public DateTime? Value { get; set; }
            public bool IsRequired { get; set; }
            public bool IsTimeFrom { get; set; }
            public bool IsTimeTill { get; set; }
            public bool HasTimePicker { get; set; }
        }
    }

}
