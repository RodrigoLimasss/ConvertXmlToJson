using Newtonsoft.Json;

namespace ConvertXmlToJson.Entities
{
    public class Photo
    {
        [JsonProperty("@size")]
        public string Size { get; set; }
        [JsonProperty("#text")]
        public string Text { get; set; }
    }
}