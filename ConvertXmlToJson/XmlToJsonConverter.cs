using Newtonsoft.Json;
using System.Xml;

namespace ConvertXmlToJson
{
    public interface IXmlToJsonConverter
    {
        string ConvertXmlToJson(string value);
        T ConvertXmlTo<T>(string value);
    }

    public class XmlToJsonConverter : IXmlToJsonConverter
    {
        public string ConvertXmlToJson(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;

            var doc = new XmlDocument();
            doc.LoadXml(value);

            return JsonConvert.SerializeXmlNode(doc);
        }

        public T ConvertXmlTo<T>(string value)
        {
            var jsonString = ConvertXmlToJson(value);

            return string.IsNullOrWhiteSpace(jsonString)
                ? default
                : JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
