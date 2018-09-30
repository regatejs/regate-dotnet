using System;
using System.Net;

namespace Regate
{
    public static partial class RegateNumber
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateNumber__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            return $@"
                <script>document.write(Regate.RegateTextarea.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateTextarea.init({{
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
