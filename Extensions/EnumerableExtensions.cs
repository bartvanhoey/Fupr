// ReSharper disable once CheckNamespace
namespace Fupr
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Extension method by Simon Painter 
        /// </summary>
       
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T>? source) => source ?? Enumerable.Empty<T>();

        /// <summary>
        /// Extension method by Simon Painter 
        /// </summary>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T>? items) => items != null && items.Any();

        /// <summary>
        /// Extension method by Simon Painter 
        /// </summary>
        public static IEnumerable<T> Adjust<T>(this IEnumerable<T> items, Func<T, int, bool> shouldReplace,
            T replacement) => items.Select((x, index) => shouldReplace(x, index) ? replacement : x);

      
        /// <summary>
        /// Extension method by Simon Painter 
        /// </summary>
        public static bool ContainsConsecutiveNumbers(this IEnumerable<int> arr) =>
            arr.Any((x, y) => y == x + 1);

        /// <summary>
        /// Extension method by Simon Painter 
        /// </summary>
        private static bool Any<T>(this IEnumerable<T> @this, Func<T, T, bool> f) =>
            @this.GetEnumerator().Any(f);

        /// <summary>
        /// Extension method by Simon Painter 
        /// </summary>
        private static bool Any<T>(this IEnumerator<T> @this, Func<T, T, bool> f)
        {
            @this.MoveNext();
            return Any(@this, f, @this.Current);
        }

        /// <summary>
        /// Extension method by Simon Painter 
        /// </summary>
        private static bool Any<T>(this IEnumerator<T> @this, Func<T, T, bool> f, T prev) =>
            @this.MoveNext() && (f(prev, @this.Current) || Any(@this, f, @this.Current));
    }
}