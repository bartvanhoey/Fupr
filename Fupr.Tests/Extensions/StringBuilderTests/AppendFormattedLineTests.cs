using System.Text;
using Shouldly;

namespace Fupr.Tests.Extensions.StringBuilderTests
{
    public class AppendFormattedLineTests
    {
        [Fact]
        public void AppendFormattedLine_Should_Apply_Format_And_AppendLin_At_Once()
        {
            var firstName = "John";
            var lastName = "Smith";
            
            var sb = new StringBuilder().AppendFormattedLine("Hello, {0} {1}", firstName,lastName).ToString();
            
            sb.ShouldBe("Hello, John Smith\r\n");
        }
    }
}