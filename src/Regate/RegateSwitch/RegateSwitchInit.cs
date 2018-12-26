﻿namespace Regate
{
    public static partial class RegateSwitch
    {
        public static string Init()
        {
            return $@"
                <script>{JavaScriptDependency()}</script>
                <style>{CssDependency()}</style>
                <script>{_GetJs()}</script>
            ";
        }

        public static string JavaScriptDependency()
        {
            var content = @"



            ";
            return content;
        }

        public static string CssDependency()
        {
            var content = @"

.switch{display:inline-block;vertical-align:middle;cursor:pointer;font-family:Helvetica Neue,Helvetica,Arial,sans-serif;box-sizing:content-box;outline:none}
.switch,.switch small{position:relative;-webkit-user-select:none;-moz-user-select:none;-ms-user-select:none;user-select:none;-webkit-tap-highlight-color:transparent}
.switch small{font-size:12px;top:0;border-radius:100%;text-align:center;display:block;background:#fff;box-shadow:0 1px 3px rgba(0,0,0,.4);-webkit-transition:all .2s;transition:all .2s;overflow:hidden;color:#000}
.switch-default{width:50px;height:30px;border-radius:20px;line-height:30px}
.switch-default small{width:30px;height:30px}
.switch-small{border-radius:20px;height:20px;width:33px;line-height:20px}
.switch-small small{height:20px;width:20px}
.switch-large{border-radius:40px;height:40px;width:66px;line-height:40px}
.switch-large small{height:40px;width:40px}
.switch-disabled{opacity:.5}

            ";

            return content;
        }
    }
}
  