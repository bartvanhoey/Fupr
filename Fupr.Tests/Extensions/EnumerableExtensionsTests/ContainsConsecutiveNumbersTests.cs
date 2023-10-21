using Fupr;
using Shouldly;

namespace Fupr.Tests.Extensions.EnumerableExtensionsTests
{
    public class ContainsConsecutiveNumbersTests
    {
        [Fact]
        public void ContainsConsecutiveNumbers_Should_Return_True()
        {
            var array = new[] { 1,3,5,15,16,32 };

            var result = array.ContainsConsecutiveNumbers();
            
            result.ShouldBeTrue();
        }
        
        [Fact]
        public void ContainsConsecutiveNumbers_Should_Return_False()
        {
            var array = new[] { 1,3,5,14,16,32 };

            var result = array.ContainsConsecutiveNumbers();
            
            result.ShouldBeFalse();
        }
    }
}