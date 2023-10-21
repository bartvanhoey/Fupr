using Fupr;
using Shouldly;

namespace Fupr.Tests.Extensions.DictionaryExtensionsTests
{
    public class ToLookupWithDefaultTests
    {
        [Fact]
        public void ToLookupWithDefaultValue_Should_Return_Correct_Item_If_Present()
        {
            var result = new DoctorData().GetDoctorOrDefaultValue(1);

            result.ShouldBe("William Hartnell");
        }
        
        [Fact]
        public void ToLookup_Should_Return_Correct_Item_If_Present()
        {
            var result = new DoctorData().GetDoctor(1);

            result.ShouldBe("William Hartnell");
        }
        
        [Fact]
        public void ToLookup_Should_Return_Default_Value_If_Not_Present()
        {
            var result = new DoctorData().GetDoctor(100);

            result.ShouldBeNull();
        }
        
        [Fact]
        public void Indexer_Should_Return_Correct_Item_If_Present()
        {
            var result = new DoctorData()[1]; //indexer

            result.ShouldBe("William Hartnell");
        }
        
        [Fact]
        public void Indexer_Should_Return_DefaultValue_If_Not_Present()
        {
            var result = new DoctorData()[100]; //indexer

            result.ShouldBe("Unknown Doctor");
        }
        
        [Fact]
        public void Multiple_Indexer_Should_Return_Correct_Doctors()
        {
            var result = new DoctorData()[1,2,3]; //indexer

            var doctors = result.ToList();
            doctors.Count.ShouldBe(3);
            doctors.ShouldContain("William Hartnell");
            doctors.ShouldContain("Patrick Troughton");
            doctors.ShouldContain("Jon Pertwee");
        }
        
        [Fact]
        public void Multiple_Indexer_Should_Return_Unknown_Doctor_If_Not_Present()
        {
            var result = new DoctorData()[1,2,3,100]; //indexer

            var doctors = result.ToList();
            doctors.Count.ShouldBe(4);
            doctors.ShouldContain("William Hartnell");
            doctors.ShouldContain("Patrick Troughton");
            doctors.ShouldContain("Jon Pertwee");
            doctors.ShouldContain("Unknown Doctor");
        }
        
        
        
    }

    public class DoctorData
    {
        public readonly Func<int, string> GetDoctorOrDefaultValue = Doctors.ToLookupWithDefault("Unknown Doctor");
        public readonly Func<int, string?> GetDoctor = Doctors.ToLookup();

        private static readonly Dictionary<int, string> Doctors = new()
        {
            {1, "William Hartnell"},
            {2, "Patrick Troughton"},
            {3, "Jon Pertwee"},
            {4, "Tom Baker"},
            {5, "Peter Davison"},
            {6, "Colin Baker"},
            {7, "Sylvester McCoy"},
            {8, "Paul McGann"},
            {9, "Christopher Eccleston"},
            {10, "David Tennant"},
            {11, "Matt Smith"},
            {12, "Peter Capaldi"},
            {13, "Jodie Whittaker"}
        };

        // Indexer
        public string this[int index] => GetDoctorOrDefaultValue(index);
        
        // Indexer with params array
        public IEnumerable<string> this[params int[] indexes] => indexes.Select(i => GetDoctorOrDefaultValue(i));

    }
    
}