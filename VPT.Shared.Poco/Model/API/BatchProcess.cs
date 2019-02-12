using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("BatchProcess")]
    [PrimaryKey("BatchProcessID")]
    public class BatchProcess
    {
        public BatchProcess(BatchProcessDTO source)
        {
            BatchProcessID = source.BatchProcessID;
            EventTypeID = source.EventTypeID;
            SORID = source.SORID;
            ContentType = source.ContentType;
            Body = source.Body;
        }

        /// <summary>
        /// id of batch process  
        /// </summary>
        public int BatchProcessID { get; set; }

        /// <summary>
        /// id of event type
        /// </summary>
        public int EventTypeID { get; set; }

        /// <summary>
        /// id of system of record
        /// </summary>
        public string SORID { get; set; }

        /// <summary>
        /// type of content 
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        ///body 
        /// </summary>
        public string Body { get; set; }
    }
}
