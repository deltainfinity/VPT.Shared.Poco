using System;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class TemplateDTO
    {
        public TemplateDTO()
        { }

        /// <summary>
        /// The RequestTemplateID for the permissions
        /// </summary>
        public int RequestTemplateID { get; set; }

        /// <summary>
        /// The Title for the permissions
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The Template for the Permissions.
        /// </summary>
        public int Template { get; set; }

        /// <summary>
        /// The CreatedByPersonID of the template
        /// </summary>
        public string CreatedByPersonID { get; set; }

        /// <summary>
        /// The Date  of the template created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The UpdatedByPersonID of the template
        /// </summary>
        public string UpdatedByPersonID { get; set; }

        /// <summary>
        /// The Date of updated the template
        /// </summary>
        public string DateUpdated { get; set; }

        /// <summary>
        /// The checked status of the Template.
        /// </summary>
        public bool Checked { get; set; }
    }
}
