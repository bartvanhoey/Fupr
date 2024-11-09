namespace Fupr.Extensions;

public static class BoolExtensions
{
    public static void IfFalse(this bool @this, Action action)
        {
            if (!@this)
                action();
        }

        public static void IfTrue(this bool @this, Action action)
        {
            if (@this)           
                action();
        }

        public static void IfFalse<T>(this bool @this, Action<T> action, T input)
        {
            if (!@this)
                action(input);
        }

        public static void IfTrue<T>(this bool @this, Action<T> action, T input)
        {
            if (@this)
                action(input);
        }

        public static void IfFalse<T, TS>(this bool @this, Action<T, TS> action, T t, TS s)
        {
            if (!@this)
                action(t, s);
        }

        public static void IfTrue<T, TS>(this bool @this, Action<T, TS> action, T t, TS s)
        {
            if (@this)
                action(t, s);
        }

        public static void IfFalse<T, TS, TU>(this bool @this, Action<T, TS, TU> action, T t, TS s, TU u)
        {
            if (!@this)
                action(t, s, u);
        }

        public static void IfTrue<T, TS, TU>(this bool @this, Action<T, TS, TU> action, T t, TS s, TU u)
        {
            if (@this)
                action(t, s, u);
        }   

        public static void IfFalse<T, TS, TU, TV>(this bool @this, Action<T, TS, TU, TV> action, T t, TS s, TU u, TV v)
        {
            if (!@this)
                action(t, s, u, v);
        }

        public static void IfTrue<T, TS, TU, TV>(this bool @this, Action<T, TS, TU, TV> action, T t, TS s, TU u, TV v)
        {
            if (@this)
                action(t, s, u, v);
        }   
         

        public static TR? IfFalse<TR>(this bool @this, Func<TR> func) 
            => (@this) ? default : func();

        public static TR? IfFalse<T, TR>(this bool @this, Func<T, TR> f, T input)
            => @this ? default : f(input);

        public static TR? IfFalse<T, TS, TR>(this bool @this, Func<T, TS, TR> f, T t, TS s)
            => @this ? default : f(t, s);

        public static TR? IfFalse<T, TS, TU, TR>(this bool @this, Func<T, TS, TU, TR> f, T t, TS s, TU u)
            => @this ? default : f(t, s, u);

        public static TR? IfFalse<T, TS, TU, TV, TR>(this bool @this, Func<T, TS, TU, TV, TR> f, T t, TS s, TU u, TV v)
            => @this ? default : f(t, s, u, v);

        public static TR? IfTrue<TR>(this bool @this, Func<TR> f)
            => @this ? f() : default;

        public static TR? IfTrue<T, TR>(this bool @this, Func<T, TR> f, T input)
            => @this ? f(input) : default;

        public static TR? IfTrue<T, TS, TR>(this bool @this, Func<T, TS, TR> f, T t, TS s)
            => @this ? f(t, s) : default;

        public static TR? IfTrue<T, TS, TU, TR>(this bool @this, Func<T, TS, TU, TR> f, T t, TS s, TU u)
            => @this ? f(t, s, u) : default;

        public static TR? IfTrue<T, TS, TU, TV, TR>(this bool @this, Func<T, TS, TU, TV, TR> f, T t, TS s, TU u, TV v)
            => @this ? f(t, s, u, v) : default;

}