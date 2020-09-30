using Basic.Api.Models.Domain;
using Basic.Api.Models.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Api.Data
{
    public class BasicContext: DbContext
    {
        public BasicContext(DbContextOptions<BasicContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies(false);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyCfg());
            modelBuilder.ApplyConfiguration(new ShopCfg());
        }

        public DbSet<Company> Companys { get; set; }
        public DbSet<Shop> Shops { get; set; }
    }
}
