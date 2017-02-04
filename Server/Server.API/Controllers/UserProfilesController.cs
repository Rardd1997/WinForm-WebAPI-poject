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
        public HttpResponseMessage GetProfile(int? id = null)
        {
            try
            {
                return Request.CreateResponse<IEnumerable<Profile>>(HttpStatusCode.OK, repository.Profiles.Where(p => id == null || p.ProfileID == id));
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [HttpPost]
        [ActionName("PostProfile")]
        public HttpResponseMessage PostProfile([FromBody]Profile profile)
        {
            try
            {
                repository.SaveProfile(profile);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }}

        [HttpPut]
        [ActionName("PutProfile")]
        public HttpResponseMessage PutProfile(int id, [FromBody] Profile profile)
        {
            try
            {
                if (profile == null) return Request.CreateResponse(HttpStatusCode.ExpectationFailed);
                repository.SaveProfile(profile);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [HttpDelete]
        [ActionName("DeleteProfile")]
        public HttpResponseMessage DeleteProfile(int id)
        {
            try
            {
                repository.DeleteProfile(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

    }
}