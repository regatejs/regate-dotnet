using System;
using System.Net;

namespace Regate
{
    public static partial class RegateText
    {
        public class Options
        {
            public string Placeholder { get; set; }
        }

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

            public Props(string name, bool isRequired) : this(name)
            {
                IsRequired = isRequired;
            }

            public Props(string name, Options options) : this(name)
            {
                Placeholder = options.Placeholder;
            }

            public Props(string name, string value, bool isRequired) : this(name, value)
            {
                IsRequired = isRequired;
            }

            public Props(string name, bool isRequired, Options options) : this(name, isRequired)
            {
                Placeholder = options.Placeholder;
            }

            public Props(string name, string value, Options options) : this(name, value)
            {
                Placeholder = options.Placeholder;
            }

            public Props(string name, string value, bool isRequired, Options options) : this(name, value, isRequired)
            {
                Placeholder = options.Placeholder;
            }

            public string Name { get; }
            public string Value { get; }
            public string Placeholder { get; }
            public bool IsRequired { get; }
        }
    }

}
