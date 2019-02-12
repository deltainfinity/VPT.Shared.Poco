namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class UpdateSubjectProgramAssessmentStateDTO
    {
        /// <summary>
        /// Assessment PIN
        /// </summary>
        public string InstanceID { get; set; }
        /// <summary>
        /// This is the CourseID or AssessmentID/SKU
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 0 = assessment, 1 = course
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// 1 = in progress, 2 = complete
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// subject program Id
        /// </summary>
        public int SubjectProgramId { get; set; }
    }
}
