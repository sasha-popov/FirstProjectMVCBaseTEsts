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
    public class CompanyOfferRepository: IRepository<CompanyOffer>
    {
        private SearchContext db;

        public CompanyOfferRepository(SearchContext db)
        {
            this.db = db;
        }

        public IEnumerable<CompanyOffer> GetAll()
        {
            return db.CompanyOffers;
        }

        public CompanyOffer Get(int id)
        {
            return db.CompanyOffers.Find(id);
        }

        public void Create(CompanyOffer CompanyOffer)
        {
            db.CompanyOffers.Add(CompanyOffer);
        }

        public void Update(CompanyOffer companyOffer)
        {
            db.Entry(companyOffer).State = EntityState.Modified;
        }

        public IEnumerable<CompanyOffer> Find(Func<CompanyOffer, bool> predicate)
        {
            return db.CompanyOffers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            CompanyOffer co = db.CompanyOffers.Find(id);
            if (co != null)
                db.CompanyOffers.Remove(co);
        }

        public IEnumerable<CompanyOffer> FindWithCompanyOffer(Func<CompanyOffer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public CompanyOffer GetUserID(string id)
        {
            throw new NotImplementedException();
        }
    }
}

