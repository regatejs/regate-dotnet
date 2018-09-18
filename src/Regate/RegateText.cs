using System;
using System.Net;

namespace Regate
{
    public static partial class Regate
    {
        public static string Text(string name)
        {
            var props = new RegateTextProps(name);
            return _Build(props);
        }

        public static string Text(string name, string value)
        {
            var props = new RegateTextProps(name, value);
            return _Build(props);
        }

        private static string _Build(RegateTextProps props)
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
    }

    public class RegateTextProps
    {
        public RegateTextProps(string name)
        {
            Name = name;
        }

        public RegateTextProps(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }
        public string Placeholder { get; set; }
        public bool IsRequired { get; set; }
    }
}
