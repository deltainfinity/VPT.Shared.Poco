using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("Job")]
    [PrimaryKey("JobId")]
    public class Job : BaseModel
    {
        public Job()
        { }

        public Job(JobDTO source)
            : base(source)
        {
            JobId = source.JobId;
            LocationId = source.LocationId;
            ProviderId = source.ProviderId;
            Title = source.Title;
            SubType = source.SubType;
            SOCCode = source.SOCCode;
            JobZone = source.JobZone;
            RTI = source.RTI;
            Description = source.Description;
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

        //Adding OrganizationID for SearchEngineData
        public int OrganizationID { get; set; }
    }
}
