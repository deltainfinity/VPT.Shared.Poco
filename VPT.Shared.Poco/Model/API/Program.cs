using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("Program")]
    [PrimaryKey("ProgramId")]
    /// <summary>
    /// Class for defining a ProgramInstance
    /// </summary>
    public class Program : BaseModel
    {
        public Program()
        { }

        public Program(ProgramInstanceDTO source)
             : base(source)
        {
            ProgramId = source.ProgramId;
            ClassroomId = source.ClassroomId;
            Title = source.Title;
            StartDate = source.StartDate;
            EndDate = source.EndDate;
            SessionStartTime = source.SessionStartTime;
            SessionEndTime = source.SessionEndTime;
            Sunday = source.Sunday;
            Monday = source.Monday;
            Tuesday = source.Tuesday;
            Wednesday = source.Wednesday;
            Thursday = source.Thursday;
            Friday = source.Friday;
            Saturday = source.Saturday;
            NumberofSeats = source.NumberofSeats;
            Address = source.Address;
            City = source.City;
            State = source.State;
            Zip = source.Zip;
            FacilitatorID = source.FacilitatorID;
            ParentProgramID = source.ParentProgramID;
            FacilityID = source.FacilityID;
            IsSORProgram = source.IsSORProgram;
            ReferToOrganizationID = source.ReferToOrganizationID;
        }

        public int ProgramId { get; set; }

        public int ClassroomId { get; set; }

        public string Title { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string SessionStartTime { get; set; }

        public string SessionEndTime { get; set; }

        public bool Sunday { get; set; }

        public bool Monday { get; set; }

        public bool Tuesday { get; set; }

        public bool Wednesday { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        public bool Saturday { get; set; }

        public int NumberofSeats { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int FacilitatorID { get; set; }

        public string Zip { get; set; }

        public int ParentProgramID { get; set; }

        //Adding OrganizationID for SearchEngineData
        [ResultColumn]
        public int OrganizationID { get; set; }

        public int FacilityID { get; set; }

        //For Count of SubjectAssigned Seats
        [ResultColumn]
        public int AssignedCount { get; set; }

        //Parent Program Name
        [ResultColumn]
        public string ParentProgramName { get; set; }

        [ResultColumn]
        public int PlatformID { get; set; }
        public bool IsSORProgram { get; set; }
        [ResultColumn]
        public int SubjectProgramID { get; set; }
        public string ProgramInstanceExternalId { get; set; }
        public int ReferToOrganizationID { get; set; }
    }
}
