using System;
using System.Net;

namespace Regate
{
    public static partial class RegateContentEditable
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateContentEditable__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = WebUtility.HtmlEncode(props.Value);

            return $@"
                <script>document.write(Regate.RegateContentEditable.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateContentEditable.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{value}',
                    }});
                </script>
            ";
        }

    }

}
