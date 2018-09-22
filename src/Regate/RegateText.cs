using System;
using System.Net;

namespace Regate
{
    public static class RegateText
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, bool isRequired) =>
            _Build(new Props(name, isRequired));

        public static string Build(string name, string value) =>
            _Build(new Props(name, value));

        public static string Build(string name, string value, bool isRequired) =>
            _Build(new Props(name, value, isRequired));

        public static string Build(string name, Options options) =>
            _Build(new Props(name, options));

        public static string Build(string name, bool isRequired, Options options) =>
            _Build(new Props(name, isRequired, options));

        public static string Build(string name, string value, Options options) =>
            _Build(new Props(name, value, options));

        public static string Build(string name, string value, bool isRequired, Options options) =>
            _Build(new Props(name, value, isRequired, options));

        private static string _Build(Props props)
        {
            var value = WebUtility.HtmlEncode(props.Value);

            return $@"<input
                type='text'
                name='{props.Name}'
                class='form-control'
                placeholder='{props.Placeholder}'
                value='{value}'
                {(props.IsRequired ? " required='required' " : "")}
            />";
        }

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
