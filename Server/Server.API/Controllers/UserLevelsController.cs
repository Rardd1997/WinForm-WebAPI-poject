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
    }
}
