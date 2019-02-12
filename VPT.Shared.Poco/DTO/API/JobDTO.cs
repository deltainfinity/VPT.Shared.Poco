using System.Collections.Generic;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class JobDTO : BaseDTO
    {
        public JobDTO()
        { }

        public JobDTO(Job source)
            : base(source)
        {
            JobId = source.JobId;
            LocationId = source.LocationId;
            ProviderId = source.ProviderId;
            Title = source.Title;
            SOCCode = source.SOCCode;
            JobZone = source.JobZone;
            RTI = source.RTI;
            Description = source.Description;
            SubType = source.SubType;
            Comments = source.Comments;
            OrganizationID = source.OrganizationID;
        }

        /// <summary>
        /// The ID of the Job
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// The ID of the Location the Job is at
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// The ID of the Provider that created the job
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// The title of the Job
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Not Sure (See Eric)
        /// </summary>
        public int SubType { get; set; }

        /// <summary>
        /// Not Sure (See Eric)
        /// </summary>
        public string SOCCode { get; set; }

        /// <summary>
        /// Not Sure (See Eric)
        /// </summary>
        public string JobZone { get; set; }

        /// <summary>
        /// Not Sure (See Eric)
        /// </summary>
        public string RTI { get; set; }

        /// <summary>
        /// The desciption of the job
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Comments about the job
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// The addresses associated with this job
        /// </summary>
        public List<string> FacilityIds { get; set; }

        /// <summary>
        /// The Agent contacts associated with this job
        /// </summary>
        public List<string> ContactIds { get; set; }

        /// <summary>
        /// The subject assigned to this job
        /// </summary>
        public List<string> AssignedSubjects { get; set; }

        //Adding OrganizationID for SearchEngineData
        public int OrganizationID { get; set; }
    }
}
