using Newtonsoft.Json;

namespace ConvertXmlToJson.Entities
{
    public class Employees
    {
        [JsonProperty("@version")]
        public string Version { get; set; }
        public Employee[] Employee { get; set; }
    }
}