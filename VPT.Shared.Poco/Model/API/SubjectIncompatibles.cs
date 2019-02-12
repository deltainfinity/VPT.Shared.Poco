using NPoco;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("SubjectIncompatibles")]
    [PrimaryKey("SubjectIncompatiblesID")]
    public class SubjectIncompatibles : OverrideTreatmentPathwayGoalActionStepBaseModel
    {
        public SubjectIncompatibles()
        { }

        /// <summary>
        /// The ID of the Subject Incompatibles ID 
        /// </summary>
        public int SubjectIncompatiblesID { get; set; }

        /// <summary>
        /// The SubjectUserID
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The Incompatible Offender ID
        /// </summary>
        public string IncompatibleOffenderID { get; set; }

        /// <summary>
        /// The Incompatible First Name
        /// </summary>
        public string IncompatibleFirstName { get; set; }

        /// <summary>
        /// The Incompatible Last Name
        /// </summary>
        public string IncompatibleLastName { get; set; }
    }
}

