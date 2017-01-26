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
