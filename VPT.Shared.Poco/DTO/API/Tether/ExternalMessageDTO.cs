using System.ComponentModel.DataAnnotations;
using VPT.Shared.Poco.ValidationAttributes;

namespace VPT.Shared.Poco.DTO.API.Tether
{
    public class ExternalMessageDTO
    {
        [Required]
        [ExternalMessageDeliveryTypeAttribute]
        public int DeliveryType { get; set; }

        [Required]
        public string MessageBody { get; set; }
    }
}
