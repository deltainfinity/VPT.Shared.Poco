namespace VPT.Shared.Poco.DTO.API.Aggregate
{
    public class GoalAndDomainDTO
    {
        public GoalAndDomainDTO(int goalID, string goalName, string domainName, int domainID, string assessmentName,int assessmentID, bool isPrison)
        {
            this.GoalID = goalID;
            this.GoalName = goalName;
            this.DomainName = domainName;
            this.DomainID = domainID;
            this.AssessmentName = assessmentName;
            this.AssessmentID = assessmentID;
            //this.AutoAssign = autoAssign;
            this.IsPrison = isPrison;
        }

        public int GoalID { get; set; }
        public string GoalName { get; set; }
        public string DomainName { get; set; }
        public int DomainID { get; set; }
        public string AssessmentName { get; set; }
        public int AssessmentID { get; set; }
        //public bool AutoAssign { get; set; }
        public bool IsPrison { get; set; }
    }
}
