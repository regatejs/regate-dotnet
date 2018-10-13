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
            _Build(new Props(name)
            {
                Options = EnumToList<T>(),
            });

        public static string Build<T>(string name, int? value) =>
            _Build(new Props(name, value)
            {
                Options = EnumToList<T>(),
            });

        public static string Build<T>(string name, Enum value) =>
            _Build(value == null
                ? new Props(name)
                {
                    Options = EnumToList<T>(),
                }
                : new Props(name, Convert.ToInt32(value))
                {
                    Options = EnumToList<T>(),
                }
            );


        public static string Build<T>(
              string name
            , Enum value = null
            , bool isRequired = false
            , List<KeyValuePair<int, string>> options = null
        ) =>
            _Build(value == null
                ? new Props(name)
                {
                    IsRequired = isRequired,
                    Options = options,
                }
                : new Props(name, Convert.ToInt32(value))
                {
                    IsRequired = isRequired,
                    Options = options,
                });


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
