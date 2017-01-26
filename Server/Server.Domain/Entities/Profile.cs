using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Domain.Abstract;
using System.Data.Linq.Mapping;

namespace Server.Domain.Entities
{
    [Table(Name = "user_profiles")]
    public class Profile
    {
        [Column(Name = "user_id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ProfileID { get; set; }
        [Column(Name = "first_name")]
        public string FirstName { get; set; }
        [Column(Name = "last_name")]
        public string LastName { get; set; }
        [Column(Name = "password")]
        public string Password { get; set; }
        [Column(Name = "status")]
        public int Status { get; set; }
        [Column(Name = "user_level_id")]
        public int UserLevelID { get; set; }
        [Column(Name = "last_login")]
        public DateTime LastLogin { get; set; }
        [Column(Name = "last_update")]
        public DateTime LastUpdate { get; set; }
        [Column(Name = "user_email")]
        public string Email { get; set; }
    }
}
