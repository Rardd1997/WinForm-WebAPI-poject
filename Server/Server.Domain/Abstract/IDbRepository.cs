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
        IList<Profile> Profiles { get; }

        void SaveChanges();
    }
}
