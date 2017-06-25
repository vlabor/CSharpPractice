using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CSharp.Data.Mock;

namespace CSharp.Data
{
    public class CSharpPopulateTestData : DropCreateDatabaseIfModelChanges<CSharpEntities>
    {
        protected override void Seed(CSharpEntities context)
        {
            AwardMock.GetAwards().ForEach(a => context.Awards.Add(a));
            GrantMock.GetGrants().ForEach(g => context.Grants.Add(g));

            context.Commit();
        }
    }
}
