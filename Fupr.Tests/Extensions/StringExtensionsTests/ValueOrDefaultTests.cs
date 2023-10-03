using Fupr.Extensions;
using Shouldly;

namespace Fupr.Tests.StringExtensions
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
            const string sut = "John";

            var result = sut.ValueOrDefault("");

            result.ShouldBe("John");
        }

        [Fact]
        public void ValueOrDefault_With_John_Default_Value_On_An_John_String_Should_Return_John()
        {
            const string sut = "John";

            var result = sut.ValueOrDefault("John");

            result.ShouldBe("John");
        }


    }
}