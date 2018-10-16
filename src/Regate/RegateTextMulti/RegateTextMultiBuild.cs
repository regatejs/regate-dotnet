using System;
using System.Linq;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class RegateTextMulti
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateText__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = string.Join("\n", props.Value);
            value = JavaScriptEncoder.Default.Encode(value);


            return $@"
                <script>document.write(Regate.RegateTextMulti.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateTextMulti.init({{
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
