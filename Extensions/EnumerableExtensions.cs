// ReSharper disable once CheckNamespace

using static System.ArgumentNullException;

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
        
        public static bool IsNullOrEmpty<T>(this ICollection<T> source) => source == null || source.Count <= 0;

        public static bool AddIfNotContains<T>(this ICollection<T> source, T item)
        {
            ThrowIfNull(source);
            if (source.Contains(item)) return false;
            source.Add(item);
            return true;
        }

        public static IEnumerable<T> AddIfNotContains<T>(this ICollection<T> source, IEnumerable<T> items)
        {
            ThrowIfNull(items);

            var addedItems = new List<T>();

            foreach (var item in items)
            {
                if (source.Contains(item)) continue;
                source.Add(item);
                addedItems.Add(item);
            }
            return addedItems;
        }

        public static bool AddIfNotContains<T>(this ICollection<T> source,Func<T,bool> predicate, Func<T> itemFactory)
        {

            ThrowIfNull(predicate);
            ThrowIfNull(itemFactory);

            if (source.Any(predicate)) return false;

            source.Add(itemFactory());
            return true;
        }

        public static IList<T> RemoveAll<T>(this ICollection<T> source, Func<T, bool> predicate)
        {
            var items = source.Where(predicate).ToList();
            foreach (var item in items) source.Remove(item);
            return items;
        }
        
    }
}