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
        void SaveUserLevel(UserLevel level);
        UserLevel DeleteUserLevel(int id);

        IQueryable<Function> Functions { get; }
        void SaveFunction(Function function);
        Function DeleteFunction(int id);

        IQueryable<LevelFunction> LevelFunctions { get; }
        void SaveLevelFunction(LevelFunction lFunction);
        LevelFunction DeleteLevelFunction(int id);

        void SaveChanges();
    }
}
