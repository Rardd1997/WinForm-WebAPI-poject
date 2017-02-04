using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Domain.Entities;

namespace Server.Domain.Concrete
{
    public class AdoNetDbContext
    {
        private DataContext context;

        public Table<Profile> Profiles => context.GetTable<Profile>();
        public Table<UserLevel> UserLevels => context.GetTable<UserLevel>();
        public Table<Function> Functions => context.GetTable<Function>();
        public Table<LevelFunction> LevelFunctions => context.GetTable<LevelFunction>();

        public AdoNetDbContext()
        {
            context = new DataContext(ConfigurationManager.ConnectionStrings["AccountDB"].ConnectionString);
        }

        public void SaveChanges()
        {
            context.SubmitChanges();
        }
    }
}
