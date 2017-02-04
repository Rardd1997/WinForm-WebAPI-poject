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
    }
}
