using CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Service
{
    public interface IGrantService
    {
        IEnumerable<Grant> GetGrants();

        Grant GetGrant(int id);

        IEnumerable<Grant> GetGrantsByAward(int awardId);

        void CreateGrant(Grant grant);

        void SaveGrant();
    }
}
