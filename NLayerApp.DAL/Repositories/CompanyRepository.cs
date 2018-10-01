using NLayerApp.DAL.EF;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NLayerApp.DAL.Repositories
{
    class CompanyRepository:IRepository<Company>
    {
        private SearchContext db;

        public CompanyRepository(SearchContext context)
        {
            this.db = context;
        }

        public IEnumerable<Company> GetAll()
        {
            return db.Companies;
        }

        public Company Get(int id)
        {
            return db.Companies.Find(id);
        }

        public void Create(Company company)
        {
            db.Companies.Add(company);
        }

        public void Update(Company company)
        {
            db.Entry(company).State = EntityState.Modified;
        }

        public IEnumerable<Company> FindWithCompanyOffer(Func<CompanyOffer, bool> predicate)
        {
            IEnumerable<Company> a= db.CompanyOffers.Include(x => x.Offers).Where(predicate).SelectMany(x => x.Companies).ToList();
            return a;
        }

        public void Delete(int id)
        {
            Company co = db.Companies.Find(id);
            if (co != null)
                db.Companies.Remove(co);
        }


        public IEnumerable<Company> Find(Func<Company, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Company GetUserID(string id)
        {
            return db.Companies.FirstOrDefault(x => x.UserId == id);
        }
    }
}
