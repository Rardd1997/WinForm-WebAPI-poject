using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Server.Domain.Abstract;
using Server.Domain.Entities;

namespace Server.API.Controllers
{
    public class UserProfilesController : ApiController
    {
        private IDbRepository repository;

        public UserProfilesController(IDbRepository dbRepository)
        {
            repository = dbRepository;
        }

        [HttpGet]
        [ActionName("GetProfileByID")]
        public IEnumerable<Profile> GetProfile(int? id = null)
        {
            try
            {
                return repository.Profiles.Where(p => id == null || p.ProfileID == id);
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        [HttpPost]
        [ActionName("PostProfile")]
        public void PostProfile([FromBody]Profile profile)
        {
            repository.Profiles.Concat(new [] {profile});
            repository.SaveChanges();
        }

        [HttpPut]
        [ActionName("PutProfile")]
        public void PutProfile(int id, [FromBody] Profile profile)
        {
            if (profile == null) return;

            if (id == profile.ProfileID)
            {
                repository.Profiles.Where(p => p.ProfileID != id);
                repository.Profiles.Concat(new[] {profile});
                repository.SaveChanges();
            }
        }
   
    }
}
