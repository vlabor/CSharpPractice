using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Data;

namespace CSharp.Data
{
    public class DbFactory : Disposable, IDbFactory
    {
        CSharpEntities dbEntities;
        public CSharpEntities Init()
        {
            return dbEntities ?? (dbEntities = new CSharpEntities());
        }

        protected override void DisposeCore()
        {
            if (this.dbEntities != null)
                dbEntities.Dispose();
        }
    }
}
