using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class BatchProcessDTO 
    {
        public BatchProcessDTO(BatchProcess source)
        {
            BatchProcessID = source.BatchProcessID;
            EventTypeID = source.EventTypeID;
            SORID = source.SORID;
            ContentType = source.ContentType;
            Body = source.Body;
           
        }

        /// <summary>
        /// The ID of BatchProcess
        /// </summary>
        [JsonProperty("batchProcessID")]
        public int BatchProcessID { get; set; }

        /// <summary>
        /// The event type
        /// </summary>
        [JsonProperty("eventTypeID")]
        public int EventTypeID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SORID")]
        public string SORID { get; set; }

        /// <summary>
        /// 
        /// </summary>

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
        /// <summary>
        /// Goal ID
        /// </summary>

        [JsonProperty("body")]
        public string Body { get; set; }


    }
}