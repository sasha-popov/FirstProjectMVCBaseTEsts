using System;
using System.Collections.Generic;

namespace NLayerApp.DAL.Entities.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T GetUserID(string id);
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(int id);

        //Only for CompanyRepository and OfferRepository
        IEnumerable<T> FindWithCompanyOffer(Func<CompanyOffer, bool> predicate);
    }
}
