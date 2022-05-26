using BookStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Service
{
    public interface ICategoryService
    {
        void Add(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        Category GetById(int id);
        List<Category> GetAll();
    }
}
