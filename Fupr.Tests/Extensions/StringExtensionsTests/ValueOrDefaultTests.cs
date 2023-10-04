using Fupr.Extensions;
using Shouldly;

namespace Fupr.Tests.Extensions.StringExtensionsTests
{
    public class ValueOrDefaultTests
    {
        [Fact]
        public void ValueOrDefault_With_Empty_String_Default_Value_On_An_Empty_String_Should_Return_An_Empty_String()
        {
            var sut = string.Empty;

            var result = sut.ValueOrDefault("");

            result.ShouldBe("");
        }

        [Fact]
        public void ValueOrDefault_With_John_Default_Value_On_An_Empty_String_Should_Return_John()
        {
            var sut = string.Empty;

            var result = sut.ValueOrDefault("John");

            result.ShouldBe("John");
        }

        [Fact]
        public void ValueOrDefault_With_John_Default_Value_On_John_String_Should_Return_John()
        {
            const string expected = "John";
            const string sut = expected;

            var result = sut.ValueOrDefault("");

            result.ShouldBe(expected);
        }

        [Fact]
        public void ValueOrDefault_With_John_Default_Value_On_An_John_String_Should_Return_John()
        {
            const string sut = "John";

            var result = sut.ValueOrDefault("John");

            result.ShouldBe("John");
        }

        [Fact]
        public void ValueOrDefault_With_5_Default_Value_On_An_6_Input_Should_Return_John()
        {
            const string sut = "5" ;

            var result = sut.ValueOrDefault(4);

            result.ShouldBe(5);
        }
        
        
        [Fact]
        public void ValueOrDefault_With_10_Default_Value_On_An_Empty_String_Should_Return_10()
        {
            var sut = string.Empty;

            var result = sut.ValueOrDefault(10);

            result.ShouldBe(10);
        }
    }
}