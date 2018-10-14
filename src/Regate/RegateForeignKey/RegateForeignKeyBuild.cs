using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class RegateForeignKey
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateForeignKey__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            return $@"
                <script>document.write(Regate.RegateForeignKey.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateForeignKey.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{props.Value}',
                        apiUrl: '{props.ApiUrl}',
                        isRequired: {props.IsRequired.ToString().ToLower()},
                    }});
                </script>
            ";
        }

    }

}
