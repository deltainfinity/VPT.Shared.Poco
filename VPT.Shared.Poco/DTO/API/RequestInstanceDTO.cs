using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class RequestInstanceDTO
    {
        public RequestInstanceDTO()
        {
        }
        public int RequestID { get; set; }
        public int RecipientPersonID { get; set; }
        public int InitiatorPersonID { get; set; }
        public DateTime DateCreated { get; set; }
        public int RequestTemplateID { get; set; }
        public string RenderedTemplate { get; set; }
        public bool Delivered { get; set; }
        public DateTime? DateCompleted { get; set; }
        public int ActionStepID { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int UpdatedByPersonID { get; set; }
        public string Domain { get; set; }
        public int SubjectId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string SubjectName { get; set; }
        public string InitiatorPersonName { get; set; }
    }
}
