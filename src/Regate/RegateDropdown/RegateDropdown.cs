using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Reflection;

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


        public static List<KeyValuePair<int, string>> EnumToList<T>()
        {
            Type enumType = typeof(T);

            var items = new List<KeyValuePair<int, string>>();

            var values = Enum.GetValues(enumType);
            items.AddRange(from Enum item in values
                select new KeyValuePair<int, string>(Convert.ToInt32(item), GetEnumDisplayValue(item)));

            return items;
        }

        /// <summary>
        ///     A generic extension method that aids in reflecting 
        ///     and retrieving any attribute that is applied to an `Enum`.
        /// 
        /// By: Mojtaba Dashtinejad
        /// https://stackoverflow.com/a/25109103/3971911
        /// </summary>
        private static string GetEnumDisplayValue(Enum enumValue)
        {
            if (enumValue == null) return "";

            try
            {
                var model = enumValue.GetType()
                    .GetMember(enumValue.ToString())
                    .First()
                    .GetCustomAttribute<DisplayAttribute>();

                return model != null && ! string.IsNullOrWhiteSpace(model.Name)
                    ? model.Name
                    : enumValue.ToString();
            }
            catch (Exception)
            {
                return enumValue.ToString();
            }
        }
    }

}
