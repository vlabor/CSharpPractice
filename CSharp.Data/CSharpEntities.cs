using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CSharp.Model;

namespace CSharp.Data
{
    public class CSharpEntities : DbContext
    {
        public CSharpEntities() : base("CSharpEntities")
        {

        }

        public DbSet<Award> Awards { get; set; }
        public DbSet<Grant> Grants { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AwardConfiguration());
            modelBuilder.Configurations.Add(new GrantConfiguration());
        }

    }
}
