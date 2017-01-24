using System;

namespace Server.API.Entities
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public int UserLevelID { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Email { get; set; }
    }
}