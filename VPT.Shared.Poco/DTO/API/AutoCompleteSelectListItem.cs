namespace VPT.Shared.Poco.DTO.API
{
    public class AutoCompleteSelectListItem
    {
        public AutoCompleteSelectListItem()
        { }

        public AutoCompleteSelectListItem(int id, string name,bool isActive)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
       
    }
}
