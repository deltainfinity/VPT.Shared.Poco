using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class defining a CapacityUtilizationReport in VPT
    /// </summary>
    public class CapacityUtilizationReport 
    {
        public CapacityUtilizationReport()
        { }

        public CapacityUtilizationReport(CapacityUtilizationReportDTO source)
        {
            Title = source.Title;
            City = source.City;
            NumberofSeats = source.NumberofSeats;
            ParentProgramTitle = source.ParentProgramTitle;
            AssignedCount = source.AssignedCount;
        }

        /// <summary>
        /// title of CapacityUtilizationReport 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// number of seats
        /// </summary>
        public int NumberofSeats { get; set; }

        /// <summary>
        /// title of parent program  
        /// </summary>
        public string ParentProgramTitle { get; set; }

        /// <summary>
        /// count of assigned  
        /// </summary>
        public int AssignedCount { get; set; }

        /// <summary>
        /// end date  
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// id of batch process  
        /// </summary>
        public bool IsPerpetual { get; set; }

        /// <summary>
        /// facility code
        /// </summary>
        public string FacilityCode { get; set; }

        /// <summary>
        /// district code
        /// </summary>
        public string DistrictCode { get; set; }
    }
}
