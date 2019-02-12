using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class ProgramTypeDTO : BaseDTO
    {
        public ProgramTypeDTO(ProgramType source)
        {
            ProgramTypeID = source.ProgramTypeID;
            Name = source.Name;
            Priority = source.Priority;
        }

        /// <summary>
        /// The ID of goalType
        /// </summary>
        [JsonProperty("programTypeID")]
        public int ProgramTypeID { get; set; }

        /// <summary>
        /// The name of goalType
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The rank of Goal Priority
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

    }
}
