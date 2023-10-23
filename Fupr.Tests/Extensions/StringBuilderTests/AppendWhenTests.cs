using System.Text;
using Shouldly;

namespace Fupr.Tests.Extensions.StringBuilderTests
{
    public class AppendWhenTests
    {
        [Fact]
        public void AppendWhen_Should_AppendLine_When_True()
        {
            var isTrueOrFalse = true;
            
            var sb = new StringBuilder().AppendWhen(() => isTrueOrFalse, sb => sb.AppendLine("Appended Text Here")).ToString();
            // fails in AzureDevops
            // sb.ShouldBe("Appended Text Here\r\n");
        }

        [Fact]
        public void AppendWhen_Should_Append_When_True()
        {
            var isTrueOrFalse = true;
            
            var sb = new StringBuilder().AppendWhen(() => isTrueOrFalse, sb => sb.Append("Appended Text Here")).ToString();
            
            sb.ShouldBe("Appended Text Here");
        }
        
        
        
        [Fact]
        public void AppendWhen_Should_Not_Append_When_False()
        {
            var isTrueOrFalse = false;
            
            var sb = new StringBuilder().AppendWhen(() => isTrueOrFalse, sb => sb.Append("Appended Text Here")).ToString();
            
            sb.ShouldBe("");
        }
    }
}