using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VPT.Shared.Poco.Model.API;
using VPT.Shared.Poco.DTO.Accounts.Aggregate;
using VPT.Shared.Poco.Enum.Accounts;

namespace VPT.Shared.Poco.DTO.API
{
    /// <summary>
    /// DTO object for <see cref="Subject"/>
    /// </summary>
    public class SubjectDTO : BaseDTO
    {
#pragma warning disable 1591
        public SubjectDTO()
#pragma warning restore 1591
        { }

#pragma warning disable 1591
        public SubjectDTO(Subject subject, PersonDetailsDTO person, SubjectStaffAssignment subjectStaffAssignment = null, SubjectSecurityThreatGroup subjectSecurityThreatGroup = null, List<SubjectISCSentences> listSubjectISCSentences = null, string facilityName = null)
#pragma warning restore 1591
            : base(subject)
        {
            /*
             * Sourced from VPT Accounts person data
             */
            SourceOrganizationID = person.SourceOrganizationID;
            Auth0UserID = person.Auth0UserID;
            FirstName = person.FirstName;
            MiddleName = person.MiddleName;
            LastName = person.LastName;
            BirthDate = person.BirthDate;
            GenderID = person.GenderID;
            RaceID = person.RaceID;
            ImageURL = person.ImageURL;
            ImageSrc = person.ImageSrc;
            CaseManagerID = subject.CaseManagerID;
            personID = person.PersonID;
            SubjectPortalUsername = person.SubjectPortalUsername;
            PersonGUID = person.PersonGUID;

            //email
            if (person.Contacts.Any())
            {
                var primaryEmail = person.Contacts.FirstOrDefault(c => c.Primary && c.TypeID == (int)ContactType.Email);
                PrimaryEmail = primaryEmail != null ? primaryEmail.Value : string.Empty;
            }
            else
            {
                PrimaryEmail = string.Empty;
            }

            //phone
            if (person.Contacts.Any())
            {
                var primaryPhone = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.Phone);
                PrimaryPhone = primaryPhone != null ? primaryPhone.Value : string.Empty;
            }
            else
            {
                PrimaryPhone = string.Empty;
            }

            //mobile
            if (person.Contacts.Any())
            {
                var primaryMobile = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.Mobile);
                PrimaryMobile = primaryMobile != null ? primaryMobile.Value : string.Empty;
            }
            else
            {
                PrimaryMobile = string.Empty;
            }

