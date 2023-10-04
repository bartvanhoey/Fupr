using Fupr.Extensions;
using Shouldly;

namespace Fupr.Tests.Extensions.StringExtensionsTests
{
    public class ParserTests
    {

        private readonly string _emails =
            "Login email;Identifier;First name;Last name\nlaura@example.com;2070;Laura;Grey\ncraig@example.com;4081;Craig;Johnson\nmary@example.com;9346;Mary;Jenkins\njamie@example.com;5079;Jamie;Smith";
        
        [Fact]
        public void Parser_Method_Should_Correctly_Read_Content_Of_A_Csv_File()
        {
            var sut = _emails;

            var result = sut.Parser("\n", ";");

            var lines = result.ToList();
            lines.Count.ShouldBe(5);

            var fields = lines[1].ToList();
            
            fields[0].ShouldBe("laura@example.com");
        }
        
    }
}