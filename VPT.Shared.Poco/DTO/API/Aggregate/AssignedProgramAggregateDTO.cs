namespace VPT.Shared.Poco.DTO.API
{
    public class AssignedProgramVIDSAggregateDTO : BaseDTO
    {
        public AssignedProgramVIDSAggregateDTO()
        {
        }
       
        public string AssignType { get; set; }
        public int ProgramID { get; set; }
        public int ParentProgramID { get; set; }
        public int ProgramStatus { get; set; }
        public int SubjectGoalID { get; set; }
        public int TreatmentPathwayID { get; set; }
        public int TreatmentPathwayGoalID { get; set; }
    }
}