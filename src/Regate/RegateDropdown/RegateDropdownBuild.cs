using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Encodings.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Regate
{
    public static partial class RegateDropdown
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateDropdown__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var options = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "سیب"),
                new KeyValuePair<int, string>(2, "پرتقال"),
                new KeyValuePair<int, string>(3, "هلو"),
            };

            var optionsJsonString = JsonConvert.SerializeObject(options,
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            return $@"
                <script>document.write(Regate.RegateDropdown.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateDropdown.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{props.Value}',
                        isRequired: {props.IsRequired.ToString().ToLower()},
                        options: {optionsJsonString},
                    }});
                </script>
            ";
        }

    }

}
