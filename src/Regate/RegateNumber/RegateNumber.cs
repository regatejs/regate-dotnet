using System;
using System.Net;

namespace Regate
{
    public static partial class RegateNumber
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, bool isRequired) =>
            _Build(new Props(name, isRequired));

        public static string Build(string name, int? value) =>
            _Build(new Props(name, value));

        public static string Build(string name, float? value) =>
            _Build(new Props(name, value));

        public static string Build(string name, decimal? value) =>
            _Build(new Props(name, value));

        public static string Build(string name, int? value, bool isRequired) =>
            _Build(new Props(name, value, isRequired));

        public static string Build(string name, float? value, bool isRequired) =>
            _Build(new Props(name, value, isRequired));

        public static string Build(string name, decimal? value, bool isRequired) =>
            _Build(new Props(name, value, isRequired));

    }

}
