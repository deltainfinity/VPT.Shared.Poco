using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    class VerificationQuestionDTO : BaseDatabaseDTO
    {
        public VerificationQuestionDTO()
        { }

        public VerificationQuestionDTO(PersonVerification personVerification)
        {
            VerificationQuestionId = personVerification.VerificationQuestionId;
            OrganizationId = personVerification.OrganizationId;
            Question = personVerification.Question;
        }

        public int VerificationQuestionId { get; set; }
        public int OrganizationId { get; set; }
        public string Question { get; set; }
    }
}
