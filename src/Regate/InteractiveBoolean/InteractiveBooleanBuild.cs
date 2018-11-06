using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class InteractiveBoolean
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateText__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = string.IsNullOrWhiteSpace(props.Value) ? "" : props.Value;
            value = JavaScriptEncoder.Default.Encode(value);


            return $@"
                <script>document.write(Regate.RegateText.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateText.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{value}',
                        isRequired: {props.IsRequired.ToString().ToLower()},
                    }});
                </script>
            ";
        }

    }

}
