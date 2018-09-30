using System;
using System.Net;

namespace Regate
{
    public static partial class RegateText
    {
        public static string Init()
        {
            return $"<script>{_GetJs()}</script>";
        }

        private static string _GetJs()
        {
            return @";(function () {
    window.Regate = window.Regate || {}
    /*
'use strict';

Object.defineProperty(exports, '__esModule', {
  value: true
});

*/

var _typeof = typeof Symbol === 'function' && typeof Symbol.iterator === 'symbol' ? function (obj) { return typeof obj; } : function (obj) { return obj && typeof Symbol === 'function' && obj.constructor === Symbol && obj !== Symbol.prototype ? 'symbol' : typeof obj; };

var RegateText = {};

RegateText.init = function (_ref) {
  var id = _ref.id,
      name = _ref.name,
      _ref$value = _ref.value,
      value = _ref$value === undefined ? '' : _ref$value,
      _ref$isRequired = _ref.isRequired,
      isRequired = _ref$isRequired === undefined ? false : _ref$isRequired,
      _ref$placeholder = _ref.placeholder,
      placeholder = _ref$placeholder === undefined ? '' : _ref$placeholder,
      onInitialized = _ref.onInitialized,
      onChange = _ref.onChange;


  if (id === undefined) throw new Error('id is required');

  var _input = document.getElementById(id + '__input');

  if (_input === undefined) throw new Error('id is invalid');

  _input.name = name;

  if (isRequired === true) _input.required = true;

  if (value !== undefined) _input.value = value;

  if (placeholder !== undefined) _input.placeholder = placeholder;

  if ((typeof onInitialized === 'undefined' ? 'undefined' : _typeof(onInitialized)) === (typeof Function === 'undefined' ? 'undefined' : _typeof(Function))) {
    var isValid = isRequired ? value.length > 0 : true;

    onInitialized({ value: value, isValid: isValid });
  }

  if ((typeof onChange === 'undefined' ? 'undefined' : _typeof(onChange)) === (typeof Function === 'undefined' ? 'undefined' : _typeof(Function))) {
    _input.oninput = function () {
      var value = _input.value;

      var isValid = isRequired ? value.length > 0 : true;

      onChange({ value: value, isValid: isValid });
    };
  }
};

RegateText.markup = function (id) {
  return '\n  <input\n    id=\'' + id + '__input\'\n    type=\'text\'\n    class=\'form-control\'\n  />\n';
};

// exports.default = RegateText;
    window.Regate.RegateText = RegateText;
  }());";
        }
    }
}
  