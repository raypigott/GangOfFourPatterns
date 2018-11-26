using System;

namespace GangOfFourPatterns.Tests
{
    /// <summary>
    /// I like this example of compose
    /// taken from https://github.com/MostlyAdequate/mostly-adequate-guide
    /// </summary>
    class Clown
    {
        public static Func<string, string> toUpper = x => x.ToUpper();

        public static Func<string, string> exclaim = x => $"{x}!";

        public static Func<string, string> shout = compose(exclaim, toUpper);

        private static Func<T, TReturn2> compose<T, TReturn1, TReturn2>(Func<TReturn1, TReturn2> func1, Func<T, TReturn1> func2)
        {
            return x => func1(func2(x));
        }
    }
}