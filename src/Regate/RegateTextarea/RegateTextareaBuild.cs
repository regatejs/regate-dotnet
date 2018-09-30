using System;
using System.Net;

namespace Regate
{
    public static partial class RegateTextarea
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateTextarea__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = WebUtility.HtmlEncode(props.Value);

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
