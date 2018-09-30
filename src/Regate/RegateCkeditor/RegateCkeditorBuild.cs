using System;
using System.Net;

namespace Regate
{
    public static partial class RegateCkeditor
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateCkeditor__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = WebUtility.HtmlEncode(props.Value);
            var placeholder = WebUtility.HtmlEncode(props.Placeholder);

            return $@"
                <script>document.write(Regate.RegateCkeditor.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateCkeditor.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{value}',
                    }});
                </script>
            ";
        }

    }

}
