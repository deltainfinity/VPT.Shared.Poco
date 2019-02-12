using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    /// <summary>
    /// DTO object for <see cref="VIDSSubject"/>
    /// </summary>
    public class VIDSSubjectDTO 
    {
        public VIDSSubjectDTO()
        { }

        public VIDSSubjectDTO(VIDSSubject source)
        {
            VIDSUserID = source.VIDSUserID;
            FirstEntryFlag = source.FirstEntryFlag;
            IsAssessmentCompleted = source.IsAssessmentCompleted;
        }

        /// <summary>
        /// The VIDSUserID
        /// </summary>
        [JsonProperty("vIDSUserID")]
        public string VIDSUserID { get; set; }

        /// <summary>
        /// The FirstEntryFlag
        /// </summary>
        [JsonProperty("firstEntryFlag")]
        public bool FirstEntryFlag { get; set; }

        /// <summary>
        /// The IsAssessmentCompleted
        /// </summary>
        [JsonProperty("isAssessmentCompleted")]
        public bool IsAssessmentCompleted { get; set; }
    }
}
