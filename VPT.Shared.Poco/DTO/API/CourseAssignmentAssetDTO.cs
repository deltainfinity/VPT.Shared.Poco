using System;
using System.Linq;
using System.Collections.Generic;


namespace VPT.Shared.Poco.DTO.API
{
    public class CourseAssignmentAssetDTO
    {

        public CourseAssignmentAssetDTO()
        {

        }

        public int AssetId { get; set; }

        public Guid AssetGuid { get; set; }

        public DateTime? AssignedOn { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? VisibleDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public string AssetTitle { get; set; }

        public Guid AssetThumbGuid { get; set; }

        public string AssetResourceCode { get; set; }

        /// <summary>
        /// The last attempt score
        /// </summary>
        public int? Score { get; set; }

        /// <summary>
        /// The last finish assessment (save score) date.
        /// </summary>
        public DateTime? ScoreDate { get; set; }

        /// <summary>
        /// If user has already attempted exam and can retake
        /// </summary>
        public bool IsRetryAvailable { get; set; }

        /// <summary>
        /// Assignment Status from Assignment. Please see AssignmentStatus to see the string status
        /// NotStarted = 1,
        /// Started = 2,
        /// Completed = 3,
        /// PastDue = 4
        /// </summary>
        public string Status { get; set; }

        //public StatusFilterType StatusValue { get; set; }

        public string AssignedUserId { get; set; }

        public string CoordinatorId { get; set; }

        public int AssetDomainTypeId { get; set; }

        public bool IsAssigned { get; set; }
                
    }
}
