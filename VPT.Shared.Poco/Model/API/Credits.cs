using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("Credits")]
    [PrimaryKey("CreditsID")]
    public class Credits : BaseModel
    {
        public Credits()
        { }

        public Credits(CreditsDTO source)
            : base(source)
        {
            CreditsID = source.CreditsID;
            Name = source.Name;
        }

        /// <summary>
        /// The ID of the Credit table
        /// </summary>
        public int CreditsID { get; set; }

        /// <summary>
        /// The option in the dropdown
        /// </summary>
        public string Name { get; set; }
    }
}
