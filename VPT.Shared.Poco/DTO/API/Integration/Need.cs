namespace VPT.Shared.Poco.DTO.API.Integration
{
    public class Need
    {
        public Need()
        {

        }
        public bool Active { get; set; }
        public bool InTreatment { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
    }
}