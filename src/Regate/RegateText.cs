using System;
using System.Net;

namespace Regate
{
    public static class RegateText
    {
        public static string Build(string name) =>
            _Build(new Props(name));

        public static string Build(string name, bool isRequired) =>
            _Build(new Props(name, isRequired));

        public static string Build(string name, string value) =>
            _Build(new Props(name, value));

        public static string Build(string name, string value, bool isRequired) =>
            _Build(new Props(name, value, isRequired));

        public static string Build(string name, Options options) =>
            _Build(new Props(name, options));

        public static string Build(string name, bool isRequired, Options options) =>
            _Build(new Props(name, isRequired, options));

        public static string Build(string name, string value, Options options) =>
            _Build(new Props(name, value, options));

        public static string Build(string name, string value, bool isRequired, Options options) =>
            _Build(new Props(name, value, isRequired, options));

        private static string _GetHtml()
        {
            return @"
<input
  data-role='input'
  type='text'
  class='form-control'
/>
            ";
        }

        private static string _GetJs()
        {
            return @"
window.Regate = window.Regate || {}
Regate.Text = Regate.Text || {}

Regate.Text.init = function ({
  uniqueId,
  name,
  value,
  isRequired,
  placeholder,
  onInitialized,
  onChange,
}) {
  var _container = document.getElementById(uniqueId)
  var _input = _container.querySelector('[data-role=input]')
  
  _input.name = name

  if (isRequired === true)
    _input.required = true

  if (value !== undefined)
    _input.value = value

  if (placeholder !== undefined)
    _input.placeholder = placeholder

  if (typeof onInitialized === typeof Function) {
    const isValid = isRequired
      ? value !== undefined && value.length > 0
      : true

      onInitialized({value, isValid})
  }

  if (typeof onChange === typeof Function) {
      _input.oninput = () => {
        const value = _input.value

        const isValid = isRequired
          ? value !== undefined && value.length > 0
          : true

        onChange({value, isValid})
      }
  }
}
            ";
        }

        private static string _Build(Props props)
        {
            var html = _GetHtml();
            var js = _GetJs();

            var uniqueId = $"RegateText__{props.Name}__{Guid.NewGuid().ToString().Replace("-", "")}";

            var value = WebUtility.HtmlEncode(props.Value);

            return $@"
                <span id='{uniqueId}'>{html}</span>
                <script>{js}</script>

                <script>
                    Regate.Text.init({{
                        uniqueId: '{uniqueId}',
                        name: '{props.Name}',
                        value: '{value}',
                        isRequired: {props.IsRequired.ToString().ToLower()},
                    }});
                </script>
            ";
        }

        public class Options
        {
            public string Placeholder { get; set; }
        }

        private class Props
        {
            public Props(string name)
            {
                Name = name;
            }

            public Props(string name, string value) : this(name)
            {
                Value = value;
            }

            public Props(string name, bool isRequired) : this(name)
            {
                IsRequired = isRequired;
            }

            public Props(string name, Options options) : this(name)
            {
                Placeholder = options.Placeholder;
            }

            public Props(string name, string value, bool isRequired) : this(name, value)
            {
                IsRequired = isRequired;
            }

            public Props(string name, bool isRequired, Options options) : this(name, isRequired)
            {
                Placeholder = options.Placeholder;
            }

            public Props(string name, string value, Options options) : this(name, value)
            {
                Placeholder = options.Placeholder;
            }

            public Props(string name, string value, bool isRequired, Options options) : this(name, value, isRequired)
            {
                Placeholder = options.Placeholder;
            }

            public string Name { get; }
            public string Value { get; }
            public string Placeholder { get; }
            public bool IsRequired { get; }
        }
    }

}
