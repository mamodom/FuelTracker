using System;

namespace FuelTracker.Libs
{
    public static class GenericExtensions
    {
        public static void Pipe<TSource>(this TSource source, Action<TSource> target)
        {
            target(source);
        }
    }
}