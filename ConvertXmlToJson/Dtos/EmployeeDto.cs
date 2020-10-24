using System;

namespace ConvertXmlToJson.Dtos
{
    public class EmployeeDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri Photo { get; set; }
    }
}