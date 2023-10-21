using System.Text;

// ReSharper disable once CheckNamespace
namespace Fupr
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendFormattedLine(this StringBuilder sb, string format,  params object[] args) 
            => sb.AppendFormat(format, args).AppendLine();

        public static StringBuilder AppendWhen(this StringBuilder @this, Func<bool> predicate, Func<StringBuilder,StringBuilder> func) 
            => predicate() ? func(@this) : @this;

        public static StringBuilder AppendSequence<T>(this StringBuilder @this, IEnumerable<T> sequence,
            Func<StringBuilder, T, StringBuilder> fn) => sequence.Aggregate(@this, fn);

    }
}