using System;
using System.Net;

namespace Regate
{
    public static partial class RegateForeignKey
    {
        
        private class Props
        {
            public Props(string apiUrl, string name)
            {
                Name = name;
                ApiUrl = apiUrl;
            }

            public Props(string apiUrl, string name, string value) : this(apiUrl, name)
            {
                Value = value;
            }

            public string Name { get; }
            public string Value { get; }
            public bool IsRequired { get; set; }
            public string ApiUrl { get; set;  }
        }
    }

}
