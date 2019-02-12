using NPoco;
using System.Collections.Generic;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("Feature")]
    [PrimaryKey("FeatureID")]
    /// <summary>
    /// Feature Class
    /// </summary>
    public class Feature : BaseDatabaseModel
    {
        /// <summary>
        /// Contructor for Feature
        /// </summary>
        public Feature()
        { }

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
        public IList<Permission> Permissions { get; set; }

        public bool HasTemplate { get; set; }
    }

}
