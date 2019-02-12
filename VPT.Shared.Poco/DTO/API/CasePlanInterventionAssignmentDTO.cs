using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
   public class CasePlanInterventionAssignmentDTO
    {

        public CasePlanInterventionAssignmentDTO()
        {

        }
        public CasePlanInterventionAssignmentDTO(SubjectGoalAction subjectGoalAction)
        {
            InterventionEntryID = subjectGoalAction.SubjectGoalActionID;
            GoalEntryID = subjectGoalAction.SubjectGoalActionID;
            CreatedByUserID =Convert.ToInt32( subjectGoalAction.CreatedByUserID);
            DateCreated = subjectGoalAction.DateCreated;
            ResponsiblePersonID = subjectGoalAction.ResponsiblePersonUserID;
            StatusID = subjectGoalAction.Status;
            DateStatusApplied = subjectGoalAction.DateCreated;

        }

        /// <summary>
        /// The ID of the case plan intervention entry in the assessment engine
        /// </summary>
        public int InterventionEntryID { get; set; }

        /// <summary>
        /// The ID of the case plan goal entry this intervention applies to in the assessment engine
        /// </summary>
        public int GoalEntryID { get; set; }

        /// <summary>
        /// The unique ID for the subject in the system of record
        /// </summary>
        public string SubjectExternalID { get; set; }

        /// <summary>
        /// The username of the user that created the intervention entry
        /// </summary>
        public string CreatedByUser { get; set; }

        /// <summary>
        /// The user ID of the user that created the goal entry in the assessment enginer
        /// 
        /// TODO: This is the Assessment Engine LOGON_ID we cannot access the ExternalID for users in Saber right now.
        /// </summary>
        public int CreatedByUserID { get; set; }

        /// <summary>
        /// The date and time the intervention entry was created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The text for the intervention
        /// </summary>
        public string Intervention { get; set; }

        /// <summary>
        /// Type of the intervention
        /// </summary>
        public string InterventionType { get; set; }

        /// <summary>
        /// The status applied to the intervention entry
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The ID of the status
        /// </summary>
        public int StatusID { get; set; }

        /// <summary>
        /// The date and time the current status was applied to the intervention entry
        /// </summary>
        public DateTime DateStatusApplied { get; set; }

        /// <summary>
        /// The person responsible for handling the intervention
        /// </summary>
        public string ResponsiblePerson { get; set; }

        /// <summary>
        /// The ID of the person responsible entry for handling the intervention
        /// </summary>
        public int ResponsiblePersonID { get; set; }
    }
}
