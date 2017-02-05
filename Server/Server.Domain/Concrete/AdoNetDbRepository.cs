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
        public void SaveProfile(Profile profile)
        {
            if (profile.ProfileID == 0)
            {
                context.Profiles.InsertOnSubmit(profile);
            }
            else
            {
                Profile dbProfile = context.Profiles.First(p => p.ProfileID == profile.ProfileID);
                dbProfile.FirstName = profile.FirstName;
                dbProfile.LastName = profile.LastName;
                dbProfile.Password = profile.Password;
                dbProfile.LastLogin = profile.LastLogin;
                dbProfile.LastUpdate = profile.LastUpdate;
                dbProfile.Email = profile.Email;
                dbProfile.Status = profile.Status;
                dbProfile.UserLevelID = profile.UserLevelID;
            }
            context.SaveChanges();
        }

        public Profile DeleteProfile(int id)
        {
            Profile dbProfile = context.Profiles.First(p => p.ProfileID == id);
            if (dbProfile != null)
            {
                context.Profiles.DeleteOnSubmit(dbProfile);
                context.SaveChanges();
            }
            return dbProfile;
        }

        public IQueryable<UserLevel> UserLevels => context.UserLevels;

        public void SaveUserLevel(UserLevel level)
        {
            if (level.LevelID == 0)
            {
                context.UserLevels.InsertOnSubmit(level);
            }
            else
            {
                UserLevel dbLevel = context.UserLevels.First(l => l.LevelID == level.LevelID);
                dbLevel.LevelName = level.LevelName;
                dbLevel.LevelDescription = level.LevelDescription;
            }
            context.SaveChanges();
        }

        public UserLevel DeleteUserLevel(int id)
        {
            UserLevel dbLevel = context.UserLevels.First(l => l.LevelID == id);
            if (dbLevel != null)
            {
                context.UserLevels.DeleteOnSubmit(dbLevel);
                context.SaveChanges();
            }
            return dbLevel;
        }

        public IQueryable<Function> Functions => context.Functions;

        public void SaveFunction(Function function)
        {
            if (function.FunctionID == 0)
            {
                context.Functions.InsertOnSubmit(function);
            }
            else
            {
                Function dbFunction = context.Functions.First(f => f.FunctionID == function.FunctionID);
                dbFunction.FunctionName = function.FunctionName;
                dbFunction.FunctionCode = function.FunctionCode;
            }
            context.SaveChanges();
        }

        public Function DeleteFunction(int id)
        {
            Function dbFunction = context.Functions.First(f => f.FunctionID == id);
            if (dbFunction != null)
            {
                context.Functions.DeleteOnSubmit(dbFunction);
                context.SaveChanges();
            }
            return dbFunction;
        }

        public IQueryable<LevelFunction> LevelFunctions => context.LevelFunctions;

        public void SaveLevelFunction(LevelFunction levelFunction)
        {
            if (levelFunction.RecordID == 0)
            {
                context.LevelFunctions.InsertOnSubmit(levelFunction);
            }
            else
            {
                LevelFunction dbLevelFunction = context.LevelFunctions.First(lf => lf.RecordID == levelFunction.RecordID);
                dbLevelFunction.FunctionID = levelFunction.FunctionID;
                dbLevelFunction.UserLevelID = levelFunction.UserLevelID;
            }
            context.SaveChanges();
        }

        public LevelFunction DeleteLevelFunction(int id)
        {
            LevelFunction dbLevelFunction = context.LevelFunctions.First(lf => lf.RecordID == id);
            if (dbLevelFunction != null)
            {
                context.LevelFunctions.DeleteOnSubmit(dbLevelFunction);
                context.SaveChanges();
            }
            return dbLevelFunction;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }

}
