using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.DTO.Accounts.Database
{
    public class Auth0UserInfoDTO
    {
        public string username { get; set; }
        public string email { get; set; }
        public string user_id { get; set; }
        public string sub { get; set; }
    }
}
