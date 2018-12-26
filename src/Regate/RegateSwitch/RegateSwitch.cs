using System;
using System.Net;

namespace Regate
{
    public static partial class RegateSwitch
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, bool? value) =>
            _Build(new Props(name, value));
    }

}
