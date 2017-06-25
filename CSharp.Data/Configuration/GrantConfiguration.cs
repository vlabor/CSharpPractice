using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CSharp.Model;

namespace CSharp.Data
{
    public class GrantConfiguration : EntityTypeConfiguration<Grant>
    {
        public GrantConfiguration()
        {
            ToTable("Grant");
            Property(p => p.GrantId).IsRequired();
            Property(p => p.AwardId).IsRequired();
            Property(p => p.GrantAmount).IsOptional();
        }
    }
}
