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
                <script>document.write(Regate.RegateNumber.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateNumber.init({{
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
