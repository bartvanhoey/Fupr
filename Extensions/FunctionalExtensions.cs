using static System.Console;

namespace Fupr.Extensions
{
    public static class FunctionalExtensions
    {
        // Extension method by Simon Painter
        public static TOutput Map<TInput, TOutput>(this TInput input, Func<TInput, TOutput> f) => f(input);
        
        // Extension method by Simon Painter
        public static void ToConsole<T>(this T input, string? message = null)
        {
            if (message.IsNullOrWhiteSpace())
                WriteLine(input);
            else
                WriteLine($"{message}: {input}");
        }

        // Extension method by Simon Painter
        public static T Tee<T>(this T input, Action<T> act)
        {
            act(input);
            return input;
        }

        // Extension method by Simon Painter
        public static T2? DoIfNotNull<T1, T2>(this T1 @this, Func<T1, T2> f)
            => EqualityComparer<T1>.Default.Equals(@this, default) ? default : f(@this);

        // Extension method by Simon Painter
        public static bool Validate<T>(this T @this, params Func<T, bool>[] validators)
            => validators.All(v => v(@this));
    }
}