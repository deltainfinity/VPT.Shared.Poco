using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    public class AdminUser
    {
        
        /// <summary>
        /// The user's username. Only valid if the connection requires a username
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The user's password (mandatory for non SMS connections)
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// The user's email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The User's first name
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The User's last name
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The User's full name
        /// </summary>
        [JsonProperty("name")]
        public string FullName => FirstName + " " + LastName;

        /// <summary>
        /// Client specific data about the user see https://auth0.com/docs/user-profile/normalized for examples
        /// </summary>

    }
}

