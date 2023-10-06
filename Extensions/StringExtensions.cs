using System.Text.RegularExpressions;
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
        public static bool IsNullOrEmpty(this string @this) => string.IsNullOrEmpty(@this);

        
        [ContractAnnotation("null => true")]
        public static bool IsNotNullOrEmpty(this string @this) => string.IsNullOrEmpty(@this);

        
        [ContractAnnotation("null => true")]
        public static bool IsNullOrWhiteSpace(this string? @this) => string.IsNullOrWhiteSpace(@this);
        
        
        [ContractAnnotation("null => true")]
        public static bool IsNotNullOrWhiteSpace(this string? @this) => !string.IsNullOrWhiteSpace(@this);
        
        // Extension method by Symon Painter
        public static IEnumerable<IEnumerable<string>> Parser (this string input, string lineSplit, string fieldSplit) =>
            input.Split(new[] { lineSplit }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Split(new[] { fieldSplit }, StringSplitOptions.RemoveEmptyEntries));
        
        
        // Modified Extension method by ABP Framework
        [ContractAnnotation("null <= this:null")]
        public static string ToSentenceCase(this string @this) 
            => string.IsNullOrWhiteSpace(@this) ? @this : Regex.Replace(@this, "[a-z][A-Z]", m => m.Value[0] + " " + char.ToLowerInvariant(m.Value[1]));
    }
    
    
}
