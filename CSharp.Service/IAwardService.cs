using CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Service
{
    public interface IAwardService
    {
        IEnumerable<Award> GetAwards();

        Award GetAward(int id);
        Award GetAward(string title );

        void CreateAward(Award award);

        void SaveAward();
    }
}
