using System;
using System.Net;

namespace Regate
{
    public static partial class RegateText
    {
        private static string _Build(Props props)
        {
            var uniqueId = $"RegateText__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = WebUtility.HtmlEncode(props.Value);
            var placeholder = WebUtility.HtmlEncode(props.Placeholder);

            return $@"
                <script>{_GetJs()}</script>
                <template id='{uniqueId}'></template>

                <script>
                    RegateText.init({{
                        id: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{value}',
                        placeholder: '{placeholder}',
                        isRequired: {props.IsRequired.ToString().ToLower()},
                    }});
                </script>
            ";
        }

    }

}
