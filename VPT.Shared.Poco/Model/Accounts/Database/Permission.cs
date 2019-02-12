using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("Permission")]
    [PrimaryKey("PermissionID")]
    public class Permission : BaseDatabaseModel
    {

        public Permission()
        { }

        public Permission(PermissionDTO source)
            : base(source)
        {
            PermissionID = source.PermissionID;
            Name = source.Name;

            GroupID = source.GroupID;
            Namespace = source.Namespace;
            Controller = source.Controller;
            Action = source.Action;           
        }

        /// <summary>
        /// The PK ID for the permissions
        /// </summary>
        public int PermissionID { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// The ID of the group these permissions apply too
        /// </summary>
        public int GroupID { get; set; }

        /// <summary>
        /// The namespace of the controller these permissions apply too
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// The name of the controller these permissions apply too
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// The name of the controller action these permissions apply too
        /// </summary>
        public string Action { get; set; }      
        
        public bool isTemplatePermission { get; set; }
    }

}
