using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CSharp.Model;

namespace CSharp.Data
{
    public class AwardConfiguration : EntityTypeConfiguration<Award>
    {
        public AwardConfiguration()
        {
            ToTable("Award");
            Property(p => p.AwardId).IsRequired();
            Property(p => p.Title).IsRequired().HasMaxLength(50);
            Property(p => p.AwardDate).IsRequired();
            Property(p => p.LastModifiedDate).IsRequired();
        }
    }
}
