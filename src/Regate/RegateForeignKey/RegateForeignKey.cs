using System;
using System.Net;

namespace Regate
{
    public static partial class RegateForeignKey
    {
        public static string Build(string apiUrl, string name) =>
            _Build(new Props(apiUrl, name));

        public static string Build(string apiUrl, string name, string value) =>
            _Build(new Props(apiUrl, name, value));

        public static string Build(
              string apiUrl
            , string name
            , string value = null
            , bool isRequired = false
        ) =>
            _Build(value == null
                ? new Props(apiUrl, name)
                {
                    IsRequired = isRequired,
                }
                : new Props(apiUrl, name, value)
                {
                    IsRequired = isRequired,
                });

        public static string Build(string apiUrl, string name, int? value) =>
            _Build(value == null
                ? new Props(apiUrl, name)
                : new Props(apiUrl, name, value.ToString())
            );

        public static string Build(string apiUrl, string name, Guid value) =>
            _Build(new Props(apiUrl, name, value.ToString()));

        public static object Build(string apiUrl, string name, Enum value) =>
            _Build(value == null
                ? new Props(apiUrl, name)
                : new Props(apiUrl, name, Convert.ToInt32(value).ToString())
            );
    }

}
