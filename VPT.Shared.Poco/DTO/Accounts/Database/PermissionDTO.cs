using VPT.Shared.Poco.Model.Accounts.Database;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class PermissionDTO : BaseDatabaseDTO
    {
        public PermissionDTO()
        { }

        public PermissionDTO(Permission source)
            : base(source)
        {
            PermissionID = source.PermissionID;
            Name = source.Name;
            GroupID = source.GroupID;
            Namespace = source.Namespace;
            Controller = source.Controller;
            Action = source.Action;
            isTemplatePermission = source.isTemplatePermission;
        }

        public PermissionDTO(Permission source, bool checkeditem)
            : base(source)
        {
            PermissionID = source.PermissionID;
            Name = source.Name;
            GroupID = source.GroupID;
            Namespace = source.Namespace;
            Controller = source.Controller;
            Action = source.Action;
            Checked = checkeditem;
        }
        public PermissionDTO(Permission source, bool checkeditem,List<RequestTemplateGroupPermission> requestTemplateGroupPermissionlList)
        {
            PermissionID = source.PermissionID;
            Name = source.Name;
            GroupID = source.GroupID;
            Namespace = source.Namespace;
            Controller = source.Controller;
            Action = source.Action;
            Checked = checkeditem;
            isTemplatePermission = source.isTemplatePermission;
            RequestTemplateGroupPermissionlList = requestTemplateGroupPermissionlList;
        }

        /// <summary>
        /// The PK ID for the permissions
        /// </summary>
        public int PermissionID { get; set; }

        [JsonProperty("Name")]
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

        public bool Checked {get;set; }

        public bool isTemplatePermission { get; set; }

        public IList<TemplateDTO> templates { get; set; }

        public List<RequestTemplateGroupPermission> RequestTemplateGroupPermissionlList { get; set; }
    }
}