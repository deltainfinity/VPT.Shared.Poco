using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Integration
{
    public class CustomField
    {
        public CustomField()
        {

        }

        public string DataType { get; set; }
        public string FieldName { get; set; }
        public List<string> ListOfValues { get; set; }
        public bool Required { get; set; }
        public string Value { get; set; }
    }
}