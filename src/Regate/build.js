const fs = require('fs')

console.log('Building Regate JavaScript C# Partial Classes')

const components = [
  'RegateText',
  'RegateTextarea',
]

components.forEach(component => {
  console.log(component)
  var code = fs.readFileSync(`./dist/${component}.js`, 'utf8')
  code = '/*\n' + code
  code  = code.replace('var _typeof', '*/\n\nvar _typeof')
  code = code.replace(/\"/g, "'")
  code = code.replace('exports.default = ', '// exports.default = ')

  code = `;(function () {
    window.Regate = window.Regate || {}
    ${code}
    window.Regate.${component} = ${component};
  }());`
  
  if (! fs.existsSync(`./${component}`)) { fs.mkdirSync(`./${component}`); }

  const csharpClass = `using System;
using System.Net;

namespace Regate
{
    public static partial class ${component}
    {
        public static string Init()
        {
            return $"<script>{_GetJs()}</script>";
        }

        private static string _GetJs()
        {
            return @"${code}";
        }
    }
}
  `
  
  fs.writeFileSync(`./${component}/${component}JavaScript.cs`, csharpClass)
})