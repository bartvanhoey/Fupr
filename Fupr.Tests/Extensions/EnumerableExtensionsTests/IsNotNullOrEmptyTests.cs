using Fupr.Extensions;
using Shouldly;

namespace Fupr.Tests.Extensions.EnumerableExtensionsTests
{
    public class IsNotNullOrEmptyTests
    {
        [Fact]
        public void IsNotNullOrEmpty_Method_Should_Return_False_If_Empty()
        {
            IEnumerable<string>? sut = null;

            var result = sut.IsNotNullOrEmpty();

            result.ShouldBeFalse();
        }
        
        [Fact]
        public void IsNotNullOrEmpty_Method_Should_Return_True_If_Not_Empty()
        {
            IEnumerable<string> sut = new[] {"Test1", "Test2" };

            var result = sut.IsNotNullOrEmpty();

            result.ShouldBeTrue();
        }
        [Fact]
        public void IsNotNullOrEmpty_Method_Should_Return_False_If_Null()
        {
            IEnumerable<string>? sut = null;

            var result = sut.IsNotNullOrEmpty();

            result.ShouldBeFalse();
        }
        
        
        
    }
}