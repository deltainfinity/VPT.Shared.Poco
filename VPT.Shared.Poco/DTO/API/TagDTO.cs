using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class TagDTO : BaseDTO
    {
        public TagDTO(Tag source)
            : base(source)
        {
            TagID = source.TagID;
            Name = source.Name;
            TypeID = source.Type;
        }

        public int TagID { get; set; }
        public string Name { get; set; }
        public int TypeID { get; set; }
        public string TypeName => TagTypeConstants.GetByEnum(TypeID);
    }
}
