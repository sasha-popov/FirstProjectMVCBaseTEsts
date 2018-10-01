using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.EF;
using NLayerApp.DAL.Repositories;
using NLayerApp.DAL.Entities.Interfaces;

namespace NLayerApp.DAL.Repositories
{
    class CategoryRepository:IRepository<Category>
    {
        private SearchContext db;

        public CategoryRepository(SearchContext context)
        {
            this.db = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.Include(x=>x.Offers);
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public void Create(Category category)
        {
            db.Categories.Add(category);
        }

        public void Update(Category book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Category> Find(Func<Category, bool> predicate)
        {
            return db.Categories.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Category co = db.Categories.Find(id);
            if (co != null)
                db.Categories.Remove(co);
        }

        public IEnumerable<Category> FindWithCompanyOffer(Func<CompanyOffer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Category GetUserID(string id)
        {
            throw new NotImplementedException();
        }
    }
}

