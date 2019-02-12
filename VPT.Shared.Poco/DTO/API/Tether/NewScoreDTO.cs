using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class NewScoreDTO
    {
        public int StudentId { get; set; }

        public int TeacherId { get; set; }

        public int AssetId { get; set; }

        public int? AssignmentId { get; set; }
    }
}
