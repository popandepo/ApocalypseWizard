using System.Text.RegularExpressions;

namespace Assets.Code
{
    public class Tools
    {
        public static string CamelCaseToString(string input)
        {
            return Regex.Replace(
                Regex.Replace(
                    input,
                    @"(\P{Ll})(\P{Ll}\p{Ll})",
                    "$1 $2"
                ),
                @"(\p{Ll})(\P{Ll})",
                "$1 $2"
            );
        }
    }
}