using NLayerApp.DAL.EF;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DAL.Repositories
{
    class OfferRepository : IRepository<Offer>
    {
        private SearchContext db;

        public OfferRepository(SearchContext context)
        {
            this.db = context;
        }

        public IEnumerable<Offer> GetAll()
        {
            return db.Offers;
        }

        public Offer Get(int id)
        {
            return db.Offers.Find(id);
        }

        public void Create(Offer offer)
        {
            db.Offers.Add(offer);
        }

        public void Update(Offer offer)
        {
            db.Entry(offer).State = EntityState.Modified;
        }

        public IEnumerable<Offer> Find(Func<Offer, bool> predicate)
        {
            return db.Offers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Offer co = db.Offers.Find(id);
            if (co != null)
                db.Offers.Remove(co);
        }

        public IEnumerable<Offer> FindWithCompanyOffer(Func<CompanyOffer, bool> predicate)
        {
            IEnumerable<Offer> a = db.CompanyOffers.Include(x => x.Companies).Where(predicate).SelectMany(x => x.Offers).ToList();
            return a;
        }

        public Offer GetUserID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
