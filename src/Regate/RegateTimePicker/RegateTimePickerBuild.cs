using System;
using System.Net;
using System.Text.Encodings.Web;

namespace Regate
{
    public static partial class RegateTimePicker
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateTimePicker__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            
            return $@"
                <script>document.write(Regate.RegateTimePicker.markup('{uniqueId}'))</script>

                <script>
                    Regate.RegateTimePicker.init({{
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
