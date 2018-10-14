const fs = require('fs')

console.log('Building Regate JavaScript C# Partial Classes')

const components = [
  'RegateText',
  'RegateTextarea',
  'RegateCkeditor',
  'RegateContentEditable',
  'RegateDropdown',
  'RegateFile',
  'RegateImage',
  'RegateNumber',
  'RegatePersianDateTimePicker',
  'RegateSwitch',
  'RegateForeignKey',
]

components.forEach(component => {
  console.log(component)
  var code = fs.readFileSync(`./dist/${component}.js`, 'utf8')

  code = code.replace(/\"/g, "'")
  code = code.replace('exports.default = ', `window.Regate.${component} = `)
  code = code.replace("Object.defineProperty(exports, '__esModule', ", 'var smile = function() {}; smile(')
  code = code.replace("'use strict';", '')

  code = `;(function () {
    window.Regate = window.Regate || {};
    ${code}
  }());`
  
  if (! fs.existsSync(`./${component}`)) { fs.mkdirSync(`./${component}`); }

  const csharpClass = `
/*
 * [AUTOGENERATED]
 *
 * This file is autogenerated by nodejs.
 * Run \`node build\' to generate new version.
 * 
 * Please do not manually modify this files.
 */

using System;
using System.Net;

namespace Regate
{
    public static partial class ${component}
    {
        private static string _GetJs()
        {
            return @"${code}";
        }
    }
}
  `
  
  fs.writeFileSync(`./${component}/${component}JavaScript.cs`, csharpClass)
})