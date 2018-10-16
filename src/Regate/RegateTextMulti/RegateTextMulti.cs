using System;
using System.Collections.Generic;
using System.Net;

namespace Regate
{
    public static partial class RegateTextMulti
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, List<string> value) =>
            _Build(new Props(name, value));

        public static string Build(
              string name
            , List<string> value
            , bool isRequired = false
        ) =>
            _Build(new Props(name, value)
            {
                IsRequired = isRequired,
            });
    }

}
