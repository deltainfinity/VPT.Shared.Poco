using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    /// <summary>
    /// Class defining a Tag in VPT
    /// </summary>
    public class Tag : BaseModel
    {
        public Tag()
        { }

        public Tag(TagDTO source)
            : base(source)
        {
            TagID = source.TagID;
            Name = source.Name;
            Type = source.TypeID;
        }

        public int TagID { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }
    }
}
