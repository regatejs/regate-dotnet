using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class InteractiveBoolean
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"InteractiveBoolean__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            return $@"
                <script>document.write(Regate.InteractiveBoolean.markup('{uniqueId}'))</script>

                <script>
                    Regate.InteractiveBoolean.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        apiUrl: '{props.ApiUrl}',
                        value: '{(props.Value.HasValue ? props.Value.ToString().ToLower() : "null")}',
                    }});
                </script>
            ";
        }

    }

}
