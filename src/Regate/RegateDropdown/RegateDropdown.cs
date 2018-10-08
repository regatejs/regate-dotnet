using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;

namespace Regate
{
    public static partial class RegateDropdown
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, bool isRequired) =>
            _Build(new Props(name, isRequired));

        public static string Build(string name, int? value) =>
            _Build(new Props(name, value));

        public static string Build(string name, int? value, bool isRequired) =>
            _Build(new Props(name, value, isRequired));

        public static string Build(string name, List<KeyValuePair<int, string>> options) =>
            _Build(new Props(name, options));


        public static List<KeyValuePair<int, string>> EnumToList(Type enumType)
        {
            var items = new List<KeyValuePair<int, string>>();

            var values = Enum.GetValues(enumType);
            items.AddRange(from Enum item in values
                select new KeyValuePair<int, string>(Convert.ToInt32(item), GetEnumDisplayValue(item)));

            return items;
        }

        private static string GetEnumDisplayValue(Enum enumName)
        {
            return enumName.ToString();
        }
    }

}
