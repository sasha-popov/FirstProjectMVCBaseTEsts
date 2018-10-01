using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NLayerApp.DAL.Entities;

namespace NLayerApp.DAL.EF
{
    public class SearchContext : DbContext
    {
        public SearchContext(string connectionString)
            : base(connectionString)
        {
        }

        //public SearchContext(string connectionString) : base("DbConnection")
        //{
        //    Configuration.LazyLoadingEnabled = true;
        //}
        public DbSet<Company> Companies { get; set; }
        public DbSet<Executer> Executers { get; set; }

        public DbSet<CustomerOffer> CustomerOffers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Offer> Offers { get; set; }

        public DbSet<CompanyOffer> CompanyOffers { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}