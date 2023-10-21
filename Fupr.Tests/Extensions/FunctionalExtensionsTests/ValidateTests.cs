using Fupr;
using Shouldly;

namespace Fupr.Tests.Extensions.FunctionalExtensionsTests
{
    public class ValidateTests
    {
        
        [Fact]
        public void Validate_Should_Return_False_On_Empty_String()
        {
            var sut = string.Empty;

            var result = sut.Validate(x => !string.IsNullOrWhiteSpace(x), x => x.Length > 5, x => x.Length < 20, x => !x.Contains("Justin Bieber"));

            result.ShouldBeFalse();
        }
        
        [Fact]
        public void Validate_Should_Return_False_On_JustinBieber()
        {
            var sut = "Justin Bieber";

            var result = sut.Validate(x => !string.IsNullOrWhiteSpace(x), x => x.Length > 5, x => x.Length < 20, x => !x.Contains("Justin Bieber"));

            result.ShouldBeFalse();
        }
        
        [Fact]
        public void Validate_Should_Return_False_On_String_Len_5()
        {
            var sut = "Justi";

            var result = sut.Validate(x => !string.IsNullOrWhiteSpace(x), x => x.Length > 5, x => x.Length < 20, x => !x.Contains("Justin Bieber"));

            result.ShouldBeFalse();
        }
        
        [Fact]
        public void Validate_Should_Return_False_On_String_Len_20()
        {
            var sut = "JustinTimberlanddddd";

            var result = sut.Validate(x => !string.IsNullOrWhiteSpace(x), x => x.Length > 5, x => x.Length < 20, x => !x.Contains("Justin Bieber"));

            result.ShouldBeFalse();
        }
        
        [Fact]
        public void Validate_Should_Return_True_On_String_Len_Less_20()
        {
            var sut = "JustinTimberlandddd";

            var result = sut.Validate(x => !string.IsNullOrWhiteSpace(x), x => x.Length > 5, x => x.Length < 20, x => !x.Contains("Justin Bieber"));

            result.ShouldBeTrue();
        }
        
        [Fact]
        public void Validate_Should_Return_True_On_String_Greater_Len_5()
        {
            var sut = "Justin";

            var result = sut.Validate(x => !string.IsNullOrWhiteSpace(x), x => x.Length > 5, x => x.Length < 20, x => !x.Contains("Justin Bieber"));

            result.ShouldBeTrue();
        }

    }
}