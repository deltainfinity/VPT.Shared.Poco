using NPoco;
using System;
using VPT.Shared.Poco.DTO.Accounts.Database;

namespace VPT.Shared.Poco.Model.Accounts.Database
{
    [TableName("ExternalSystemUserBridge")]
    [PrimaryKey("ExternalSystemUserBridgeID")]
    public class ExternalSystemUserBridge 
    {
        public ExternalSystemUserBridge()
        { }

        public ExternalSystemUserBridge(ExternalSystemUserBridgeDTO source)
            
        {
            ExternalSystemUserBridgeID = source.ExternalSystemUserBridgeID;
            ExternalUserID = source.ExternalUserID;
            PersonID = source.PersonID;
            DateCreated = source.DateCreated;
            CreatedByUserID = source.CreatedByUserID;
        }

        public int ExternalSystemUserBridgeID { get; set; }

        public string ExternalUserID { get; set; }

        public int PersonID { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedByUserID { get; set; }

    }

}
