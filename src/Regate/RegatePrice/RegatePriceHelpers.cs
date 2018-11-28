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
    }

}
