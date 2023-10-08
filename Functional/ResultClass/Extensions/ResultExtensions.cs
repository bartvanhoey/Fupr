using Fupr.Functional.MaybeClass;
using static Fupr.Functional.ResultClass.Result;

namespace Fupr.Functional.ResultClass.Extensions
{
    // Copyright (c) 2015 Vladimir Khorikov
    //
    // Permission is hereby granted, free of charge, to any person obtaining a copy of
    // this software and associated documentation files (the "Software"), to deal in
    // the Software without restriction, including without limitation the rights to
    //     use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
    // the Software, and to permit persons to whom the Software is furnished to do so,
    // subject to the following conditions:

    public static partial class ResultExtensions
    {
        public static Result<T> ToResult<T>(this Maybe<T> maybe, BaseResultError resultError) where T : class?
            => maybe.HasNoValue ? Fail<T>(resultError) : Ok(maybe.Value)!;

        public static Result<T> ToResult<T>(this Maybe<T> maybe, string? errorMessage = null) where T : class?
            => maybe.HasNoValue
                ? Fail<T>(new ResultError(errorMessage ?? "No error message provided"))
                : Ok(maybe.Value)!;

        
     

        public static Result OnBoth(this Result result, Action<Result> action)
        {
            action(result);
            return result;
        }

        public static T OnBoth<T>(this Result result, Func<Result, T> func)
            => func(result);

        public static Result<TR> Map<T, TR>(this Result<T> result, Func<T, TR> func)
            => result.IsFailure ? Fail<TR>(result.Error) : Ok(func(result.Value));

        public static Result<T> Ensure<T>(this Result<T> result, Func<T, bool> func, BaseResultError baseResultError)
        {
            if (result.IsFailure) return result;
            return func(result.Value) ? result : Fail<T>(baseResultError);
        }
    }
}