using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Domain.Entities;

namespace Server.Domain.Abstract
{
    public interface IDbRepository 
    {
        IQueryable<Profile> Profiles { get; }
        void SaveProfile(Profile profile);
        Profile DeleteProfile(int id);
        IQueryable<UserLevel> UserLevels { get; }
        IQueryable<Function> Functions { get; }
        IQueryable<LevelFunction> LevelFunctions { get; }
        void SaveChanges();
    }
}
