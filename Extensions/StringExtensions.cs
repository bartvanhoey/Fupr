using JetBrains.Annotations;
using static System.String;

namespace Fupr.Extensions
{
    public static class StringExtensions
    {
        // Extension method by Simon Painter
        public static string ValueOrDefault(this string? @this, string defaultValue)
                => @this.IsNullOrWhiteSpace() ? defaultValue : @this;
        
        // Extension method by Simon Painter
        public static int ValueOrDefault(this string? @this, int defaultValue)
            => @this.IsNullOrWhiteSpace() || !int.TryParse(@this, out var parsedValue) ? defaultValue : parsedValue;
        
        
        [ContractAnnotation("null => true")]
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

        
        [ContractAnnotation("null => true")]
        public static bool IsNullOrWhiteSpace(this string? str) => string.IsNullOrWhiteSpace(str);
        
        public static IEnumerable<IEnumerable<string>> Parser (this string input, string lineSplit, string fieldSplit) =>
            input.Split(new[] { lineSplit }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Split(new[] { fieldSplit }, StringSplitOptions.RemoveEmptyEntries));
    }
    
    
}
