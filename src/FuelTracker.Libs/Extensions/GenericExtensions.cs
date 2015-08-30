using System;

namespace FuelTracker.Libs.Extensions
{
    public static class GenericExtensions
    {
        public static void Then<TSource>(this TSource source, Action<TSource> target)
        {
            target(source);
        }
    }
}