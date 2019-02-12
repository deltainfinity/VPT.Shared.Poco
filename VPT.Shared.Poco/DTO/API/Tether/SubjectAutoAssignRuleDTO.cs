namespace VPT.Shared.Poco.DTO.API.Tether
{
    /// <summary>
    /// Contains information about a subject auto assignment rule
    /// </summary>
    public class SubjectAutoAssignRuleDTO
    {
        /// <summary>
        /// The organization ID that the rule is associated with
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// The type of the rule. Use SubjectAutoAssignRuleTypeConstants
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The value of the rule
        /// </summary>
        public string Value { get; set; }
    }
}
