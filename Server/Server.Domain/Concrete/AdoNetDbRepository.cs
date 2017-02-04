using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Domain.Abstract;
using Server.Domain.Entities;

namespace Server.Domain.Concrete
{
    public class AdoNetDbRepository : IDbRepository
    {
        private AdoNetDbContext context = new AdoNetDbContext();

        public IQueryable<Profile> Profiles => context.Profiles;
        public IQueryable<UserLevel> UserLevels => context.UserLevels;
        public IQueryable<Function> Functions => context.Functions;
        public IQueryable<LevelFunction> LevelFunctions => context.LevelFunctions;

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }

}
