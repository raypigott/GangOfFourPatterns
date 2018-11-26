using System;

namespace GangOfFourPatterns.Strategy
{
    public class TextEditor
    {
        public static string PublishText(string text, Predicate<string> filter, Func<string, string> format)
        {
            return filter(text) 
                ? (format(text)) 
                : string.Empty;
        }
    }
}