using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("GroupPermission")]
    [PrimaryKey("GroupPermissionID")]
    public class GroupPermission 
    {

        public GroupPermission()
        { }

        public GroupPermission(GroupPermissionDTO source)
        {
            GroupPermissionID = source.GroupPermissionID;
            GroupID = source.GroupID;
            Permissions = source.Permissions;
            PermissionID = source.PermissionID;            
        }

        public int GroupPermissionID { get; set; }

        public int GroupID { get; set; }

        public int Permissions { get; set; }

        public int PermissionID { get; set; }
        
    }
    
}
