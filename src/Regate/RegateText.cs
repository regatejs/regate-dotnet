using System;
using System.Net;

namespace Regate
{
    public static class RegateText
    {
        public static string Build(
            string name = "",
            string value = "",
            bool isRequired = false,
            string placeholder = ""
        )
        {
            value = WebUtility.HtmlEncode(value);

            return $@"<input
                name='{name}'
                type='text'
                class='form-control'
                placeholder='{placeholder}'
                value='{value}'
                {(isRequired ? " required='required' " : "")}
            />";
        }
    }

    public class RegateTextProps
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Placeholder { get; set; }
        public bool IsRequired { get; set; }
    }
}
