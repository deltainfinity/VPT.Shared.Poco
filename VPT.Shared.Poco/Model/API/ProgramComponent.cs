using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("ProgramComponent")]
    [PrimaryKey("ProgramComponentID")]
    public class ProgramComponent
    {
        public ProgramComponent()
        { }

        public ProgramComponent(ProgramComponentDTO source)
        {
            ProgramComponentID = source.ProgramComponentID;
            ComponentID = source.ComponentID;
            ProgramComponentID = source.ProgramComponentID;
            ParentProgramId = source.ParentProgramId;
        }

        public int ProgramComponentID { get; set; }

        public int ComponentID { get; set; }

        public int ParentProgramId { get; set; }

    }
}
