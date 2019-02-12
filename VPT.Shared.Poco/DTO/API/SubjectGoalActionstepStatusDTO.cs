using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
   public class SubjectGoalActionstepStatusDTO
    {
     
        public int ActionStepID { get; set; }

        public int RequestID { get; set; }
        
        public int Status { get; set; }

    }
}
