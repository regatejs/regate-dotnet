using System;
using System.Net;

namespace Regate
{
    public static partial class RegatePersianDateTimePicker
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, bool isRequired) =>
            _Build(new Props(name, isRequired));

        public static string Build(string name, DateTime value) =>
            _Build(new Props(name, value));

        public static string Build(string name, DateTime value, bool isRequired) =>
            _Build(new Props(name, value, isRequired));

    }

}
