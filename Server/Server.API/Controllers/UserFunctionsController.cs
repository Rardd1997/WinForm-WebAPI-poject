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
    public class UserFunctionsController : ApiController
    {
        private IDbRepository repository;

        public UserFunctionsController(IDbRepository dbRepository)
        {
            repository = dbRepository;
        }

        [HttpGet]
        [ActionName("GetUserFunctionByID")]
        public IEnumerable<Function> GetFunctions(int? id = null)
        {
            try
            {
                return repository.Functions.Where(f => id == null || f.FunctionID == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ActionName("PostFunction")]
        public HttpResponseMessage PostFunction([FromBody]Function function)
        {
            try
            {
                repository.SaveFunction(function);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [HttpPut]
        [ActionName("PutFunction")]
        public HttpResponseMessage PutFunction(int id, [FromBody] Function function)
        {
            try
            {
                if (function == null) return Request.CreateResponse(HttpStatusCode.ExpectationFailed);
                repository.SaveFunction(function);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [HttpDelete]
        [ActionName("DeleteFunction")]
        public HttpResponseMessage DeleteFunction(int id)
        {
            try
            {
                repository.DeleteFunction(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception exc)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }
    }
}
