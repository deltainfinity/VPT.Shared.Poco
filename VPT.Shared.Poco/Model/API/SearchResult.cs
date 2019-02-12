using VPT.Shared.Poco.Enum.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class for getting the generic search result data from the DB queries.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// The ID of the Primary Key ID for the returned object type that matched
        /// </summary>
        public string PrimaryKey { get; set; }

        /// <summary>
        /// The Type of Object found matching the keywords
        /// </summary>
        public int ObjectType { get; set; }

        /// <summary>
        /// The Type of Object found matching the keywords
        /// </summary>
        public string ObjectTypeName => ObjectTypeConstants.GetByEnum(ObjectType);
    }
}
