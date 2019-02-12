using Newtonsoft.Json;
using System;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class CaseNoteDTO : BaseDTO
    {
        public CaseNoteDTO()
        { }

        public CaseNoteDTO(CaseNote source, string agentName = "SYSTEM")
            : base(source)
        {
            NoteID = source.NoteID;
            NoteTypeID = source.NoteType;
            AgentUserID = source.CreatedByUserID;
            SubjectUserID = source.SubjectUserID;
            ProviderID = source.ProviderID.GetValueOrDefault(0);
            ProgramID = source.ProgramID.GetValueOrDefault(0);
            JobID = source.JobID.GetValueOrDefault(0);
            Note = source.Note;
            AgentName = agentName;
            SubjectGoalID = source.SubjectGoalID;
            CreatedByUserID = source.CreatedByUserID;
            VisibleDate = source.VisibleDate;
        }

        /// <summary>
        /// The ID of the Case Note
        /// </summary>
        [JsonProperty("noteID")]
        public int NoteID { get; set; }

        /// <summary>
        /// The type of case note (ID Form). See <see cref="Enums.NoteType"/>
        /// </summary>
        [JsonProperty("noteTypeID")]
        public int NoteTypeID { get; set; }

        /// <summary>
        /// The type of case note (Name). See <see cref="Enums.NoteType"/>
        /// </summary>
        [JsonProperty("noteTypeName")]
        public string NoteTypeName => NoteTypeConstants.GetByEnum(NoteTypeID);

        /// <summary>
        /// The person ID of the agent that created this note
        /// </summary>
        [JsonProperty("agentUserID")]
        public string AgentUserID { get; set; }

        /// <summary>
        /// The person ID of the Subject this note applies too
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The ID of the Provider this note relates too
        /// </summary>
        [JsonProperty("providerID")]
        public int ProviderID { get; set; }

        /// <summary>
        /// The ID of the Program this note relates too
        /// </summary>
        [JsonProperty("programID")]
        public int ProgramID { get; set; }

        /// <summary>
        /// The ID of the Job this note relates too
        /// </summary>
        [JsonProperty("jobID")]
        public int JobID { get; set; }

        /// <summary>
        /// The note itself
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The name of agent who created the case note
        /// </summary>
        [JsonProperty("agentName")]
        public string AgentName { get; set; }

        [JsonProperty("subjectGoalID")]
        public int? SubjectGoalID { get; set; }
        /// <summary>
        /// The person ID of the user that created
        /// </summary>
        [JsonProperty("createdByUserID")]
        public string CreatedByUserID { get; set; }

        [JsonProperty("visibleDate")]
        public DateTime VisibleDate { get; set; }

        [JsonProperty("caseNoteLabel")]
        public string CaseNoteLabel { get; set; }
    }
}
