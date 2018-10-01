using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class RegateTextarea
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateTextarea__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = string.IsNullOrWhiteSpace(props.Value) ? "" : props.Value;
            value = JavaScriptEncoder.Default.Encode(value);

            return $@"
                <script>document.write(Regate.RegateTextarea.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateTextarea.init({{
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
