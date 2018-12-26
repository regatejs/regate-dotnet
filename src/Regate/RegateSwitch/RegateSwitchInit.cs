namespace Regate
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



            ";

            return content;
        }
    }
}
  