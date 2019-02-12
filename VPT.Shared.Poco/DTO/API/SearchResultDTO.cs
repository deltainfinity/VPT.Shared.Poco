using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    /// <summary>
    /// Class for getting the generic search result data from the DB queries. 
    /// </summary>
    public class SearchResultDTO
    {
        public SearchResultDTO()
        { }

        public SearchResultDTO(string PrimaryKey, int objectType)
        {
            this.PrimaryKey = PrimaryKey;
            this.ObjectType = objectType;
        }

        public SearchResultDTO(SearchResult source)
        {
            PrimaryKey = source.PrimaryKey.ToString();
            ObjectType = source.ObjectType;
        }

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
