using VPT.Shared.Poco.Model.Accounts.Database;
using System.Collections.Generic;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    /// <summary>
    /// FeatureDTO Class
    /// </summary>
    public class FeatureDTO : BaseDatabaseDTO
    {
        /// <summary>
        /// Contructor for FeatureDTO
        /// </summary>
        public FeatureDTO()
        { }

        /// <summary>
        /// Contructor for FeatureDTO
        /// </summary>
        /// <param name="source">The source</param>       
        /// <param name="permissions">The permissions</param>
        public FeatureDTO(Feature source, List<PermissionDTO> permissions)
            : base(source)
        {
            FeatureID = source.FeatureID;
            Name = source.Name;
            Permissions = permissions;
            HasTemplate = source.HasTemplate;
        }

        /// <summary>
        /// Contructor for FeatureDTO
        /// </summary>
        /// <param name="source">The source</param>
        /// <param name="permissions">The permissions</param>
        /// <param name="checkeditem">The checkeditem</param>
        public FeatureDTO(Feature source, List<PermissionDTO> permissions, bool checkeditem)
            : base(source)
        {
            FeatureID = source.FeatureID;
            Name = source.Name;
            Permissions = permissions;
            Checked = checkeditem;
            HasTemplate = source.HasTemplate;
        }

        /// <summary>
        /// The PK ID for the Feature
        /// </summary>
        public int FeatureID { get; set; }

        /// <summary>
        /// The feature name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// List of permissions
        /// </summary>
        public IList<PermissionDTO> Permissions { get; set; }

        /// <summary>
        /// Bool variable to check/uncheck feature
        /// </summary>
        public bool Checked {get;set; }

        public bool HasTemplate { get; set; }       
    }
}