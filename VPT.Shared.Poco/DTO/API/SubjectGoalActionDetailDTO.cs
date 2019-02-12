using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class SubjectGoalActionDetailDTO : BaseDTO
    {
        public SubjectGoalActionDetailDTO()
        { }

        /// <summary>
        /// Copy constructor to populate the classe
        /// </summary>

        public SubjectGoalActionDetailDTO(SubjectGoalAction source, IEnumerable<ActionStep> actionsLookup, int SubjectUserID, IEnumerable<Program> programList, IEnumerable<SubjectProgramStatus> programStatuses, string responsiblePersonName, IEnumerable<SubjectProgramMapping> subjectprogramList = null)
        {
            SubjectGoalActionID = source.SubjectGoalActionID;
            ActionStepID = source.ActionStepID;
            int? subjectProgramID = null;

            if (source.SubjectProgramID.HasValue)
            {
                ProgramID = subjectprogramList.Where(x => x.SubjectProgramID.Equals(source.SubjectProgramID.Value)).SingleOrDefault().ProgramId;
                subjectProgramID = subjectprogramList.Where(x => x.SubjectProgramID.Equals(source.SubjectProgramID.Value)).SingleOrDefault().SubjectProgramID;
            }
           
            ActionStepName = ProgramID.HasValue ? programList.Where(x => x.ProgramId.Equals(ProgramID.Value)).SingleOrDefault().Title : actionsLookup.Where(x => x.ActionStepID.Equals(ActionStepID)).SingleOrDefault().Name;
            ResponsiblePersonUserID = source.ResponsiblePersonUserID;
            ResponsiblePersonName = responsiblePersonName;
            DateCreated = source.DateCreated;
            TerminatedReason = source.TerminatedReason;
            OnHoldReason = source.OnHoldReason;
            SubjectGoalID = source.SubjectGoalID;
            RequestInstanceID = source.RequestInstanceID;
            if (subjectprogramList != null && subjectprogramList.Count() > 0 && subjectProgramID != null)
            {

                SubjectProgramMapping subjectProgramMapping = subjectprogramList.Where(x => x.SubjectProgramID.Equals(subjectProgramID.Value)).SingleOrDefault();
                var programStatus = programStatuses.Where(z => z.ProgramStatusID == subjectProgramMapping.ProgramStatus).Select(z => z.Name).FirstOrDefault();
                StartDate = (subjectProgramID.HasValue && subjectProgramMapping != null) ? subjectProgramMapping.DateStarted : source.StartDate; //subjectProgramMapping will be null as there will not be any entry in SubjectProgram for waitlisted program assignments
                EndDate = (subjectProgramID.HasValue && subjectProgramMapping != null) ? subjectProgramMapping.DateEnded : source.EndDate;
                Status = (subjectProgramID.HasValue  && subjectProgramMapping != null) ? programStatus : SubjectGoalConstants.GetByEnum(source.Status);
            }
            else
            {
                StartDate = source.StartDate;
                EndDate =  source.EndDate;
                Status = SubjectGoalConstants.GetByEnum(source.Status);
            }
        }

        [JsonProperty("subjectGoalActionID")]
        public int SubjectGoalActionID { get; set; }

        [JsonProperty("actionStepID")]
        public int ActionStepID { get; set; }

        [JsonProperty("actionStepName")]
        public string ActionStepName { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty("responsiblePersonUserID")]
        public int ResponsiblePersonUserID { get; set; }

        [JsonProperty("responsiblePersonName")]
        public string ResponsiblePersonName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("programID")]
        public int? ProgramID { get; set; }

        /// <summary>
        /// The Reason of Terminated
        /// </summary>
        [JsonProperty("terminatedReason")]
        public string TerminatedReason { get; set; }

        /// <summary>
        /// The Reason of On Hold
        /// </summary>
        [JsonProperty("onHoldReason")]
        public string OnHoldReason { get; set; }
        
        /// <summary>
        /// For recommended program set to true.
        /// </summary>
        [JsonProperty("isRecommended")]
        public bool Isrecommended = false;

        /// <summary>
        /// Parent Program ID of recommended program
        /// </summary>
        //[JsonProperty("parentProgramID")]
        //public int ParentProgramID { get; set; }

        [JsonProperty("subjectGoalID")]
        public int SubjectGoalID { get; set; }

        [JsonProperty("requestInstanceId")]
        public int? RequestInstanceID { get; set; }
        

    }
}
