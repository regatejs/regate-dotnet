namespace Regate
{
    public static partial class RegateFile
    {
        public static string Init()
        {
            return $@"<script>{_GetJs()}</script>";
        }
    }
}
  