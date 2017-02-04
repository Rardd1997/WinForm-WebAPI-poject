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
        public IQueryable<Function> Functions => context.Functions;
        public IQueryable<LevelFunction> LevelFunctions => context.LevelFunctions;

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }

}
