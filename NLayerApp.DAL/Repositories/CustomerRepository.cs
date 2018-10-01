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
    public class CustomerRepository : IRepository<Customer>
    {
        private SearchContext db;

        public CustomerRepository(SearchContext context)
        {
            this.db = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return db.Customers;
        }

        public Customer Get(int id)
        {
            return db.Customers.Find(id);
        }

        public Customer GetUserID(string id)
        {
            return db.Customers.FirstOrDefault(x=>x.UserId==id);
        }

        public void Create(Customer customer)
        {
            db.Customers.Add(customer);
        }

        public void Update(Customer book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Customer> Find(Func<Customer, bool> predicate)
        {
            return db.Customers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            CustomerOffer co = db.CustomerOffers.Find(id);
            if (co != null)
                db.CustomerOffers.Remove(co);
        }


        public IEnumerable<Customer> FindWithCompanyOffer(Func<CompanyOffer, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
