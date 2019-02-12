using NPoco;
using System;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("CaseNote")]
    [PrimaryKey("NoteID")]
    public class CaseNote : BaseModel
    {
        public CaseNote()
        { }

        public CaseNote(CaseNoteDTO source)
            : base(source)
        {
            NoteID = source.NoteID;
            NoteType = source.NoteTypeID;
            SubjectUserID = source.SubjectUserID;
            ProviderID = source.ProviderID > 0 ? (int?)source.ProviderID : null;
            ProgramID = source.ProgramID > 0 ? (int?)source.ProgramID : null;
            JobID = source.JobID > 0 ? (int?)source.JobID : null;
            Note = source.Note;
            SubjectGoalID = source.SubjectGoalID > 0 ? (int?)source.SubjectGoalID : null;
            VisibleDate = source.VisibleDate;
        }

        /// <summary>
        /// The ID of the Case Note
        /// </summary>
        public int NoteID { get; set; }

        /// <summary>
        /// The type of case note. See <see cref="Enums.NoteType"/>
        /// </summary>
        public int NoteType { get; set; }

        /// <summary>
        /// The person ID of the Subject this note applies too
        /// </summary>
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The ID of the Provider this note relates too
        /// </summary>
        public int? ProviderID { get; set; }

        /// <summary>
        /// The ID of the Program this note relates too
        /// </summary>
        public int? ProgramID { get; set; }

        /// <summary>
        /// The ID of the Job this note relates too
        /// </summary>
        public int? JobID { get; set; }

        /// <summary>
        /// The note itself
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// The ID of subject goal
        /// </summary>
        public int? SubjectGoalID { get; set; }

        /// <summary>
        /// The visible date
        /// </summary>
        public DateTime VisibleDate { get; set; }

        [ResultColumn]
        public string NoteTypeName => NoteTypeConstants.GetByEnum(NoteType);
    }
}
