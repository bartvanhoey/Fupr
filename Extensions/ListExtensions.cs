namespace Fupr.Extensions;

public static class ListExtensions
{
    public static List<T> AddIfNotNull<T>(this List<T> list, T? item)
    {
        if (item != null)
        {
            list.Add(item);
        }

        return list;
    }
    
    public static bool SafeAny<T>(this IList<T>? list) => list != null && list.Any();

    public static IEnumerable<T> DistinctByProperty<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property) => items.GroupBy(property).Select(x => x.First());

    public static bool HasOneItem<T>(this IList<T> list) => list.SafeAny() && list.Count == 1;

    public static bool HasManyItems<T>(this IList<T> list) => list.SafeAny() && list.Count > 1;

    public static bool HasAny<T>(this IList<T> list, Func<T, bool> predicate) => list.SafeAny() && list.Any(predicate);
}

