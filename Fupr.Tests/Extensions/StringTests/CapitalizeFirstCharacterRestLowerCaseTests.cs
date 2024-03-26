using Shouldly;

namespace Fupr.Tests.Extensions.StringTests;

public class CapitalizeFirstCharacterRestLowerCaseTests
{
    [Theory]
    [InlineData("TOTO", "Toto")]
    [InlineData("toto", "Toto")]
    [InlineData("tOTO", "Toto")]
    public void CapitalizeFirstCharacterRestLowerCase_Should_Return_Correct_Casing(string input, string output) 
        => input.CapitalizeFirstCharacterRestLowerCase().ShouldBe(output);
    
    [Theory]
    [InlineData("TOTO", "tOTO")]
    [InlineData("TOTO", "TOTO")]
    [InlineData("TOTO", "ToTo")]
    
    public void CapitalizeFirstCharacterRestLowerCase_Should_Return_Correct_Casing1(string input, string output) 
        => input.CapitalizeFirstCharacterRestLowerCase().ShouldNotBe(output);
}