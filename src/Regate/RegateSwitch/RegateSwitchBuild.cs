using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class RegateSwitch
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateSwitch__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            
            return $@"
                <script>document.write(Regate.RegateSwitch.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateSwitch.init({{
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
