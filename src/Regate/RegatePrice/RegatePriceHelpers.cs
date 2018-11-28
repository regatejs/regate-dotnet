using System;
using System.Net;

namespace Regate
{
    public static class RegatePriceHelpers
    {
        public static string ConvertToString(float? value)
        {
            if (value == null) return null;
            return Convert.ToInt32(value).ToString();
        }

        public static string ConvertToString(decimal? value)
        {
            if (value == null) return null;
            return Convert.ToInt32(value).ToString();
        }

        public static string ConvertToString(double? value)
        {
            if (value == null) return null;
            return Convert.ToInt32(value).ToString();
        }

        public static string ConvertToString(int? value)
        {
            if (value == null) return null;
            return value.ToString();
        }
    }

}
