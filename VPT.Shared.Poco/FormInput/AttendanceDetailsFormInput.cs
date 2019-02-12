using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.FormInput
{
    public class AttendanceDetailsFormInput
    {

        public AttendanceDetailsFormInput()

        {
        }


        public AttendanceDetailsFormInput(SORProgramAttendance attendance,List<Program> programList, int subjectUserID, int parentprogramID)
        {
            SubjectUserID = subjectUserID;
            ParentProgramID = parentprogramID;
            if (DateTime.TryParse(attendance.DateAttended, out DateTime dateAttended))
            {
                attendanceDate = dateAttended;
            }
            AttendanceStatus = 0; // The field is not important as we are using this model to check whether the subject has completed the required number of sessions
            ProgramID = programList.FirstOrDefault().ProgramId;
            SubjectUserID = subjectUserID;
            Note = string.Empty;
            BehaviorRating = 0;
            RecommendRetake = false;
        }
        /// <summary>
        /// The person ID of the subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }
        /// <summary>
        /// The Id of program Instance
        /// </summary>
        [JsonProperty("programID")]
        public int ProgramID { get; set; }
        /// <summary>
        /// Parent Program ID
        /// </summary>
        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }
        /// <summary>
        /// The date of attendance 
        /// </summary>
        [JsonProperty("attendanceDate")]
        public DateTime attendanceDate { get; set; }
        /// <summary>
        /// The subject is present or not
        /// </summary>
        [JsonProperty("attendanceStatus")]
        public int AttendanceStatus { get; set; }
        /// <summary>
        /// Note on subject
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }
        /// <summary>
        /// Behavior Rating of subject
        /// </summary>
        [JsonProperty("behaviorRating")]
        public int BehaviorRating { get; set; }
        /// <summary>
        /// Recommend Retake of subject
        /// </summary>
        [JsonProperty("recommendRetake")]
        public bool RecommendRetake { get; set; }

        /// <summary>
        /// Subject Program ID
        /// </summary>
        [JsonProperty("subjectProgramID")]
        public int SubjectProgramID { get; set; }

    }
}
