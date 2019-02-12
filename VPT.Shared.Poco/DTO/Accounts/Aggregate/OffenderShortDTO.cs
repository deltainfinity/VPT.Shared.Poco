using System;

namespace VPT.Shared.Poco.DTO.Accounts.Aggregate
{
    public class OffenderShortDTO
    {

        public int OffenderId { get; set; }

        public string ExternalId { get; set; }

        public string FirstName { get; set; }


        public string MiddleInitial { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }


        public int Age { get; set; }


        public DateTime DateOfMajority { get; set; }


        public string Gender { get; set; }


        public string Sex { get; set; }


        public string Ethnicity { get; set; }


        public int RaceId { get; set; }


        public int StatusId { get; set; }

        public string Status { get; set; }


        public string EMAIL { get; set; }


        public string TITLE { get; set; }


        public string ADDRESS_1 { get; set; }


        public string ADDRESS_2 { get; set; }


        public string CITY { get; set; }


        public string STATE { get; set; }


        public string ZIP { get; set; }


        public string COUNTY { get; set; }


        public string COUNTRY { get; set; }


        public string PHONE { get; set; }

        public string FAX { get; set; }


        public string PASSWORD { get; set; }


        public string img { get; set; }

        //public List<CustomField> ExtendedFields { get; set; }


        //public CCRReview CCRCompleted { get; set; }


        //public List<OffenderAssessment> PendingAssessments { get; set; }

        //public List<OffenderAssessment> CompletedAssessments { get; set; }

        //public List<OffenderAssessment> ArchivedAssessments { get; set; }

        //public List<OffenderCasePlan> ActiveCasePlans { get; set; }


        //public List<OffenderCasePlan> CompletedCasePlans { get; set; }


        //public List<Need> ActiveNeeds { get; set; }


        //public List<Provider> ActiveProviders { get; set; }


        //public Arrest[] Causes { get; set; }


        public string currentInWorkStrongR { get; set; }



    }
}
