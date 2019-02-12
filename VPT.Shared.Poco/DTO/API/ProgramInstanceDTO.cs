using System;
using System.Collections.Generic;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramInstanceDTO : BaseDTO
    {
        public ProgramInstanceDTO()
        { }



        public ProgramInstanceDTO(ProgramInstanceDTO program, SORProgramDTO SORProgram, ParentProgram parentProgram, FacilityLocation facilityLocation, Facility facility, int SORProgramSeatCount, int facilitatorID)
        {
            if (program.ProgramId == 0)
            {
                if (!parentProgram.IsPerpetual)
                {
                    if(!string.IsNullOrEmpty(SORProgram.EffectiveDateFrom) && DateTime.TryParse(SORProgram.EffectiveDateFrom, out DateTime dateStarted))
                    {
                        StartDate = dateStarted;
                    }
                    else
                    {
                        StartDate = null;
                    }
                    if (!string.IsNullOrEmpty(SORProgram.EffectiveDateTo) && DateTime.TryParse(SORProgram.EffectiveDateTo, out DateTime dateEnded))
                    {
                        EndDate = dateEnded;
                    }
                    else
                    {
                        EndDate = null;
                    }
                }
                else
                {
                    StartDate = null;
                    EndDate = null;
                }
            }
            else
            {
                ProgramId = program.ProgramId;
                DateCreated = program.DateCreated;
                CreatedByUserID = program.CreatedByUserID;
                StartDate = program.StartDate;
                EndDate = program.EndDate;
            }

            Title = parentProgram.Title;
            ClassroomId = 0;

            SessionStartTime = SORProgram.StartTime;
            if (!string.IsNullOrWhiteSpace(SORProgram.EndTime2))
            {
                SessionEndTime = SORProgram.EndTime2;
            }
            else
            {
                SessionEndTime = SORProgram.EndTime;
            }

            if (SORProgram.Monday == "Y")
            {
                Monday = true;
                Title += " MON";
            }
            else
            {
                Monday = false;
            }
            if (SORProgram.Tuesday == "Y")
            {
                Tuesday = true;
                Title += " TUE";
            }
            else
            {
                Tuesday = false;
            }
            if (SORProgram.Wednesday == "Y")
            {
                Wednesday = true;
                Title += " WED";
            }
            else
            {
                Wednesday = false;
            }
            if (SORProgram.Thursday == "Y")
            {
                Thursday = true;
                Title += " THU";
            }
            else
            {
                Thursday = false;
            }
            if (SORProgram.Friday == "Y")
            {
                Friday = true;
                Title += " FRI";
            }
            else
            {
                Friday = false;
            }
            if (SORProgram.Saturday == "Y")
            {
                Saturday = true;
                Title += " SAT";
            }
            else
            {
                Saturday = false;
            }
            if (SORProgram.Sunday == "Y")
            {
                Sunday = true;
                Title += " SUN";
            }
            else
            {
                Sunday = false;
            }

            if (Title.Length > 50)
            {
                Title = Title.Substring(0, 50);
            }
            Address = facilityLocation.Address1;
            City = facilityLocation.City;
            State = facilityLocation.State;
            Zip = facilityLocation.PostalCode;
            FacilitatorID = facilitatorID;
            ParentProgramID = parentProgram.ParentProgramId;
            Deleted = false;
            FacilityID = facility.FacilityID;
            IsSORProgram = true;
            NumberofSeats = SORProgramSeatCount;
            ReferToOrganizationID = program.ReferToOrganizationID;
        }

        public ProgramInstanceDTO(Program source)
            : base(source)
        {
            ProgramId = source.ProgramId;
            ClassroomId = source.ClassroomId;
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
            City    = source.City;
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

        public int FacilityID { get; set; }

        public string StartDateFormatted { get; set; }

        public string EndDateFormatted { get; set; }

        //Adding OrganizationID for SearchEngineData
        public int OrganizationID { get; set; }
        public int PlatformID { get; set; }
        public bool IsSORProgram { get; set; }

        public int ReferToOrganizationID { get; set; }
    }
}
