using Fupr.Extensions;
using Shouldly;

namespace Fupr.Tests.Extensions.FunctionalExtensionsTests
{
    public class DoIfNotNullTests
    {
        [Fact]
        public void DoIfNotNull_Should_Execute_If_Input_Is_Not_Null()
        {
            var person1 = GetPerson(666);

            var result = person1.DoIfNotNull(p => Greet(p?.Name));
            
            result.ShouldBe("Hello Simon");
        }
        
        [Fact]
        public void DoIfNotNull_Should_Not_Execute_If_Input_Is_Null()
        {
            var person1 = GetPerson(111); // null

            var result = person1.DoIfNotNull(p => Greet(p?.Name));
            
            result.ShouldBeNull();
        }
        
        Person? GetPerson(int id) => id == 666 ? new Person { Name = "Simon" } : null;
        
        static string Greet(string? input) => string.IsNullOrWhiteSpace(input) ? "Hello" : $"Hello {input}";
        
        
    }

    public class Person
    {
        public string? Name { get; set; }
        
    }
}