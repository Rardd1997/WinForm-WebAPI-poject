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
                throw;
            }
        }
    }
}
