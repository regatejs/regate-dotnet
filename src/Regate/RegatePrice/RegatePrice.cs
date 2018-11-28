using System;
using System.Net;

namespace Regate
{
    public static partial class RegatePrice
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, string value) =>
            _Build(new Props(name, value));

        public static string Build(string name, int? value) =>
            _Build(new Props(name, RegatePriceHelpers.ConvertToString(value)));

        public static string Build(string name, float? value) =>
            _Build(new Props(name, RegatePriceHelpers.ConvertToString(value)));

        public static string Build(string name, decimal? value) =>
            _Build(new Props(name, RegatePriceHelpers.ConvertToString(value)));

        public static string Build(string name, double? value) =>
            _Build(new Props(name, RegatePriceHelpers.ConvertToString(value)));

        public static string Build(
              string name
            , bool isRequired = false
        ) =>
            _Build(new Props(name)
            {
                IsRequired = isRequired,
            });

        public static string Build(
              string name
            , string value = null
            , bool isRequired = false
        ) =>
            _Build(new Props(name, value)
            {
                IsRequired = isRequired,
            });

        public static string Build(
              string name
            , int? value = null
            , bool isRequired = false
        ) =>
            _Build(new Props(name, RegatePriceHelpers.ConvertToString(value))
            {
                IsRequired = isRequired,
            });

        public static string Build(
              string name
            , double? value = null
            , bool isRequired = false
        ) =>
            _Build(new Props(name, RegatePriceHelpers.ConvertToString(value))
            {
                IsRequired = isRequired,
            });

        public static string Build(
              string name
            , float? value = null
            , bool isRequired = false
        ) =>
            _Build(new Props(name, RegatePriceHelpers.ConvertToString(value))
            {
                IsRequired = isRequired,
            });

        public static string Build(
              string name
            , decimal? value = null
            , bool isRequired = false
        ) =>
            _Build(new Props(name, RegatePriceHelpers.ConvertToString(value))
            {
                IsRequired = isRequired,
            });
    }

}
