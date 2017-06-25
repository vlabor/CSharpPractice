using CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Data.Mock
{
    public class AwardMock
    {
        public static List<Award> GetAwards()
        {
            return new List<Award>
            {
                new Award{Title="HIV Drugs Support", AwardDate=new DateTime(2017,06,09)},
                new Award{Title="AIDS Educational Support", AwardDate=new DateTime(2017, 08, 06)},
                new Award {Title="Hospital Visits", AwardDate=new DateTime(2017, 2,12) }
            };
        }
    }
}
