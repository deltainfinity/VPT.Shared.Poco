using VPT.Shared.Poco.Model.Accounts.Database;
using System.Collections.Generic;


namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    /// <summary>
    /// FeatureDataDTO Class
    /// </summary>
    public class FeatureDataDTO:  BaseDatabaseDTO
    {
        public int FeatureID { get; set; }
        public string Name { get; set; }
        public int PermissionID { get; set; }
        public string Namespace { get; set; }
        public string controller { get; set; }
        public string Action { get; set; }
        public string PermissionName { get; set; }
        public bool HasTemplate { get; set; }
        public IList<Permission> Permissions { get; set; }
    }
}