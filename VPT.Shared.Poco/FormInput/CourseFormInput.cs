using Newtonsoft.Json;

namespace VPT.Shared.Poco.FormInput
{
    public class CourseFormInput
    {
        [JsonProperty("bookingID")]
        public string BookingID { get; set; }

        [JsonProperty("courseID")]
        public string CourseID { get; set; }

        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }
    }
}
