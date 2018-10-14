using System;
using System.Net;

namespace Regate
{
    public static partial class RegatePersianDateTimePicker
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, DateTime? value) =>
            _Build(new Props(name, value));

        public static string Build(
              string name
            , DateTime? value = null
            , bool isRequired = false
            , bool isTimeFrom = false
            , bool isTimeTill = false
            , bool hasTimePicker = false
        ) =>
            _Build(new Props(name, value)
            {
                IsRequired = isRequired,
                IsTimeFrom = isTimeFrom,
                IsTimeTill = isTimeTill,
                HasTimePicker = hasTimePicker,
            });
    }

}
