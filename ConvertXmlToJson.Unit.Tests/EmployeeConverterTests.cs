using ConvertXmlToJson.Dtos;
using FluentAssertions;
using System;
using Xunit;

namespace ConvertXmlToJson.Unit.Tests
{
    public class EmployeeConverterTests
    {
        private readonly IEmployeeConverter _sut;

        public EmployeeConverterTests()
        {
            // This could be a mock like: Substitute.For<IXmlToJsonConverter>(); or new Mock<IXmlToJsonConverter>();
            // But would require to build the 'EmployeeRoot' object manually.
            var xmlToJsonConverter = new XmlToJsonConverter();
            _sut = new EmployeeConverter(xmlToJsonConverter);
        }

        [Fact]
        public void GivenAXmlStringReturnAnArrayOfEmployees()
        {
            var employees = _sut.ConvertXmlToEmployees(XmlSource.XmlString);

            employees.Should().NotBeEmpty()
                .And.HaveCount(3)
                .And.BeEquivalentTo<EmployeeDto>(new[]
                {
                    new EmployeeDto
                    {
                        Id = "1",
                        FirstName = "Tom",
                        LastName = "Cruise",
                        Photo = new Uri("https://pbs.twimg.com/profile_images/735509975649378305/B81JwLT7.jpg")
                    },
                    new EmployeeDto
                    {
                        Id = "2",
                        FirstName = "Maria",
                        LastName = "Sharapova",
                        Photo = new Uri("https://pbs.twimg.com/profile_images/3424509849/bfa1b9121afc39d1dcdb53cfc423bf12.jpeg")
                    },
                    new EmployeeDto
                    {
                        Id = "3",
                        FirstName = "James",
                        LastName = "Bond",
                        Photo = new Uri("https://pbs.twimg.com/profile_images/664886718559076352/M00cOLrh.jpg")
                    },
                });
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void GivenAEmptyXmlStringReturnNull(string value)
        {
            var employees = _sut.ConvertXmlToEmployees(value);

            employees.Should().BeNull();
        }
    }
}
