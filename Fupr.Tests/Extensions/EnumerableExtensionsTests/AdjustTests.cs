using Fupr.Extensions;
using Shouldly;

namespace Fupr.Tests.Extensions.EnumerableExtensionsTests
{
    public class AdjustTests
    {
        [Fact]
        public void Adjust_Should_Return_Correct_Value1()
        {
            var arrayA = new[] { 'a', 'b', 'c', 'd' };

            var result = arrayA.Adjust((x, i) => i == 2, 'z' ).ToArray();
            
            result[2].ShouldBe('z');
        }
        
        [Fact]
        public void Adjust_Should_Return_Correct_Value2()
        {
            var arrayA = new[] { 'a', 'b', 'c', 'd' };

            var result = arrayA.Adjust((x, i) => x == 'c', 'z' ).ToArray();
            
            result[2].ShouldBe('z');
        }
    }
}