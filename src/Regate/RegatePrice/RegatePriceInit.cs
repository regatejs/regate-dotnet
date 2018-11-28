namespace Regate
{
    public static partial class RegatePrice
    {
        public static string Init()
        {
            return $@"
                <script>{_GetJs()}</script>
            ";
        }
    }
}
  