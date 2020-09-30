using Basic.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Models.EntityConfiguration
{
    public class CompanyCfg : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasMany(p => p.Shops)
                 .WithOne(p => p.Company)
                 .HasForeignKey(p => p.CompanyId);
        }
    }
}
