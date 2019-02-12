using NPoco;
using System;

namespace VPT.Shared.Poco.Model.API
{
    [TableName("File")]
    [PrimaryKey("FileID")]
    public class File 
    {
        public File()
        { }
        
        public int FileID { get; set; }

        public string Name { get; set; }

        public string Extension { get; set; }

        public string Path { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedByUserID { get; set; }

        public Guid FileName { get; set; }
    }
}
