using System;
using System.Net;

namespace Regate
{
    public static partial class Regate
    {
        public static string Text(string name) =>
            _Build(new TextProps(name));

        public static string Text(string name, bool isRequired) =>
            _Build(new TextProps(name, isRequired));

        public static string Text(string name, string value) =>
            _Build(new TextProps(name, value));

        public static string Text(string name, string value, bool isRequired) =>
            _Build(new TextProps(name, value, isRequired));

        public static string Text(string name, TextOptions options) =>
            _Build(new TextProps(name, options));

        
        private static string _Build(TextProps props)
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

        public class TextOptions
        {
            public string Placeholder { get; set; }
        }

        private class TextProps
        {
            public TextProps()
            {
            }

            public TextProps(string name)
            {
                Name = name;
            }

            public TextProps(string name, string value) : this(name)
            {
                Value = value;
            }

            public TextProps(string name, bool isRequired) : this(name)
            {
                IsRequired = isRequired;
            }

            public TextProps(string name, TextOptions options) : this(name)
            {
                this.Placeholder = options.Placeholder;
            }

            public TextProps(string name, string value, bool isRequired) : this(name, value)
            {
                IsRequired = isRequired;
            }

            public string Name { get; set; }
            public string Value { get; set; }
            public string Placeholder { get; set; }
            public bool IsRequired { get; set; }
        }
    }

}
