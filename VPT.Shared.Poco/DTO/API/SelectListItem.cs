using Newtonsoft.Json;

namespace VPT.Shared.Poco.DTO.API
{
    public class SelectListItem
    {
        public SelectListItem()
        { }

        /// <summary>
        /// Copy constructor to populate the classe
        /// </summary>
        public SelectListItem(int value, string name, bool selected)
        {
            Value = value;
            Name = name;
            Selected = selected;
        }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }
    }
}
