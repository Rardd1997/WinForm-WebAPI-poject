using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Server.Domain.Entities;

namespace Server.API.Controllers
{
    public class UserProfilesController : ApiController
    {
        [HttpGet]
        [ActionName("GetProfileByID")]
        public IEnumerable<Profile> GetProfile(int? id = null)
        {
            return DbRepository.Repository.Profiles.Where(p => id == null || p.ProfileID == id);
        }
   
    }
}
