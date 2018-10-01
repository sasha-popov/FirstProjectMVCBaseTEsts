using NLayerApp.DAL.EF;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NLayerApp.DAL.Repositories
{
    public class CustomerOfferRepository : IRepository<CustomerOffer>
    {
        private SearchContext db;

        public CustomerOfferRepository(SearchContext context)
        {
            this.db = context;
        }

        public IEnumerable<CustomerOffer> GetAll()
        {
            return db.CustomerOffers;
        }

        public CustomerOffer Get(int id)
        {
            return db.CustomerOffers.Find(id);
        }

        public void Create(CustomerOffer customerOffer)
        {
            db.CustomerOffers.Add(customerOffer);
        }

        public void Update(CustomerOffer book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<CustomerOffer> Find(Func<CustomerOffer, bool> predicate)
        {
            return db.CustomerOffers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            CustomerOffer co = db.CustomerOffers.Find(id);
            if (co != null)
                db.CustomerOffers.Remove(co);
        }

        public IEnumerable<CustomerOffer> FindWithCompanyOffer(Func<CompanyOffer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public CustomerOffer GetUserID(string id)
        {
            throw new NotImplementedException();
        }
    }
}