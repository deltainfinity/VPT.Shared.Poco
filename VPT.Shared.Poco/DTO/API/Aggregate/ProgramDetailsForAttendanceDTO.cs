using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class ProgramDetailsForAttendanceDTO: ProgramDTO
    {
        public ProgramDetailsForAttendanceDTO(Program source, ParentProgram parentProgram, string facilityCode)
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
            ParentProgramName = parentProgram.Title;
            FacilityCode = facilityCode;
            IsPerpetual = parentProgram.IsPerpetual;
        }
        public string ParentProgramName { get; set; }

        public string FacilityCode { get; set; }
        public bool IsPerpetual { get; set; }

    }
}
