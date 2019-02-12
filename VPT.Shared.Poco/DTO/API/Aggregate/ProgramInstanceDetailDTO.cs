using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Accounts.Shared.DTO.Aggregate;
using VPT.Accounts.Shared.DTO.Database;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class ProgramInstanceDetailDTO
    {
        /// <summary>
        /// Public Constructor
        /// </summary>
        public ProgramInstanceDetailDTO()
        { }
        /// <summary>
        /// Copy constructor used to populate the object
        /// </summary>
        /// <param name="programinstance">The list of program instances</param>
        /// <param name="facilitatorName">The name of facilitator if any</param>
        /// <param name="classname">The class name if any</param>
        /// <param name="facility">The name of facility</param>
        /// <param name="isPerpetual">Perpetual flag</param>

        public ProgramInstanceDetailDTO(Program programinstance, List<PersonDetailsDTO> facilitatorName, string classname, Facility facility,bool isPerpetual)
            : base()
        {
            ProgramId = programinstance.ProgramId;
            Title = programinstance.Title;
            IsSORProgram = programinstance.IsSORProgram;
            StartDate = programinstance.StartDate.HasValue?programinstance.StartDate.Value.ToString("MM/dd/yyyy"):string.Empty;
            EndDate = programinstance.EndDate.HasValue? programinstance.EndDate.Value.ToString("MM/dd/yyyy"): string.Empty;
            SessionStartTime = programinstance.SessionStartTime;
            SessionEndTime = programinstance.SessionEndTime;


            Address = programinstance.Address;
            City = programinstance.City;
            State = programinstance.State;
            Zip = programinstance.Zip;
            FacilitatorID = programinstance.FacilitatorID;
            ParentProgramID = programinstance.ParentProgramID;
            FacilitatorName = (facilitatorName == null || facilitatorName.Count()==0 ) ? null : facilitatorName.Where(x => x.PersonID.Equals(programinstance.FacilitatorID)).First().FullNameFirstNameFirstFormat;
            ClassName = classname;

            IsPerpetual = isPerpetual;
            Sunday = programinstance.Sunday;
            Monday = programinstance.Monday;
            Tuesday = programinstance.Tuesday;
            Wednesday = programinstance.Wednesday;
            Thursday = programinstance.Thursday;
            Friday = programinstance.Friday;
            Saturday = programinstance.Saturday;
            NumberofSeats = programinstance.NumberofSeats;
            OpenSeats = programinstance.AssignedCount > 0 ? ((programinstance.NumberofSeats - programinstance.AssignedCount) >= 0 ? (programinstance.NumberofSeats - programinstance.AssignedCount) : 0) : programinstance.NumberofSeats;            
            FacilityID = programinstance.FacilityID;
            DateCreated = programinstance.DateCreated;
            CreatedByUserID = programinstance.CreatedByUserID;
            Location = facility==null ? "" : facility.FacilityName;

        }
        /// <summary>
        /// List of contact domains
        /// </summary>
        [JsonProperty("programInstances")]
        public IList<ProgramInstanceDTO> ProgramInstance { get; set; }

        /// <summary>
        /// List of goals
        /// </summary>
        [JsonProperty("programFacilitator")]
        public IList<PersonDTO> ProgramFacilitator { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("programId")]
        public int ProgramId { get; set; }
        [JsonProperty("startDate")]
        public string StartDate { get; set; }
        [JsonProperty("endDate")]
        public string EndDate { get; set; }
        [JsonProperty("startTime")]
        public string SessionStartTime { get; set; }
        [JsonProperty("endTime")]
        public string SessionEndTime { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("city")]

        public string City { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("facilitatorID")]
        public int FacilitatorID { get; set; }
        [JsonProperty("zip")]
        public string Zip { get; set; }
        [JsonProperty("parentProgramID")]
        public int ParentProgramID { get; set; }
        [JsonProperty("facilitatorName")]
        public string FacilitatorName { get; set; }
        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("IsPerpetual")]
        public bool IsPerpetual { get; set; }

        [JsonProperty("Sunday")]
        public bool Sunday { get; set; }

        [JsonProperty("Monday")]
        public bool Monday { get; set; }

        [JsonProperty("Tuesday")]
        public bool Tuesday { get; set; }

        [JsonProperty("Wednesday")]
        public bool Wednesday { get; set; }

        [JsonProperty("Thursday")]
        public bool Thursday { get; set; }
        
        [JsonProperty("Friday")]
        public bool Friday { get; set; }

        [JsonProperty("Saturday")]
        public bool Saturday { get; set; }
        [JsonProperty("NumberofSeats")]
        public int NumberofSeats { get; set; }
        [JsonProperty("facilityID")]
        public int FacilityID { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedByUserID { get; set; }
        public int AssignedCount { get; set; }
        public int OpenSeats { get; set; }
        public string Location { get; set; }
        public bool IsSORProgram { get; set; }
        public string instanceDetailedName { get; set; }

    }
}
