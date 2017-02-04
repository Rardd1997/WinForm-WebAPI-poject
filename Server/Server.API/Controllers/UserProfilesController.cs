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
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ActionName("PostProfile")]
        public void PostProfile([FromBody]Profile profile)
        {
            repository.Profiles.ToList().Add(profile);
            repository.SaveChanges();
        }

        [HttpPut]
        [ActionName("PutProfile")]
        public void PutProfile(int id, [FromBody] Profile profile)
        {
            if (profile == null) return;

            List<Profile> profiles = repository.Profiles.ToList();

            if (id == profile.ProfileID)
            {
                profiles.Remove(repository.Profiles.First(p => p.ProfileID == id));
                profiles.Add(profile);
                repository.SaveChanges();
            }
        }
   
    }
}
