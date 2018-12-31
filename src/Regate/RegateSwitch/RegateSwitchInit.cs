namespace Regate
{
    public static partial class RegateSwitch
    {
        public static string Init()
        {
            return $@"
                <script>{_GetJs()}</script>
            ";
        }
    }
}
  