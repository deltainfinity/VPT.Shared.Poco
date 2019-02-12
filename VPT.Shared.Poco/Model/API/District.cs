namespace VPT.Shared.Poco.Model.API
{
    public class District : BaseModel
    {
        public District()
        { }

        /// <summary>
        /// The DistrictID of the Districts look up
        /// </summary>
        public int DistrictID { get; set; }
        
        /// <summary>
        /// The District Code
        /// </summary>
        public string DistrictCode { get; set; }

        /// <summary>
        /// Description/ Name of districts
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The primary key of the organization
        /// </summary>
        public int OrganizationID { get; set; }
    }
}
