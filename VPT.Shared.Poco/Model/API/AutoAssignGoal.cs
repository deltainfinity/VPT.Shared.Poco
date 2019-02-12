using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Model.API
{
    public class AutoAssignGoal
    {
        public int SubjectuserID { get; set; }
        public string Labeltext { get; set; }
        public string DomainName { get; set; }
        public int DomainID { get; set; }
        public string GoalName { get; set;}
        public int GoalID { get; set; }

    }
}
