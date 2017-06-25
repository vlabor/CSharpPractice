using CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Data.Mock
{
    public class GrantMock
    {
        public static List<Grant>GetGrants()
        {
            return new List<Grant>
            {
                new Grant{AgencyName="MD Public Health", GrantAmount=1200000},
                new Grant{AgencyName="NYC Health Services", GrantAmount=8500000},
                new Grant{AgencyName="NC Department of Health", GrantAmount=2530000}
            };
        }
    }
}
