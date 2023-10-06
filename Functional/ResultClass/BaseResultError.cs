using Fupr.Extensions;

namespace Fupr.Functional.ResultClass
{
    public abstract class BaseResultError
    {
        protected BaseResultError(string message) => Message = message;
        protected BaseResultError() => Message 
            = GetType().Name.Replace("ResultError","").ToSentenceCase();

        public string Message { get; }
    }
}