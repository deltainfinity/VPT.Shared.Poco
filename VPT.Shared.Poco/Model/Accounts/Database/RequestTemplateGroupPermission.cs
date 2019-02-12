using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("RequestTemplateGroupPermission")]
    [PrimaryKey("RequestTemplateGroupPermissionID")]
    public class RequestTemplateGroupPermission
    {
        /// <summary>
        /// The PK ID for the RequestTemplatePermission
        /// </summary>
        public int RequestTemplateGroupPermissionID { get; set; }

        /// <summary>
        /// The RequestTemplateID of the template
        /// </summary>
        public int RequestTemplateID { get; set; }

        /// <summary>
        /// The PermissionID of the feature
        /// </summary>
        public int PermissionID { get; set; }

        /// <summary>
        /// The ID of the group these permissions apply too
        /// </summary>
        public int GroupID { get; set; }
    }
}
