using Fupr;
using Shouldly;

namespace Fupr.Tests.Extensions.StringExtensionsTests
{
    public class IsValidEmailTests
    {
        [Fact]
        public void Method_IsValidEmail_Should_Return_Correct_Result()
        {
            // Valid email addresses
            "person1@gmail.com".IsValidEmailAddress().ShouldBeTrue();
            "tony@example.com".IsValidEmailAddress().ShouldBeTrue();
            "tony.stark@example.net".IsValidEmailAddress().ShouldBeTrue();
            "tony@example.co.uk".IsValidEmailAddress().ShouldBeTrue();
            "someone@somewhere.com".IsValidEmailAddress().ShouldBeTrue();
            "someone@somewhere.co.uk".IsValidEmailAddress().ShouldBeTrue();
            "someone@somewhere.com".IsValidEmailAddress().ShouldBeTrue();
            "someone+tag@somewhere.net".IsValidEmailAddress().ShouldBeTrue();
            "futureTLD@somewhere.fooo".IsValidEmailAddress().ShouldBeTrue();
            "d.j@server1.proseware.com".IsValidEmailAddress().ShouldBeTrue();
            "david.jones@proseware.com".IsValidEmailAddress().ShouldBeTrue();
            "jones@ms1.proseware.com".IsValidEmailAddress().ShouldBeTrue();
             "j@proseware.com9".IsValidEmailAddress().ShouldBeTrue();
            "js#internal@proseware.com".IsValidEmailAddress().ShouldBeTrue();
            "js*@proseware.com".IsValidEmailAddress().ShouldBeTrue();
             "js@proseware.com9".IsValidEmailAddress().ShouldBeTrue();
             "j.s@server1.proseware.com".IsValidEmailAddress().ShouldBeTrue();
             // "j_9@[129.126.118.1]".IsValidEmailAddress().ShouldBeTrue(); 
             // "j\"s\"@proseware.com".IsValidEmailAddress().ShouldBeTrue();
             // "js@contoso.中国".IsValidEmailAddress().ShouldBeTrue();

            // Invalid email addresses
            "person1@gmail".IsValidEmailAddress().ShouldBeFalse();
            "".IsValidEmailAddress().ShouldBeFalse();
            "person1gmail.com".IsValidEmailAddress().ShouldBeFalse();
            "tony.example.com".IsValidEmailAddress().ShouldBeFalse();
            ".".IsValidEmailAddress().ShouldBeFalse();
            "tony@stark@example.net".IsValidEmailAddress().ShouldBeFalse();
            "tony@.example.co.uk".IsValidEmailAddress().ShouldBeFalse();
            "thomas".IsValidEmailAddress().ShouldBeFalse();
            "thomas@".IsValidEmailAddress().ShouldBeFalse();
            "fdsa@fdsa".IsValidEmailAddress().ShouldBeFalse();
            "fdsa@fdsa.".IsValidEmailAddress().ShouldBeFalse();
            "j.@server1.proseware.com".IsValidEmailAddress().ShouldBeFalse();
             "j..s@proseware.com".IsValidEmailAddress().ShouldBeFalse();
             "js@proseware..com".IsValidEmailAddress().ShouldBeFalse();

            string? test = null;
            test!.IsValidEmailAddress().ShouldBeFalse();
            
            
            
        }
    }
}