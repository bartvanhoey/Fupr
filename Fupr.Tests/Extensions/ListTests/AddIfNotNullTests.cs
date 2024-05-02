using Fupr.Extensions;
using Shouldly;

namespace Fupr.Tests.Extensions.ListTests;

public class AddIfNotNullTests
{
    public class AdjustTests
    {
        [Fact]
        public void Add_If_Not_Null()
        {
            var strings = new List<string>();
            
            strings.AddIfNotNull("test");
            strings.AddIfNotNull(null);
            
            strings.Count.ShouldBe(1);
            
            

        }
    }
}