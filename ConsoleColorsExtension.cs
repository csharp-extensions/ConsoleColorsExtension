using System.Text.RegularExpressions;

namespace CSharpExtensions.OpenSource.ConsoleColors
{
    public static class ConsoleColorsExtension
    {
        private const string Reset = "\u001b[0m";

        public static string CleanColors(this string str)
        {
            if (string.IsNullOrEmpty(str)) { return str; }
            var regex = new Regex("\\u001b\\[[\\d]+m", RegexOptions.None);
            return regex.Replace(str, "");
        }

        public static string ColorByNumber(this string str, int num) => $"\u001b[{num}m" + str + Reset;
        public static string Black(this string str) => ColorByNumber(str, 30);
        public static string Red(this string str) => ColorByNumber(str, 31);
        public static string Yellow(this string str) => ColorByNumber(str, 33);
        public static string Green(this string str) => ColorByNumber(str, 32);
        public static string Blue(this string str) => ColorByNumber(str, 34);
        public static string Magenta(this string str) => ColorByNumber(str, 35);
        public static string Cyan(this string str) => ColorByNumber(str, 36);
        public static string White(this string str) => ColorByNumber(str, 37);
        public static string BlackBg(this string str) => ColorByNumber(str, 40);
        public static string RedBg(this string str) => ColorByNumber(str, 41);
        public static string YellowBg(this string str) => ColorByNumber(str, 43);
        public static string GreenBg(this string str) => ColorByNumber(str, 42);
        public static string BlueBg(this string str) => ColorByNumber(str, 44);
        public static string MagentaBg(this string str) => ColorByNumber(str, 45);
        public static string CyanBg(this string str) => ColorByNumber(str, 46);
        public static string WhiteBg(this string str) => ColorByNumber(str, 47);
    }
}
