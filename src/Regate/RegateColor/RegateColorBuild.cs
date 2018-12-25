using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class RegateColor
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateColor__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            
            return $@"
                <script>document.write(Regate.RegateColor.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateColor.init({{
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
