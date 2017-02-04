﻿using System;
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
        public IQueryable<UserLevel> UserLevels => context.UserLevels;
        public IQueryable<Function> Functions => context.Functions;
        public IQueryable<LevelFunction> LevelFunctions => context.LevelFunctions;

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
