using System;
using Newtonsoft.Json;
using VPT.Shared.Poco.Enum.Accounts;
using VPT.Shared.Poco.Model.Accounts.Database;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class VidsUserDetailDTO
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public VidsUserDetailDTO()
        { }

        /// <summary>
        /// Copy constructor to populate the object
        /// </summary>
        /// <param name="source">The source Person entity for the DTO</param>
        public VidsUserDetailDTO(VidsUserDetail source)
        {
            VIDS_UserID = source.VIDS_UserID;
            Username = source.Username;
            PersonID = source.PersonID;
            Id = source.Id;
            Password = source.Password;
            Other = source.Other;
            Email = source.Email;
        }

        /// <summary>
        /// The External ID of the integrated system
        /// </summary>
        [JsonProperty("VIDS_UserID")]
        public int VIDS_UserID { get; set; }

        /// <summary>
        /// The id of that created the person.
        /// </summary>
        [JsonProperty("Username")]
        public string Username { get; set; }

        /// <summary>
        /// The ID for the person.
        /// </summary>
        [JsonProperty("Id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the person
        /// </summary>
        [JsonProperty("Other")]
        public string Other { get; set; }

        /// <summary>
        /// The password of the person
        /// </summary>
        [JsonProperty("password")]
        public byte[] Password { get; set; }

        /// <summary>
        /// DateCreated
        /// </summary>
        [JsonProperty("Email")]
        public string Email { get; set; }

        /// <summary>
        /// CreatedByUserID
        /// </summary>
        [JsonProperty("PersonID")]
        public int? PersonID { get; set; }
      
    }
}
