using System;
using System.Net;

namespace Regate
{
    public static partial class RegatePriceHelpers
    {
        public static string ConvertToString(float value)
        {
            return Convert.ToInt32(value).ToString();
        }

        public static string ConvertToString(decimal value)
        {
            return Convert.ToInt32(value).ToString();
        }

        public static string ConvertToString(double value)
        {
            return Convert.ToInt32(value).ToString();
        }
    }

}
