using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly AppDBContext _appDBContext;

        public EfCategoryRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public void Add(Category entity)
        {
            _appDBContext.Add(entity);
            _appDBContext.SaveChanges();
        }

        public void Delete(Category entity)
        {
            _appDBContext.Remove(entity);
            _appDBContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            var category = _appDBContext.Categories.ToList();
            return category;
        }

        public Category GetById(int id)
        {
            var category = _appDBContext.Categories.FirstOrDefault(x => x.Id == id);
            return category;
        }

        public void Update(Category entity)
        {
           _appDBContext.Update(entity);
            _appDBContext.SaveChanges();
        }
    }
}
