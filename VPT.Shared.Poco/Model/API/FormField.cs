using NPoco;
using VPT.Shared.Poco.DTO.API;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("FormField")]
    [PrimaryKey("FormFieldID")]
    public class FormField
    {
        public FormField()
        { }

        public FormField(FormFieldDTO source, int organizationID)
        {
            FormFieldID = source.FormFieldID;
            DisplayOrder = source.DisplayOrder;
            FieldLabel = source.FieldLabel;
            FieldName = source.FieldName;
            FormDataID = source.FormDataID;
            FormFieldID = source.FormFieldID;
            FormID = source.FormID;
            IsHidden = source.IsHidden;
            OrganizationID = organizationID;
            ColumnWidth = source.ColumnWidth;
            InputType = source.InputType;
            IsHeader = source.IsHeader;
        }

        public int FormFieldID { get; set; }

        public int FormID { get; set; }

        public string FieldName { get; set; }

        public string FieldLabel { get; set; }

        public bool IsHidden { get; set; }

        public int OrganizationID { get; set; }

        public int DisplayOrder { get; set; }

        public int FormDataID { get; set; }

        public int ColumnWidth { get; set; }

        public string InputType { get; set; }

        public bool IsHeader { get; set; }
    }
}
