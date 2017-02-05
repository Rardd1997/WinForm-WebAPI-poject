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
    public class LevelFunctionsController : ApiController
    {
        private IDbRepository repository;

        public LevelFunctionsController(IDbRepository dbRepository)
        {
            repository = dbRepository;
        }

        [HttpGet]
        [ActionName("GetLevelFunctionsByLevelID")]
        public IEnumerable<LevelFunction> GetLevelFunctions(int? levelID = null)
        {
            try
            {
                return repository.LevelFunctions.Where(lf => levelID == null || lf.UserLevelID == levelID);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ActionName("PostLevelFunction")]
        public HttpResponseMessage PostLevelFunction([FromBody]LevelFunction levelFunction)
        {
            try
            {
                repository.SaveLevelFunction(levelFunction);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [HttpPut]
        [ActionName("PutLevelFunction")]
        public HttpResponseMessage PutLevelFunction(int id, [FromBody] LevelFunction levelFunction)
        {
            try
            {
                if (levelFunction == null) return Request.CreateResponse(HttpStatusCode.ExpectationFailed);
                repository.SaveLevelFunction(levelFunction);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [HttpDelete]
        [ActionName("DeleteLevelFunction")]
        public HttpResponseMessage DeleteLevelFunction(int id)
        {
            try
            {
                repository.DeleteLevelFunction(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }
    }
}
