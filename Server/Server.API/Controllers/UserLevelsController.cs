using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Server.Domain.Abstract;
using Server.Domain.Entities;

namespace Server.API.Controllers
{
    public class UserLevelsController : ApiController
    {
        private IDbRepository repository;

        public UserLevelsController(IDbRepository dbRepository)
        {
            repository = dbRepository;
        }

        [HttpGet]
        [ActionName("GetUserLevelByID")]
        public IEnumerable<UserLevel> GetUserLevel(int? id = null)
        {
            try
            {
                return repository.UserLevels.Where(l => id == null || l.LevelID == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ActionName("PostUserLevel")]
        public HttpResponseMessage PostUserLevel([FromBody]UserLevel level)
        {
            try
            {
                repository.SaveUserLevel(level);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [HttpPut]
        [ActionName("PutUserLevel")]
        public HttpResponseMessage PutUserLevel(int id, [FromBody] UserLevel userLevel)
        {
            try
            {
                if (userLevel == null) return Request.CreateResponse(HttpStatusCode.ExpectationFailed);
                repository.SaveUserLevel(userLevel);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [HttpDelete]
        [ActionName("DeleteUserLevel")]
        public HttpResponseMessage DeleteUserLevel(int id)
        {
            try
            {
                repository.DeleteUserLevel(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

    }
}
