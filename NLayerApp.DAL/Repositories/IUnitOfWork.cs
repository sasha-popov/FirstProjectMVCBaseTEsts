
using System;

namespace NLayerApp.DAL.Entities.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<CustomerOffer> CustomerOffers { get; }
        IRepository<Category> Categories { get; }
        IRepository<Company> Companies { get; }
        IRepository<Customer> Customers { get; }
        IRepository<CompanyOffer> CompanyOffers { get; }
        IRepository<Offer> Offers { get; }
        void Save();
    }
}
