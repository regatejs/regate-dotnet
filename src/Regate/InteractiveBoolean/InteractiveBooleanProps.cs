using System;
using System.Net;

namespace Regate
{
    public static partial class InteractiveBoolean
    {
        
        private class Props
        {
            public Props(string apiUrl, string name)
            {
                Name = name;
                ApiUrl = apiUrl;
            }

            public Props(string apiUrl, string name, bool? value) : this(apiUrl, name)
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
