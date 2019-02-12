using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.Constants;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramDTO : BaseDTO
    {
        public ProgramDTO()
        { }


        public ProgramDTO(Program source, List<Program> assignedPrograms, string location, List<PersonDetailsDTO> facilitatorName) : this(source)
        {
            int assignedCount = assignedPrograms.Where(x => x.ProgramId == source.ProgramId).Count() > 0 ? assignedPrograms.Where(x => x.ProgramId == source.ProgramId).FirstOrDefault().AssignedCount : 0;
            OpenSeats = assignedCount > 0 ? ((source.NumberofSeats - assignedCount) >= 0 ? (source.NumberofSeats - assignedCount) : 0) : source.NumberofSeats;
            Location = location == null ? ApplicationConstants.NotApplicable : location;
            if (source.FacilitatorID != null)
                FacilitatorName = (facilitatorName == null || facilitatorName.Where(x => x.PersonID.Equals(source.FacilitatorID)).Count() == 0) ? null : facilitatorName.Where(x => x.PersonID.Equals(source.FacilitatorID)).Single().FullNameFirstNameFirstFormat;
            else
            {
                FacilitatorName = String.Empty;
            }
        }

        public ProgramDTO(Program source)
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

            //For Count of SubjectAssigned Seats
            // OpenSeats = source.OpenSeats;
            //Parent Program Name
            ParentProgramName = source.ParentProgramName;
            PlatformID = source.PlatformID;
            ProgramInstanceExternalId = source.ProgramInstanceExternalId;

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
        public int FacilityID { get; set; }

        public string StartDateFormatted { get; set; }

        public string EndDateFormatted { get; set; }

        //Adding OrganizationID for SearchEngineData
        public int OrganizationID { get; set; }

        //For Count of SubjectAssigned Seats
        public int OpenSeats { get; set; }

        //Parent Program Name
        public string ParentProgramName { get; set; }


        //TODO: VERIFY FOLLOWING FIELDS
        public int SubjectsAssigned { get; set; }

        public List<string> PrimaryTags { get; set; }

        public List<string> SecondaryTags { get; set; }

        public List<string> PrimaryRiskTags { get; set; }

        public List<string> FacilityIds { get; set; }
        public int PlatformID { get; set; }

        public string Location { get; set; }

        public string FacilitatorName { get; set; }

        public string PlatformName => PlatformTypeConstants.GetByEnum(PlatformID);
        public string SiteID { get; set; }
        public string ProgramExternalId { get; set; }
        public bool IsSORProgram { get; set; }
        public string ProgramInstanceExternalId { get; set; }
        public string FacilitatorExternalID { get; set; }

    }
}
