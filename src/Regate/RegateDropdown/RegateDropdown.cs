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
        public static string Build<T>(string name) =>
            _Build(new Props(name, EnumToList<T>()));

        public static string Build<T>(string name, int? value) =>
            _Build(new Props(name, EnumToList<T>(), value));

        public static string Build<T>(string name, bool isRequired) =>
            _Build(new Props(name, EnumToList<T>(), isRequired));

        public static string Build<T>(string name, int? value, bool isRequired) =>
            _Build(new Props(name, EnumToList<T>(), value, isRequired));

        public static string Build<T>(string name, T value) =>
            _Build(value == null
                ? new Props(name, EnumToList<T>())
                : new Props(name, EnumToList<T>(), Convert.ToInt32(value))
            );

        public static string Build<T>(string name, T value, bool isRequired) =>
            _Build(value == null
                ? new Props(name, EnumToList<T>(), isRequired)
                : new Props(name, EnumToList<T>(), Convert.ToInt32(value), isRequired)
            );


        public static string Build(string name, List<KeyValuePair<int, string>> options) =>
            _Build(new Props(name, options));

        public static string Build(string name, List<KeyValuePair<int, string>> options, int? value) =>
            _Build(new Props(name, options, value));

        public static string Build(string name, List<KeyValuePair<int, string>> options, bool isRequired) =>
            _Build(new Props(name, options, isRequired));

        public static string Build(string name, List<KeyValuePair<int, string>> options, int? value, bool isRequired) =>
            _Build(new Props(name, options, value, isRequired));



        private static List<KeyValuePair<int, string>> EnumToList<T>()
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
