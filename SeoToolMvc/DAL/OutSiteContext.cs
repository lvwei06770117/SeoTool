using SeoToolMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SeoToolMvc.DAL
{
    public class OutSiteContext : DbContext
    {
        public OutSiteContext()
            : base("SeoToolContext")
        {
        }

        public DbSet<OutSite> OutSites { get; set; }
        public DbSet<OutSiteLogin> OutSiteLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}