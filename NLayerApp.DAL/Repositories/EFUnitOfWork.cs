using NLayerApp.DAL.EF;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Entities.Interfaces;
using NLayerApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private SearchContext db;
        private CustomerOfferRepository customerOfferRepository;
        private CategoryRepository categoryRepository;
        private CompanyRepository companyRepository;
        private CustomerRepository customerRepository;
        private CompanyOfferRepository companyOfferRepository;
        private OfferRepository offerRepository;


        public EFUnitOfWork(string connectionString)
        {
            db = new SearchContext(connectionString);
        }

        public IRepository<CustomerOffer> CustomerOffers
        {
            get
            {
                if (customerOfferRepository == null)
                    customerOfferRepository = new CustomerOfferRepository(db);
                return customerOfferRepository;
            }

        }

        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(db);
                return categoryRepository;
            }

        }
        public IRepository<Company> Companies
        {
            get
            {
                if (companyRepository == null)
                    companyRepository = new CompanyRepository(db);
                return companyRepository;
            }

        }

        public IRepository<Customer> Customers
        {
            get
            {
                if (customerRepository == null)
                    customerRepository = new CustomerRepository(db);
                return customerRepository;
            }
        }

        public IRepository<CompanyOffer> CompanyOffers
        {
            get
            {
                if (companyOfferRepository == null)
                    companyOfferRepository = new CompanyOfferRepository(db);
                return companyOfferRepository;
            }
        }

        public IRepository<Offer> Offers
        {
            get
            {
                if (offerRepository == null)
                    offerRepository = new OfferRepository(db);
                return offerRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    db.Dispose();
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }


}
