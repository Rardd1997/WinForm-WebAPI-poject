using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Domain.Entities;

namespace Server.Domain.Concrete
{
    class EFDBContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}
