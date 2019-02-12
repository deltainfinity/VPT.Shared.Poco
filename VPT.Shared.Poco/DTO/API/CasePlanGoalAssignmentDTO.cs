using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
   public class CasePlanGoalAssignmentDTO
    {
        public CasePlanGoalAssignmentDTO()
        {
        }
        public CasePlanGoalAssignmentDTO(SubjectGoal subjectGoal)
        {
            GoalEntryID = subjectGoal.GoalID;
            CreatedByUserID = Convert.ToInt32(subjectGoal.CreatedByUserID);
            DateCreated = subjectGoal.DateCreated;
            DateStatusApplied = subjectGoal.DateCreated;
        }

        /// <summary>
        /// The ID of the case plan goal entry  in the assessment engine
        /// </summary>
        public int GoalEntryID { get; set; }
        /// <summary>
        /// The unique ID for the subject in the system of record
        /// </summary>
        public string SubjectExternalID { get; set; }
        /// <summary>
        /// The username of the user that created the goal entry
        /// </summary>
        public string CreatedByUser { get; set; }
        /// <summary>
        /// The user ID of the user that created the goal entry in the assessment engine
        /// 
        /// TODO: This is the Assessment Engine LOGON_ID we cannot access the ExternalID for users in Saber right now.
        /// </summary>
        public int CreatedByUserID { get; set; }
        /// <summary>
        /// The date and time the goal entry was created
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// The text for the Goal
        /// </summary>
        public string Goal { get; set; }
        /// <summary>
        /// The status applied to the goal entry
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// The ID of the status
        /// </summary>
        public int StatusID { get; set; }
        /// <summary>
        /// The date and time the current status was applied to the goal entry
        /// </summary>
        public DateTime DateStatusApplied { get; set; }
        /// <summary>
        /// EBP Domain the goal applies to
        /// </summary>
        public string NeedDomain { get; set; }
    }
}
   
