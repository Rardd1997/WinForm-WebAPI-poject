using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Domain.Abstract;
using Server.Domain.Entities;

namespace Server.Domain.Concrete
{
    class EFDBRepository : IDbRepository
    {
        EFDBContext context = new EFDBContext();

        public IQueryable<Profile> Profiles => context.Profiles;
        public void SaveProfile(Profile profile)
        {
            if (profile.ProfileID == 0)
            {
                context.Profiles.Add(profile);
            }
            else
            {
                Profile dbProfile = context.Profiles.Find(profile.ProfileID);
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
            Profile dbProfile = context.Profiles.Find(id);
            if (dbProfile != null)
            {
                context.Profiles.Remove(dbProfile);
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
