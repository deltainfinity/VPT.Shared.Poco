using NPoco;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("VIDS_User")]
    [PrimaryKey("VIDS_UserID")]
    public class VidsUserDetail
    {
        public VidsUserDetail()
        { }

        public VidsUserDetail(VidsUserDetailDTO source)
            
        {
            VIDS_UserID = source.VIDS_UserID;
            Username = source.Username;
            PersonID = source.PersonID;
            Id = source.Id;
            Password = source.Password;
            Other = source.Other;
            Email = source.Email;
        }

        public int VIDS_UserID { get; set; }

        public string Username { get; set; }

        public string Id { get; set; }

        public string Other { get; set; }

        public byte[] Password { get; set; }

        public string Email { get; set; }

        public int? PersonID { get; set; }
    }
}
