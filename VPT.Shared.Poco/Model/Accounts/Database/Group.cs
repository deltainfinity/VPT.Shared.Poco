using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("Group")]
    [PrimaryKey("GroupID")]
    public class Group : BaseDatabaseModel
    {

        public Group()
        { }
        public Group(GroupDTO source)
            : base(source)
        {
            GroupID = source.GroupID;
            Name = source.Name;
            IsSystem = source.IsSystem;
            Description = source.Description;
            IsCustom = source.IsCustom;
        }

        public int GroupID { get; set; }

        public string Name { get; set; }

        public bool IsSystem { get; set; }

        public string Description { get; set; }

        public bool IsCustom { get; set; }
    }

}
