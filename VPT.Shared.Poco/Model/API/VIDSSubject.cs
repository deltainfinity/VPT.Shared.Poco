using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class defining a Tag in VPT
    /// </summary>
    ///
    [TableName("VIDSSubjectProperties")]
    [PrimaryKey("VIDSUserID",AutoIncrement =false)]
    public class VIDSSubject
    {
        public VIDSSubject()
        { }

        public VIDSSubject(VIDSSubjectDTO source)
        {
            VIDSUserID = source.VIDSUserID;
            FirstEntryFlag = source.FirstEntryFlag;
            IsAssessmentCompleted = source.IsAssessmentCompleted;
        }

        /// <summary>
        /// The VIDSUserID
        /// </summary>
        public string VIDSUserID { get; set; }

        /// <summary>
        /// The FirstEntryFlag
        /// </summary>
        public bool FirstEntryFlag { get; set; }

        /// <summary>
        /// The IsAssessmentCompleted
        /// </summary>
        public bool IsAssessmentCompleted { get; set; }
    }
}
