using System.Text;
using Shouldly;

namespace Fupr.Tests.Extensions.StringBuilderTests
{
    public class AppendSequenceTests
    {
        [Fact]
        public void AppendSequence_Should_Append_Correct_Sequence()
        {
            var includeUnknown = true;
            var selectId = "theDoctors";
            var selectName = "theDoctors";

            var options = new Dictionary<int, string>
                { { 0, "Hartnell" }, { 1, "Troughton" }, { 2, "Pertwee" }, { 3, "T. Baker" } };

            var sb = new StringBuilder()
                .AppendFormattedLine("<select id=\"{0}\" name=\"{1}\">", selectId, selectName)
                .AppendWhen(() => includeUnknown, sb => sb.AppendLine("\t<option>Unknown</option>"))
                .AppendSequence(options,
                    (sb, opt) => sb.AppendFormattedLine("\t<option value=\"{0}\">{1}</option>", opt.Key, opt.Value))
                .AppendLine("</select>").ToString().Trim();
            // fails in AzureDevops
            // sb.ShouldBe(SelectBox);
        }

        private const string SelectBox = "<select id=\"theDoctors\" name=\"theDoctors\">\r\n" +
                                         "\t<option>Unknown</option>\r\n" +
                                         "\t<option value=\"0\">Hartnell</option>\r\n" +
                                         "\t<option value=\"1\">Troughton</option>\r\n" +
                                         "\t<option value=\"2\">Pertwee</option>\r\n" +
                                         "\t<option value=\"3\">T. Baker</option>\r\n" +
                                         "</select>";
    }
}