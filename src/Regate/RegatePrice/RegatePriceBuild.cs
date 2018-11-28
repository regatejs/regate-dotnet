using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class RegatePrice
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegatePrice__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            
            return $@"
                <script>document.write(Regate.RegatePrice.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegatePrice.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{props.Value}',
                        isRequired: {props.IsRequired.ToString().ToLower()},
                    }});
                </script>
            ";
        }

    }

}
