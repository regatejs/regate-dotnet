using System;
using System.Net;

namespace Regate
{
    public static partial class RegateCkeditor
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, string value) =>
            _Build(new Props(name, value));

    }

}
