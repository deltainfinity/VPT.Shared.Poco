using NPoco;
using System;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("Person")]
    [PrimaryKey("PersonID")]
    public class Person : BaseDatabaseModel
    {
        public Person()
        { }

        public Person(PersonDTO source)
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
            Gender = source.GenderID;
            Race = source.RaceID;
            ImageURL = source.ImageURL;
            FileID = source.FileID;
            FacilityCode = source.FacilityCode;
            PersonGUID = source.PersonGUID;
            SubjectPortalUsername = source.SubjectPortalUsername;
        }

        public int PersonID { get; set; }

        public int SourceOrganizationID { get; set; }

        public string Auth0UserID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime? BirthDate { get; set; }

        public int Gender { get; set; }

        public int Race { get; set; }

        public string ImageURL { get; set; }

        public int FileID { get; set; }

        public string FacilityCode { get; set; }

        public bool IsSuperAdmin { get; set; }

        public Guid PersonGUID { get; set; }

        public string SubjectPortalUsername { get; set; }
    }

}
