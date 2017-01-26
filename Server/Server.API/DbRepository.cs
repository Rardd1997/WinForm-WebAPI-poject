using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Server.Domain.Abstract;
using Server.Domain.Concrete;

namespace Server.API
{
    public class DbRepository
    {
        public static IDbRepository Repository = new AdoNetDbRepository();
    }
}