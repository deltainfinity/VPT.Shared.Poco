using System;
using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.Accounts;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class PersonDTO : BaseDatabaseDTO
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PersonDTO()
        { }

        /// <summary>
        /// Copy constructor to populate the object
        /// </summary>
        /// <param name="source">The source Person entity for the DTO</param>
        public PersonDTO(Person source, string image = "")
            : base(source)
        {
            PersonID = source.PersonID;
            SourceOrganizationID = source.SourceOrganizationID;
            Auth0UserID = source.Auth0UserID;
            FirstName = source.FirstName;
            MiddleName = source.MiddleName;
            LastName = source.LastName;
            Title = source.Title;
            BirthDate = source.BirthDate;
            GenderID = source.Gender;
            RaceID = source.Race;
            ImageURL = source.ImageURL;
            ImageSrc = image;
            FileID = source.FileID;
            FacilityCode = source.FacilityCode;
            IsSuperAdmin = source.IsSuperAdmin;
            PersonGUID = source.PersonGUID;
            SubjectPortalUsername = source.SubjectPortalUsername;
        }

        /// <summary>
        /// The ID of the person
        /// </summary>
        [JsonProperty("personID")]
        public int PersonID { get; set; }

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
        /// The Title for the person
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The optional Birth Date of the person
        /// </summary>
        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The age of the person
        /// </summary>
        public int Age
        {
            get
            {
                if (!BirthDate.HasValue) return 0;

                int age = DateTime.Now.Year - BirthDate.Value.Year;
                if (DateTime.Now.Month < BirthDate.Value.Month || (DateTime.Now.Month == BirthDate.Value.Month && DateTime.Now.Day < BirthDate.Value.Day))
                {
                    age--;
                }

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
        /// The ID of the person
        /// </summary>
        [JsonProperty("fileID")]
        public int FileID { get; set; }

        [JsonProperty("imageSrc")]
        public string ImageSrc { get; set; }

        /// <summary>
        /// FacilityCode
        /// </summary>
        [JsonProperty("facilityCode")]
        public string FacilityCode { get; set; }

        [JsonProperty("isSuperAdmin")]
        public bool IsSuperAdmin { get; set; }

        [JsonProperty("personGUID")]
        public Guid PersonGUID { get; set; }

        [JsonProperty("subjectPortalUsername")]
        public string SubjectPortalUsername { get; set; }
    }
}

