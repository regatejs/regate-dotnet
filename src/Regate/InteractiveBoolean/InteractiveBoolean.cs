using System;
using System.Net;

namespace Regate
{
    public static partial class InteractiveBoolean
    {
        public static string Build(string apiUrl, string name) =>
            _Build(new Props(apiUrl, name));

        public static string Build(string apiUrl, string name, bool? value) =>
            _Build(new Props(apiUrl, name, value));

        public static string Build(
              string apiUrl
            , string name
            , bool? value = null
            , bool isNullable = false
        ) =>
            _Build(new Props(apiUrl, name, value)
            {
                IsNullable = isNullable,
            });

    }

}
