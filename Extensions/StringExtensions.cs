namespace Fupr.Extensions
{
    public static class StringExtensions
    {
        // Extension method by Simon Painter
        public static string ValueOrDefault(this string? @this, string defaultValue)
                => string.IsNullOrWhiteSpace(@this) ? defaultValue : @this;
    }
}
