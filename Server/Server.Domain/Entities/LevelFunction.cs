using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain.Entities
{

    [Table(Name = "user_level_tnx")]
    public class LevelFunction
    {
        [Column(Name = "record_id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int RecordID { get; set; }
        [Column(Name = "function_id")]
        public int FunctionID { get; set; }
        [Column(Name = "level_id")]
        public int UserLevelID { get; set; }
    }
}
