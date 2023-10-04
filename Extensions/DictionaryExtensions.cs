namespace Fupr.Extensions
{
    public static class DictionaryExtensions
    {
        // Extension method by Simon Painter
        public static Func<TK, T> ToLookupWithDefault<TK, T>(this IDictionary<TK, T> @dic, T defaultValue)
            => x => dic.TryGetValue(x, out var value) ? value : defaultValue;

        // Extension method by Simon Painter
        public static Func<TK, T?> ToLookup<TK, T>(this IDictionary<TK, T> @dic)
            => x => dic.TryGetValue(x, out var value) ? value : default;

    }
}