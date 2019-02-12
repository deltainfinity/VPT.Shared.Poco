using System;
using VPT.Shared.Poco.Constants;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class CapacityUtilizationReportDTO : BaseDTO
    {
        public CapacityUtilizationReportDTO(CapacityUtilizationReport source)
            //: base(source)
        {
            Title = source.Title;
            City = source.City;
            NumberofSeats = source.NumberofSeats;
            ParentProgramTitle = source.ParentProgramTitle;
            AssignedCount = source.AssignedCount;
            FacilityCode = String.IsNullOrEmpty(source.FacilityCode) ? ApplicationConstants.NotApplicable : source.FacilityCode ;
            DistrictCode = source.DistrictCode;
            EndDate = source.IsPerpetual ? null : source.EndDate.ToShortDateString();
            IsPerpetual = source.IsPerpetual;
        }

        public string Title { get; set; }
        public string City { get; set; }
        public int NumberofSeats { get; set; }
        public string ParentProgramTitle { get; set; }
        public int AssignedCount { get; set; }
        public string EndDate { get; set; }
        public bool IsPerpetual { get; set; }
        public string FacilityCode { get; set; }
        public string DistrictCode { get; set; }
    }
}
