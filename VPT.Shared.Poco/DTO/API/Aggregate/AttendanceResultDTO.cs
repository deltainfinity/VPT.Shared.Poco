using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class AttendanceResultDTO
    {
        public bool Success { get; set; }
        public bool Error { get; set; }
        public bool IsExist { get; set; }
        public List<string> SubjectNames { get; set; }
    }
}
