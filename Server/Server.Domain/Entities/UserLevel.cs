using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain.Entities
{
    [Table(Name = "user_levels")]
    public class UserLevel
    {
        [Column(Name = "level_id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int LevelID { get; set; }
        [Column(Name = "level_name")]
        public string LevelName { get; set; }
        [Column(Name = "level_description")]
        public string LevelDescription { get; set; }
    }
}
