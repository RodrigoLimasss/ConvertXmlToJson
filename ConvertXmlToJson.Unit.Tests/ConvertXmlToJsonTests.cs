using ConvertXmlToJson.Entities;
using FluentAssertions;
using Xunit;

namespace ConvertXmlToJson.Unit.Tests
{
    public class ConvertXmlToJsonTests
    {
        private readonly IXmlToJsonConverter _sut;

        public ConvertXmlToJsonTests()
        {
            _sut = new XmlToJsonConverter();
        }

        [Fact]
        public void GivenAXmlStringReturnAJsonString()
        {
            var result = _sut.ConvertXmlToJson(XmlSource.XmlString);

            result.Should().NotBeNullOrWhiteSpace();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void GivenAEmptyXmlStringReturnAEmptyString(string value)
        {
            var result = _sut.ConvertXmlToJson(value);

            result.Should().BeEmpty();
        }

        [Fact]
        public void GivenAXmlStringReturnEmployeeObject()
        {
            var employees = _sut.ConvertXmlTo<EmployeeRoot>(XmlSource.XmlString);

            employees.Should().NotBeNull();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void GivenAEmptyXmlStringReturnNull(string value)
        {
            var employees = _sut.ConvertXmlTo<EmployeeRoot>(value);

            employees.Should().BeNull();
        }
    }
}
