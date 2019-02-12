using System.ComponentModel.DataAnnotations;
using VPT.Shared.Poco.DTO.API.Tether;
using VPT.Shared.Poco.Enum.API.Tether;

namespace VPT.Shared.Poco.ValidationAttributes
{
    public class ExternalMessageDeliveryTypeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (validationContext.ObjectInstance.GetType() != typeof(ExternalMessageDTO))
                return new ValidationResult("ExternalMessageDeliveryTypeAttribute may only be used with an ExternalMessageDTO object");
            var deliveryType = (ExternalMessageDTO)validationContext.ObjectInstance;
            return deliveryType.DeliveryType == (int)CommunicationDeliveryType.App ? new ValidationResult(GetErrorMessage()) : ValidationResult.Success;
        }

        private string GetErrorMessage()
        {
            return $"External messages can not have a delivery type of {CommunicationDeliveryType.App} (App)";
        }
    }
}
