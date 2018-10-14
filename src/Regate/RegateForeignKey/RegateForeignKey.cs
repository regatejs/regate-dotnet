using System;
using System.Net;

namespace Regate
{
    public static partial class RegateForeignKey
    {
        public static string Build(string apiUrl, string name) =>
            _Build(new Props(apiUrl, name));

        public static string Build(string apiUrl, string name, string value) =>
            _Build(new Props(name, value));

    }

}
