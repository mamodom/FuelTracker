using System;

namespace FuelTracker.Libs.Extensions
{
    public static class GenericExtensions
    {
        public static void Finally<TSource>(this TSource source, Action<TSource> target) => target(source);
        public static TTarget Then<TSource, TTarget>(this TSource source, Func<TSource, TTarget> func) => func(source);

        public static TSource Tap<TSource>(this TSource source, Action<TSource> action)
        {
            action(source);
            return source;
        }

    }
}