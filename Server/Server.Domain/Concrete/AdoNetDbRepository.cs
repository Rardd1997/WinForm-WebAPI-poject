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

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }

}
