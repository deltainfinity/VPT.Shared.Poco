using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
   public class FormFieldDTO
    {
        public FormFieldDTO() { }
        public FormFieldDTO(FormField source)
        {
            FormFieldID = source.FormFieldID;
            FormID = source.FormID;
            FieldName = source.FieldName;
            FieldLabel = source.FieldLabel;
            IsHidden = source.IsHidden;
            OrganizationID = source.OrganizationID;
            DisplayOrder = source.DisplayOrder;
            FormDataID = source.FormDataID;
            ColumnWidth = source.ColumnWidth;
            InputType = source.InputType;
            IsHeader = source.IsHeader;
        }

        /// <summary>
        /// The form field ID
        /// </summary>
        [JsonProperty("formFieldID")]
        public int FormFieldID { get; set; }

        /// <summary>
        /// The form ID
        /// </summary>
        [JsonProperty("formID")]
        public int FormID { get; set; }

        /// <summary>
        /// The field name.
        /// </summary>
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        /// <summary>
        /// The field label name.
        /// </summary>
        [JsonProperty("fieldLabel")]
        public string FieldLabel { get; set; }

        /// <summary>
        /// The flag to check if Hidden.
        /// </summary>
        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        /// <summary>
        /// The organization ID.
        /// </summary>
        [JsonProperty("organizationID")]
        public int OrganizationID { get; set; }

        /// <summary>
        /// The form data ID.
        /// </summary>
        [JsonProperty("formDataID")]
        public int FormDataID { get; set; }

        /// <summary>
        /// The form data name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The order to be displayed.
        /// </summary>
        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The format of the data.
        /// </summary>
        [JsonProperty("dataFormat")]
        public string DataFormat { get; set; }

        /// <summary>
        /// Number of columns of the grid to be used to display a label (based on materialize 12 column responsive grid).
        /// Currently it supports 6 and 12 width.
        /// </summary>
        [JsonProperty("columnWidth")]
        public int ColumnWidth { get; set; }

        /// <summary>
        ///HTML input type used to display a text. Default input type is Label.
        /// </summary>
        [JsonProperty("inputType")]
        public string InputType { get; set; }

        [JsonProperty("isHeader")]
        public bool IsHeader { get; set; }
        
    }
}
