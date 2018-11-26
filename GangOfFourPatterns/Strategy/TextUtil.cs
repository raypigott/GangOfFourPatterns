namespace GangOfFourPatterns.Strategy
{
    public class TextUtil
    {
        public static bool AcceptAll(string text)
        {
            return true;
        }

        public static bool AcceptErrors(string text)
        {
            return text.StartsWith("ERROR");
        }

        public static bool UnderTwenty(string text)
        {
            return text.Length < 20;
        }

        public static string NoFormatting(string text)
        {
            return text;
        }

        public static string FormatError(string text)
        {
            return text.ToUpper();
        }

        public static string ToLowerCase(string text)
        {
            return text.ToLower();
        }
    }
}