using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Domain.Entities
{
    [Table(Name = "function_master")]
    public class Function
    {
        [Column(Name = "function_id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int FunctionID { get; set; }
        [Column(Name = "function_name")]
        public string FunctionName { get; set; }
        [Column(Name = "function_code")]
        public string FunctionCode { get; set; }
    }
}
