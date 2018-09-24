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

        private static string _GetJs()
        {
            return @"
var _typeof = typeof Symbol === 'function' && typeof Symbol.iterator === 'symbol' ? function (obj) { return typeof obj; } : function (obj) { return obj && typeof Symbol === 'function' && obj.constructor === Symbol && obj !== Symbol.prototype ? 'symbol' : typeof obj; };

var RegateText = {};

RegateText.init = function (_ref) {
  var id = _ref.id,
      name = _ref.name,
      value = _ref.value,
      isRequired = _ref.isRequired,
      placeholder = _ref.placeholder,
      onInitialized = _ref.onInitialized,
      onChange = _ref.onChange;


  if (id === undefined) throw new Error('id is required');

  var _container = document.getElementById(id);
  _container.insertAdjacentHTML('afterend', RegateText.markup(id));
  _container.parentNode.removeChild(_container);

  var _input = document.getElementById(id + '__input');

  _input.name = name;

  if (isRequired === true) _input.required = true;

  if (value !== undefined) _input.value = value;

  if (placeholder !== undefined) _input.placeholder = placeholder;

  if ((typeof onInitialized === 'undefined' ? 'undefined' : _typeof(onInitialized)) === (typeof Function === 'undefined' ? 'undefined' : _typeof(Function))) {
    var isValid = isRequired ? value !== undefined && value.length > 0 : true;

    onInitialized({ value: value, isValid: isValid });
  }

  if ((typeof onChange === 'undefined' ? 'undefined' : _typeof(onChange)) === (typeof Function === 'undefined' ? 'undefined' : _typeof(Function))) {
    _input.oninput = function () {
      var value = _input.value;

      var isValid = isRequired ? value !== undefined && value.length > 0 : true;

      onChange({ value: value, isValid: isValid });
    };
  }
};

RegateText.markup = function (id) {
  return '\n  <input\n    id=\'' + id + '__input\'\n    type=\'text\'\n    class=\'form-control\'\n  />\n';
};

            ";
        }

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
