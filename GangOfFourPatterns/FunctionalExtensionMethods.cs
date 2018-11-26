using System;

namespace GangOfFourPatterns
{
    public static class FunctionalExtensionMethods
    {
        public static Func<A, Func<B, C>> Curry<A, B, C>(this Func<A, B, C> func) => a => b => func(a, b);

        public static Func<T, TReturn2> Compose<T, TReturn1, TReturn2>(this Func<TReturn1, TReturn2> func1, Func<T, TReturn1> func2)
        {
            return x => func1(func2(x));
        }

        public static Func<T, TResult2> Then<T, TResult1, TResult2>(this Func<T, TResult1> function1, Func<TResult1, TResult2> function2) => value => function2(function1(value));
    }
}
