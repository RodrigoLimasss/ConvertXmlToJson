using ConvertXmlToJson.Dtos;
using ConvertXmlToJson.Entities;
using System;
using System.Linq;

namespace ConvertXmlToJson
{
    public interface IEmployeeConverter
    {
        EmployeeDto[] ConvertXmlToEmployees(string value);
    }

    public class EmployeeConverter : IEmployeeConverter
    {
        private readonly IXmlToJsonConverter _xmlToJsonConverter;

        public EmployeeConverter(IXmlToJsonConverter xmlToJsonConverter)
        {
            _xmlToJsonConverter = xmlToJsonConverter;
        }

        public EmployeeDto[] ConvertXmlToEmployees(string value)
        {
            var employeeRoot = _xmlToJsonConverter.ConvertXmlTo<EmployeeRoot>(value);

            return employeeRoot?.Employees?.Employee?
                .Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Photo = new Uri(e.Photo.Text)
                }).ToArray();
        }
    }
}
