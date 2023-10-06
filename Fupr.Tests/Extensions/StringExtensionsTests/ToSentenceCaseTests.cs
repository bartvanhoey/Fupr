using Fupr.Extensions;
using Fupr.Functional.ResultClass;
using Shouldly;

namespace Fupr.Tests.Extensions.StringExtensionsTests
{
    public class ToSentenceCaseTests
    {
        [Fact]
        public void ToSentenceCase_Method_Should_Return_Correct_Sentence_Case()
        {
            "HelloWorld".ToSentenceCase().ShouldBe("Hello world");
            "ArgumentOutOfRangeException".ToSentenceCase().ShouldBe("Argument out of range exception");
        }
        
        [Fact]
        public void ToSentenceCase_Method_Should_Return_Correct_Sentence_Case2()
        {
            var error = new AnotherCustomErrorMessageResultError();
            error.Message.ShouldBe("Another custom error message");
        }
    }
}