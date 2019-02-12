using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    /// <summary>
    ///Role to Person Mapping input data
    /// </summary>
    public class EditUserRoleMappingFormInput
    {
        /// <summary>
        /// The edited group ID
        /// </summary>
        [JsonProperty("groupID")]
        public int GroupID { get; set; }

        /// <summary>
        /// The person ID of edited user 
        /// </summary>
        [JsonProperty("personID")]
        public int PersonID { get; set; }
       
    }
}
