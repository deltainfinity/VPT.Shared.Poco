using System;
using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProviderDTO : BaseDTO
    {
        public ProviderDTO()
        { }

        public ProviderDTO(Provider source)
            : base(source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            Description = source.Description;
            ProviderID = source.ProviderID;
            ExternalID = source.ExternalID;
            Name = source.Name;
            TypeID = source.Type;
            ParentID = source.ParentID;
            Website = source.Website;
        }

        [JsonProperty("providerID")]
        public int ProviderID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typeID")]
        public int TypeID { get; set; }

        [JsonProperty("typeName")]
        public string TypeName => ProviderTypeConstants.GetByEnum(TypeID);

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("externalID")]
        public string ExternalID { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("parentId")]
        public int ParentID { get; set; }

        //Adding OrganizationID for SearchEngineData
        public int OrganizationID { get; set; }
    }
}
