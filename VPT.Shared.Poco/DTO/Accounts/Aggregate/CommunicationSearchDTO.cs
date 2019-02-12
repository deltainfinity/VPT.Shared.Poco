using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class CommunicationSearchDTO
    {
        public List<int> SubjectIDs { get; set; } 
        public string SearchTerm { get; set; }
        public int SearchBy { get; set; }

        public CommunicationSearchDTO() { }

        public CommunicationSearchDTO(List<int> perosnIDs,string searchTerm,int searchBy)
        {
            SubjectIDs = perosnIDs;
            SearchTerm = searchTerm;
            SearchBy = searchBy;
        }

    }
}
