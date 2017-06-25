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
    public class GrantRepository : RepositoryBase<Grant> , IGrantRepository
    {
        public GrantRepository(IDbFactory dbFactory) : base (dbFactory) { }

        public Grant GetGrantByAwardId(int awardId)
        {
            return DbContext.Grants.Where(g => g.AwardId == awardId).FirstOrDefault();
        }

        public override void Update(Grant grant)
        {
            grant.DateUpdated = DateTime.Now;
            base.Update(grant);
        }
    }
}
