using CSharp.Data;
using CSharp.Infrastructure;
using CSharp.Model;
using CSharp.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Repositories
{
    public class AwardRepository : RepositoryBase<Award>, IAwardRepository
    {
        public AwardRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