            //secondary email
            if (person.Contacts.Any())
            {
                var secondaryEmail = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.SecondaryEmail);
                SecondaryEmail = secondaryEmail != null ? secondaryEmail.Value : string.Empty;
            }
            else
            {
                PrimaryMobile = string.Empty;
            }

            if (person.ExternalIDs.Any())
            {
                var sorExternalID = person.ExternalIDs.FirstOrDefault(e => e.Type == SystemControlledExternalIDType.SystemOfRecord);
                SORExternalID = sorExternalID != null ? sorExternalID.Value : string.Empty;
                var fbiID = person.ExternalIDs.FirstOrDefault(e => e.Type == SystemControlledExternalIDType.FbiID);
                FBIID = fbiID != null ? fbiID.Value : string.Empty;
                var sID = person.ExternalIDs.FirstOrDefault(e => e.Type == SystemControlledExternalIDType.SID);
                SID = sID != null ? sID.Value : string.Empty;
            }
            else
            {
                SORExternalID = string.Empty;
                FBIID = string.Empty;
                SID = string.Empty;
            }

            Groups = new List<string>();
            foreach (var group in person.Groups)
            {
                Groups.Add(group.DisplayName);
            }


            /*
             * Sourced from VPT Case Mgmt subject data
             */
            SubjectUserID = subject.SubjectUserID;
            FacilityID = subject.FacilityID;
            EstimatedReleaseDate = subject.EstimatedReleaseDate.HasValue ? subject.EstimatedReleaseDate.Value.ToShortDateString() : string.Empty;

            if (subjectStaffAssignment != null)
            {
                CaseManagerName = subjectStaffAssignment.StaffFirstName + " " + subjectStaffAssignment.StaffLastName;
            }

            CustodyLevel = string.IsNullOrWhiteSpace(subject.CustodyLevel) ? null : subject.CustodyLevel.Trim();
            SupervisionLevel = string.IsNullOrWhiteSpace(subject.SupervisionLevel) ? null : subject.SupervisionLevel.Trim();
            PendingCharges = subject.PendingCharges;
            SexOffenderType = subject.SexOffenderType;
            CaseType = subject.CaseType;
            FacilityCode = subject.FacilityCode;
            OffenderSiteType = string.IsNullOrWhiteSpace(subject.OffenderSiteType) ? null : subject.OffenderSiteType.Trim();
            GTLSiteID = subject.GTLSiteID;

            if (subjectSecurityThreatGroup != null)
            {
                STG = subjectSecurityThreatGroup.SecurityThreatGroupName;
                SecurityThreatGroupId = subjectSecurityThreatGroup.SecurityThreatGroupId;
                SecurityThreatGroupAssessment = subjectSecurityThreatGroup.SecurityThreatGroupAssessment;
                SecurityThreatGroupRank = subjectSecurityThreatGroup.SecurityThreatGroupRank;
                SecurityThreatGroupStatus = subjectSecurityThreatGroup.SecurityThreatGroupStatus;
                SecurityThreatGroupStatusDate = subjectSecurityThreatGroup.SecurityThreatGroupStatusDate;

            }

            if (listSubjectISCSentences != null)
            {
                ISCSentences = listSubjectISCSentences.Count > 0 ? "Yes" : "No";
            }

            //Full Address
            if (person.PersonAddress != null)
            {
                string address = string.Empty;
                if (!string.IsNullOrWhiteSpace(person.PersonAddress.Address1) && string.IsNullOrWhiteSpace(address))
                {
                    address = person.PersonAddress.Address1.Trim();
                }
                if (!string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(person.PersonAddress.Address2))
                {
                    address = address + "," + person.PersonAddress.Address2.Trim();
                }

                if (!string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(person.PersonAddress.City))
                {
                    address = address + "," + person.PersonAddress.City.Trim();
                }

                if (!string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(person.PersonAddress.State))
                {
                    address = address + "," + person.PersonAddress.State.Trim();
                }

                if (!string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(person.PersonAddress.ZipCode))
                {
                    address = address + "," + person.PersonAddress.ZipCode.Trim();
                }
                if (!string.IsNullOrWhiteSpace(address) && !string.IsNullOrWhiteSpace(person.PersonAddress.Country))
                {
                    address = address + "," + person.PersonAddress.Country.Trim();
                }
                FullAddress = address;
            }
            else
            {
                FullAddress = string.Empty;
            }

            //user custom property
            if (person.UserCustomProperties.Any())
            {
                UserCustomProperty = new UserCustomPropertyShortDTO(person.UserCustomProperties);
            }
            FacilityName = facilityName;
        }

        public SubjectDTO(PersonDetailsDTO person, SubjectAssessment assessment = null)
        {
            /*
             * Sourced from VPT Accounts person data
             */
            SourceOrganizationID = person.SourceOrganizationID;
            Auth0UserID = person.Auth0UserID;
            FirstName = person.FirstName;
            MiddleName = person.MiddleName;
            LastName = person.LastName;
            BirthDate = person.BirthDate;
            GenderID = person.GenderID;
            RaceID = person.RaceID;
            ImageURL = person.ImageURL;
            ImageSrc = person.ImageSrc;
            personID = person.PersonID;
            SubjectPortalUsername = person.SubjectPortalUsername;
            PersonGUID = person.PersonGUID;
            //email
            if (person.Contacts.Any())
            {
                var primaryEmail = person.Contacts.FirstOrDefault(c => c.Primary && c.TypeID == (int)ContactType.Email);
                PrimaryEmail = primaryEmail != null ? primaryEmail.Value : string.Empty;
            }
            else
            {
                PrimaryEmail = string.Empty;
            }

            //phone
            if (person.Contacts.Any())
            {
                var primaryPhone = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.Phone);
                PrimaryPhone = primaryPhone != null ? primaryPhone.Value : string.Empty;
            }
            else
            {
                PrimaryPhone = string.Empty;
            }

            //mobile
            if (person.Contacts.Any())
            {
                var primaryMobile = person.Contacts.FirstOrDefault(c => c.TypeID == (int)ContactType.Mobile);
                PrimaryMobile = primaryMobile != null ? primaryMobile.Value : string.Empty;
            }
            else
            {
                PrimaryMobile = string.Empty;
            }


            if (person.ExternalIDs.Any())
            {
                var sorExternalID = person.ExternalIDs.FirstOrDefault(e => e.Type == SystemControlledExternalIDType.SystemOfRecord);
                SORExternalID = sorExternalID != null ? sorExternalID.Value : string.Empty;
                var fbiID = person.ExternalIDs.FirstOrDefault(e => e.Type == SystemControlledExternalIDType.FbiID);
                FBIID = fbiID != null ? fbiID.Value : string.Empty;
                var sID = person.ExternalIDs.FirstOrDefault(e => e.Type == SystemControlledExternalIDType.SID);
                SID = sID != null ? sID.Value : string.Empty;
            }
            else
            {
                SORExternalID = string.Empty;
                FBIID = string.Empty;
                SID = string.Empty;
            }

            Groups = new List<string>();
            foreach (var group in person.Groups)
            {
                Groups.Add(group.DisplayName);
            }

            /*
             * Sourced from VPT Case Mgmt subject data
             */
            SubjectUserID = assessment == null ? 0 : assessment.SubjectUserID;
            subjectAssessment = assessment == null ? null : new SubjectAssessmentDTO(assessment);
        }

        /**********************************************************************
         ** Sourced from VPT Accounts person data
         */

        /// <summary>
        /// The original organization that created the person.
        /// </summary>
        [JsonProperty("sourceOrganizationID")]
        public int SourceOrganizationID { get; set; }

        /// <summary>
        /// The Auth0 User ID for the person.
        /// </summary>
        [JsonProperty("auth0UserID")]
        public string Auth0UserID { get; set; }

        /// <summary>
        /// The first name of the person
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the person
        /// </summary>
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The full name of the person in first name first format
        /// </summary>
        [JsonProperty("fullNameFirstNameFirstFormat")]
        public string FullNameFirstNameFirstFormat => FirstName + " " + LastName;


        /// <summary>
        /// The full name of the person in last name first format
        /// </summary>
        [JsonProperty("fullNameLastNameFirstFormat")]
        public string FullNameLastNameFirstFormat => LastName + ", " + FirstName;

        /// <summary>
        /// The full name of the person in first middle and last name format
        /// </summary>
        [JsonProperty("fullNameFirstMiddleLastNameFormat")]
        public string fullNameFirstMiddleLastNameFormat => FirstName +' '+ MiddleName +' '+ LastName;

        /// <summary>
        /// The optional Birth Date of the person
        /// </summary>
        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The age of the person
        /// </summary>
        [JsonProperty("age")]
        public int Age
        {
            get
            {
                if (!BirthDate.HasValue) return 0;

                int age = DateTime.Now.Year - BirthDate.Value.Year;
                if (DateTime.Now.Month < BirthDate.Value.Month || (DateTime.Now.Month == BirthDate.Value.Month && DateTime.Now.Day < BirthDate.Value.Day)) age--;
                return age;
            }
        }

        /// <summary>
        /// The ID of the gender for this person <see cref="Gender"/> for valid settings
        /// </summary>
        [JsonProperty("genderID")]
        public int GenderID { get; set; }

        /// <summary>
        /// The Name of the gender for this person <see cref="Gender"/> for valid settings
        /// </summary>
        [JsonProperty("genderName")]
        public string GenderName => GenderConstants.GetByEnum(GenderID);

        /// <summary>
        /// The ID of the Race for this person <see cref="Race"/> for valid settings
        /// </summary>
        [JsonProperty("raceID")]
        public int RaceID { get; set; }

        /// <summary>
        /// The Name of the Race for this person <see cref="Race"/> for valid settings
        /// </summary>
        [JsonProperty("raceName")]
        public string RaceName => RaceConstants.GetByEnum(RaceID);

        /// <summary>
        /// The URL to access for the person's picture or avatar image
        /// </summary>
        [JsonProperty("imageURL")]
        public string ImageURL { get; set; }

        /// <summary>
        /// The primary email from the VTP Account Contacts entries
        /// </summary>
        [JsonProperty("email")]
        public string PrimaryEmail { get; set; }

        /// <summary>
        /// The primary email from the VTP Account Contacts entries
        /// </summary>
        [JsonProperty("phone")]
        public string PrimaryPhone { get; set; }

        /// <summary>
        /// The primary email from the VTP Account Contacts entries
        /// </summary>
        [JsonProperty("mobile")]
        public string PrimaryMobile { get; set; }

        /// <summary>
        /// The secondary email from the VTP Account Contacts entries
        /// </summary>
        [JsonProperty("secondaryEmail")]
        public string SecondaryEmail { get; set; }

        /// <summary>
        /// The primary SOR External ID from VPT External IDs entries
        /// </summary>
        [JsonProperty("externalID")]
        public string SORExternalID { get; set; }

        /// <summary>
        /// The groups the subject is a member of
        /// </summary>
        [JsonProperty("groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// The personID
        /// </summary>
        [JsonProperty("personID")]
        public int personID { get; set; }

        /// <summary>
        /// SubjectPortal username
        /// </summary>
        [JsonProperty("subjectPortalUsername")]
        public string SubjectPortalUsername { get; set; }

        /// <summary>
        /// Person GUID
        /// </summary>
        [JsonProperty("personGUID")]
        public Guid PersonGUID { get; set; }


        /**********************************************************************
         ** Sourced from VPT Case Management subject data
         */

        /// <summary>
        /// The person ID for the subject
        /// </summary>
        [JsonProperty("subjectUserID")]
        public int SubjectUserID { get; set; }

        /// <summary>
        /// The subject validation pin for new program/job linkages
        /// </summary>
        [JsonProperty("facilityID")]
        public int FacilityID { get; set; }

        /// <summary>
        /// The estimated release date for the subject
        /// </summary>
        [JsonProperty("estimatedReleaseDate")]
        public string EstimatedReleaseDate { get; set; }

        /// <summary>
        /// User Id of Agent
        /// </summary>
        [JsonProperty("agentUserID")]
        public string AgentUserID { get; set; }

        [JsonProperty("imageSrc")]
        public string ImageSrc { get; set; }

        /// <summary>
        /// The primary case manager id
        /// </summary>
        [JsonProperty("caseManagerID")]
        public string CaseManagerID { get; set; }

        public SubjectAssessmentDTO subjectAssessment { get; set; }

        /// <summary>
        /// The primary case manager name
        /// </summary>
        [JsonProperty("caseManagerName")]
        public string CaseManagerName { get; set; }

        /// <summary>
        /// The CustodyLevel
        /// </summary>
        [JsonProperty("custodyLevel")]
        public string CustodyLevel { get; set; }

        /// <summary>
        /// The SupervisionLevel
        /// </summary>
        [JsonProperty("supervisionLevel")]
        public string SupervisionLevel { get; set; }

        /// <summary>
        /// The PendingCharges
        /// </summary>
        [JsonProperty("pendingCharges")]
        public string PendingCharges { get; set; }

        /// <summary>
        /// The SexOffenderType
        /// </summary>
        [JsonProperty("sexOffenderType")]
        public string SexOffenderType { get; set; }

        /// <summary>
        /// The CaseType
        /// </summary>
        [JsonProperty("caseType")]
        public string CaseType { get; set; }

        /// <summary>
        /// The FacilityCode
        /// </summary>
        [JsonProperty("facilityCode")]
        public string FacilityCode { get; set; }

        /// <summary>
        /// The SecurityThreatGroupName
        /// </summary>
        [JsonProperty("securityThreatGroupName")]
        public string STG { get; set; }

        [JsonProperty("SecurityThreatGroupId")]
        public string SecurityThreatGroupId { get; set; }
        [JsonProperty("SecurityThreatGroupAssessment")]
        public string SecurityThreatGroupAssessment { get; set; }

        [JsonProperty("SecurityThreatGroupRank")]
        public string SecurityThreatGroupRank { get; set; }

        [JsonProperty("SecurityThreatGroupStatus")]
        public string SecurityThreatGroupStatus { get; set; }

        [JsonProperty("SecurityThreatGroupStatusDate")]
        public string SecurityThreatGroupStatusDate { get; set; }
        /// <summary>
        /// The ISCSentences
        /// </summary>
        [JsonProperty("iscSentences")]
        public string ISCSentences { get; set; }

        /// <summary>
        /// The FullAddress
        /// </summary>
        [JsonProperty("fullAddress")]
        public string FullAddress { get; set; }

        /// <summary>
        /// The OffenderSiteType
        /// </summary>
        [JsonProperty("offenderSiteType")]
        public string OffenderSiteType { get; set; }

        /// <summary>
        /// The Overall Risk
        /// </summary>
        [JsonProperty("overallRisk")]
        public string OverallRisk { get; set; }

        /// <summary>
        /// GTL Site ID
        /// </summary>
        [JsonProperty("gtlSiteID")]
        public string GTLSiteID { get; set; }

        /// <summary>
        /// Get FBIID
        /// </summary>
        [JsonProperty("FbiID")]
        public string FBIID { get; set; }

        /// <summary>
        /// Get SID
        /// </summary>
        [JsonProperty("SID")]
        public string SID { get; set; }

        /// <summary>
        /// user custom property values
        /// </summary>
        [JsonProperty("userCustomProperty")]
        public UserCustomPropertyShortDTO UserCustomProperty { get; set; }

        /// <summary>
        /// The FacilityName
        /// </summary>
        [JsonProperty("facilityName")]
        public string FacilityName { get; set; }


    }
}
