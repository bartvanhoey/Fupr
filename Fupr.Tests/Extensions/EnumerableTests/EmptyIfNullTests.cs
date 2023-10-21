using Shouldly;

namespace Fupr.Tests.Extensions.EnumerableTests
{
    public class EmptyIfNullTests
    {
        [Fact]
        public void EmptyIfNull_Method_Should_Return_Empty_Enumerable()
        {

            IEnumerable<string>? enumerable = null;

            var result = enumerable.EmptyIfNull();

            result.ShouldBe(Enumerable.Empty<string>());
        }
    }
}