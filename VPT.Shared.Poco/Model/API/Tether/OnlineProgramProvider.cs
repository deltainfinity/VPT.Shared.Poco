using NPoco;

namespace VPT.Shared.Poco.Model.API.Tether
{
    /// <summary>
    /// OnlineProgramProvider model
    /// </summary>
    [TableName("OnlineProgramProvider")]
    [PrimaryKey("OnlineProgramProviderID")]
    public class OnlineProgramProvider : BaseModel
    {
        /// <summary>
        /// Unique identifier for the OnlineProgramProvider
        /// </summary>
        public int OnlineProgramProviderId { get; set; }
        /// <summary>
        /// The ProgramCatalog ID of the program that the is  being provided
        /// </summary>
        public int ProgramCatalogId { get; set; }
        public int OrganizationId { get; set; }
        public int FacilityId { get; set; }
        public string Url { get; set; }
        public string LmsSystemType { get; set; }
    }
}
