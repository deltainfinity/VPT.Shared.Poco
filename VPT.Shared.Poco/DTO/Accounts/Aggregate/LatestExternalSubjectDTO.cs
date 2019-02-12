namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    /// <summary>
    /// Aggregate object containing all data related to a person and matched subjectID
    /// </summary>
    public class LatestExternalSubjectDTO
    {
       
        public string MatchedSubjectID { get; set; }

        public ExternalSubjectDetailsDTO ExternalSubjectDetails { get; set; }

        public bool LatestSubject { get; set; }

        public LatestExternalSubjectDTO(ExternalSubjectDetailsDTO externalSubjectDetails,string matchedSubjectID,bool latestSubject)
        {
            ExternalSubjectDetails = externalSubjectDetails;
            MatchedSubjectID = matchedSubjectID;
            LatestSubject = latestSubject;
        }
    }

  
}
