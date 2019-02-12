using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPT.Shared.Poco.Model.API.Tether
{
    [TableName("ProgramCatalog")]
    public class ProgramCatalogDetails : BaseModel
    {
        public int ProgramCatalogID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Dosage { get; set; }

    }
}
