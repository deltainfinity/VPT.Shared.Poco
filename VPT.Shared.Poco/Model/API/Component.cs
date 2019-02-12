using NPoco;
using System;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("Component")]
    [PrimaryKey("ComponentID")]
    public class Component
    {
        public Component()
        { }

        public Component(ComponentDTO source, int organizationID)
        {
            ComponentID = source.ComponentID;
            ComponentName = source.ComponentName;
            SessionNumber = source.SessionNumber;
            SessionLength = source.SessionLength;
            Deleted = source.Deleted;
            MinGroupSize = source.MinGroupSize;
            MaxGroupSize = source.MaxGroupSize;
            IsOpen = source.IsOpen;
            StartDate = source.StartDate;
            EndDate = source.EndDate;
            IsReusable = source.IsReusable;
            IsOptional = source.IsOptional;
            OrganizationID = organizationID;
        }
        public int ComponentID { get; set; }

        /// <summary>
        /// The name of the component
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// The number of the session 
        /// </summary>
        public int SessionNumber { get; set; }

        /// <summary>
        /// The length of the session
        /// </summary>
        public decimal SessionLength { get; set; }

        /// <summary>
        /// Is parent component or not
        /// </summary>
        [ResultColumn]
        public bool isParentComponent { get; set; }

        /// <summary>
        /// flag to indicate deleted or not
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// The ID of the Case plan
        /// </summary>
        public int MinGroupSize { get; set; }

        /// <summary>
        /// The max group size
        /// </summary>
        public int MaxGroupSize { get; set; }

        /// <summary>
        /// The flag to indicate open or closed
        /// </summary>
        public int IsOpen { get; set; }

        /// <summary>
        /// The start date
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date
        /// </summary>
        public DateTime? EndDate { get; set; }

        public bool IsReusable { get; set; }

        public bool IsOptional { get; set; }

        public int OrganizationID { get; set; }

    }
}
