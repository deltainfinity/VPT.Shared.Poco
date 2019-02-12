using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for defining a Provider or Institution
    /// </summary>
    [PrimaryKey("ProviderID")]
    [TableName("Provider")]
    public class Provider : BaseModel
    {
        public Provider()
        { }

        public Provider(ProviderDTO source)
            : base(source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            Description = source.Description;
            ProviderID = source.ProviderID;
            ExternalID = source.ExternalID;
            Name = source.Name;
            Type = source.TypeID;
            ParentID = source.ParentID;
            Website = source.Website;
        }

        public int ProviderID { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public string Description { get; set; }

        public string Website { get; set; }

        public string ExternalID { get; set; }

        public int ParentID { get; set; }

        [ResultColumn]
        public int OrganizationID { get; set; }
    }
}
