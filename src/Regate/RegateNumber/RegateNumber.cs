﻿using System;
using System.Net;

namespace Regate
{
    public static partial class RegateNumber
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        /*
        public static string Build(string name, short? value) =>
            _Build(new Props(name, value));
        */

        public static string Build(string name, int? value) =>
            _Build(new Props(name, value));

        public static string Build(string name, float? value) =>
            _Build(new Props(name, value));

        public static string Build(string name, decimal? value) =>
            _Build(new Props(name, value));

        
        public static string Build(
              string name
            , decimal? value = null
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
            _Build(new Props(name, value)
            {
                IsRequired = isRequired,
            });

        public static string Build(
              string name
            , float? value = null
            , bool isRequired = false
        ) =>
            _Build(new Props(name, value)
            {
                IsRequired = isRequired,
            });


        public static object Build(string name, bool isRequired = false) =>
            _Build(new Props(name)
            {
                IsRequired = isRequired,
            });
    }

}
