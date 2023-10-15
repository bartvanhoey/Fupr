using System.ComponentModel;
using Fupr.Functional.MaybeClass;
using Fupr.Functional.ResultClass.Errors;
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

        public static Result<T> Ensure<T>(this Result<T> result, Func<T, bool> func, BaseResultError baseResultError)
        {
            if (result.IsFailure) return result;
            return func(result.Value) ? result : Fail<T>(baseResultError);
        }
    }
}