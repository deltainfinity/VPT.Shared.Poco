using System;
using System.ComponentModel.DataAnnotations;

namespace VPT.Shared.Poco.DTO.API.Tether.Communication
{
    public class AllMessagesDTO
    {
        [Required]
        public int OrganizationID { get; set; }

        [Required]
        public int State { get; set; }

        [Required]
        public int Direction { get; set; }

        [Required]
        public string PersonGUID { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        public int Page { get; set; }

        [Required]
        public int ItemsPerPage { get; set; }

        [Required]
        public int ApplicationType { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }
    }
}
